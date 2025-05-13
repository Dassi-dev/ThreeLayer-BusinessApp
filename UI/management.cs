using BlImplementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlImplementation;
using BlApi;
using BO;
using System.Security.Cryptography.Xml;

namespace UI
{
    public partial class management : Form
    {
        IBl bl;
        string type;
        public management(string type)
        {
            InitializeComponent();



            bl = Factory.Get();

            this.type = type;


        }





        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            CustomerFormr customer = new CustomerFormr();
            customer.Show();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            SaleForm sale = new SaleForm();
            sale.Show();
        }
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    switch (type)
        //    {
        //        case "Customer":
        //            // פתח טופס הוספת לקוח
        //            new AddCustomerForm(bl).ShowDialog();
        //            break;
        //        case "Product":
        //            new AddProductForm(bl).ShowDialog();
        //            break;
        //        case "Sale":
        //            new AddSaleForm(bl).ShowDialog();
        //            break;
        //    }
        //    fillDataGread();
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count == 0)
        //        return;

        //    var selectedItem = dataGridView1.SelectedRows[0].DataBoundItem;

        //    switch (type)
        //    {
        //        case "Customer":
        //            var customer = selectedItem as Customer;
        //            new UpdateCustomerForm(bl, customer.ID).ShowDialog();
        //            break;
        //        case "Product":
        //            var product = selectedItem as Product;
        //            new UpdateProductForm(bl, product.ID).ShowDialog();
        //            break;
        //        case "Sale":
        //            var sale = selectedItem as Sale;
        //            new UpdateSaleForm(bl, sale.ID).ShowDialog();
        //            break;
        //    }
        //    fillDataGread();
        //}

    }
}
