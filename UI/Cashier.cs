using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlApi;
using BO;

namespace UI
{
    public partial class Cashier : Form
    {
        private IBl bl;
        private List<dynamic> currentOrderList = new List<dynamic>();
        private bool isMemberClub = false;
        public Cashier()
        {
            InitializeComponent();
            bl = Factory.Get();
            FillShowProductsIDComboBox();
        }

        private void doOrderButton_Click(object sender, EventArgs e)
        {
            if (currentOrderList == null || currentOrderList.Count == 0)
            {
                MessageBox.Show("There are no products in the order.");
                return;
            }

            foreach (var item in currentOrderList)
            {
                int productId = item.ID;
                int quantityOrdered = item.Quantity;

                try
                {
                    Product product = bl.IProduct.Read(p => p.ID == productId);
                    product.QuantityInStock -= quantityOrdered;
                    bl.IProduct.Update(product);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating stock for product {productId}: {ex.Message}");
                }
            }

            MessageBox.Show("Order completed and stock updated.");
            currentOrderList.Clear();
            currentOrderStatusdataGridView.DataSource = null;
        }

        private void FillShowProductsIDComboBox()
        {
            var products = bl.IProduct.ReadAll().ToList();
            productIdComboBox.DisplayMember = "ID";
            productIdComboBox.ValueMember = "ID";
            productIdComboBox.DataSource = products;
        }


        private void addPruductToOrderButton_Click(object sender, EventArgs e)
        {
            int productID = (int)productIdComboBox.SelectedValue;
            int requestedQuantity = (int)quantityNumericUpDown.Value;

            if (!ValidateQuantity(requestedQuantity)) return;

            Product product = bl.IProduct.Read(p => p.ID == productID);
            if (!ValidateProduct(product)) return;

            int actualQuantityToAdd = GetActualQuantity(requestedQuantity, product);
            double finalUnitPrice = GetFinalPrice(product, actualQuantityToAdd);

            AddOrUpdateProductInOrder(product, actualQuantityToAdd, finalUnitPrice);

            var currentSalesList = GetValidSales(product, actualQuantityToAdd);

            UpdateOrderGrid();
            UpdateTotalPrice();
            UpdateSalesGrid(currentSalesList);
        }

        private bool ValidateQuantity(int quantity)
        {
            if (quantity <= 0)
            {
                MessageBox.Show("Invalid order quantity");
                return false;
            }
            return true;
        }

        private bool ValidateProduct(Product product)
        {
            if (product == null)
            {
                MessageBox.Show("The product was not found.");
                return false;
            }
            return true;
        }

        private int GetActualQuantity(int requestedQuantity, Product product)
        {
            int available = product.QuantityInStock;
            if (requestedQuantity > available)
            {
                if (available == 0)
                {
                    MessageBox.Show("The product is out of stock.");
                    return 0;
                }
                MessageBox.Show($"Only {available} item(s) available in stock. {available} will be added instead of {requestedQuantity}.");
                return available;
            }
            return requestedQuantity;
        }

        private double GetFinalPrice(Product product, int quantity)
        {
            double price = product.Price ?? 0;
            if (product.sales == null) return price;

            foreach (var saleLink in product.sales)
            {
                Sale s = bl.ISale.Read(s => s.ID == saleLink.SaleID);
                bool allowed = !s.RequiredClub??false || isMemberClub;
                bool qtyOk = quantity >= s.RequiredQuantity.Value;
                bool dateOk = (s.StartDate <= DateTime.Now) && (s.EndDate >= DateTime.Now);

                if (allowed && qtyOk && dateOk)
                {
                    return price * (1 - (saleLink.Price / 100.0))??price;
                }
            }
            return price;
        }

        private void AddOrUpdateProductInOrder(Product product, int quantity, double price)
        {
            if (currentOrderList == null)
                currentOrderList = new List<object>();

            bool exists = currentOrderList.Any(p =>
            {
                var type = p.GetType();
                return type.GetProperty("RowType")?.GetValue(p)?.ToString() == "Product" &&
                       (int)type.GetProperty("ID").GetValue(p) == product.ID;
            });

            if (exists)
            {
                currentOrderList = currentOrderList.Select(p =>
                {
                    var type = p.GetType();
                    if (type.GetProperty("RowType")?.GetValue(p)?.ToString() == "Product" &&
                        (int)type.GetProperty("ID").GetValue(p) == product.ID)
                    {
                        int oldQty = (int)type.GetProperty("Quantity").GetValue(p);
                        return new
                        {
                            RowType = "Product",
                            ID = product.ID,
                            Name = product.ProductName,
                            Category = product.Category,
                            Price = price,
                            QuantityInStock = product.QuantityInStock,
                            Quantity = oldQty + quantity
                        };
                    }
                    return p;
                }).ToList();
            }
            else
            {
                currentOrderList.Add(new
                {
                    RowType = "Product",
                    ID = product.ID,
                    Name = product.ProductName,
                    Category = product.Category,
                    Price = price,
                    QuantityInStock = product.QuantityInStock,
                    Quantity = quantity
                });
            }
        }

        private List<object> GetValidSales(Product product, int quantity)
        {
            List<object> list = new List<object>();
            if (product.sales == null) return list;

            foreach (var link in product.sales)
            {
                Sale s = bl.ISale.Read(s => s.ID == link.SaleID);

                bool allowed = !s.RequiredClub ?? false || isMemberClub;
                bool qtyOk = !s.RequiredQuantity.HasValue || quantity >= s.RequiredQuantity.Value;
                bool dateOk = (!s.StartDate.HasValue || s.StartDate <= DateTime.Now) &&
                              (!s.EndDate.HasValue || s.EndDate >= DateTime.Now);

                if (allowed && qtyOk && dateOk)
                {
                    list.Add(new
                    {
                        SaleID = s.ID,
                        ProductID = product.ID,
                        Description = $"Discount: {link.Price}%",
                        RequiredQuantity = s.RequiredQuantity,
                        RequiredClub = s.RequiredClub,
                        StartDate = s.StartDate,
                        EndDate = s.EndDate,
                        TotalPrice = s.TotalPrice
                    });
                }
            }
            return list;
        }

        private void UpdateOrderGrid()
        {
            currentOrderStatusdataGridView.DataSource = currentOrderList;
            currentOrderStatusdataGridView.Visible = true;
        }

        private void UpdateTotalPrice()
        {
            double total = currentOrderList.Cast<dynamic>()
                .Sum(p => (double)p.Price * (int)p.Quantity);
            totalPriceTextBox.Text = total.ToString("F2");
        }

        private void UpdateSalesGrid(List<object> sales)
        {
            if (sales.Count > 0)
            {
                salesDataGridView.DataSource = sales;
                salesDataGridView.Visible = true;
            }
            else
            {
                salesDataGridView.Visible = false;
            }
        }

        private void CustomerApprovalButton_Click(object sender, EventArgs e)
        {
            string customerIdText = customerIDTextBox.Text;

            if (!int.TryParse(customerIdText, out int customerId))
            {
                MessageBox.Show("Please enter a valid customer ID.");
                return;
            }
            try
            {
                Customer customer = bl.ICustomer.Read(customerId);
                if (customer == null)
                    MessageBox.Show("This customer is not a member of the club.");
                else
                {
                    MessageBox.Show("This customer is a member of the club.");
                    isMemberClub = true;
                }
            }
            catch
            {
                MessageBox.Show("There was an error while checking the customer.");
            }
            customerIDTextBox.Enabled = false;
        }
    }
}
