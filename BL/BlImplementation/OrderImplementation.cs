
using BlApi;
using BO;

namespace BlImplementation;

internal class OrderImplementation : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public List<SaleInProduct> AddProductToOrder(Order order, int productId, int quantity)
    {
        Product p = _dal.Product.Read(productId).Convert();
        ProductInOrder product = new ProductInOrder(p.ID, p.ProductName, p.Price, p.QuantityInStock, p.sales, 0);
        ProductInOrder productInOrder = order.ProductsInOrder.FirstOrDefault(product);
       
        if (productInOrder != null)
        {
            if (!(product.QuantityOrdered >= quantity))
                throw new BlOutOfStockException("There is not enough stock of the product: " + product);
            productInOrder.QuantityOrdered += quantity;
        }
        else
        {
            if (!(product.QuantityOrdered >= quantity))
                throw new BlOutOfStockException("There is not enough stock of the product: " + product);
            order.ProductsInOrder.Add(product);
        }
        SearchSaleForProduct(productInOrder,order.IsPreferredCustomer);
        CalcTotalPriceForProduct(productInOrder);
        CalcTotalPrice(order);
        return product.Sales;
    }

    public void CalcTotalPrice(Order order)
    {
        order.TotalPrice = order.ProductsInOrder.Select(p => p.FinalPrice).Sum();
    }

    public void CalcTotalPriceForProduct(ProductInOrder productInOrder)
    {
        int? count = productInOrder.QuantityOrdered;
        List<SaleInProduct> sales = new List<SaleInProduct>();
        foreach (SaleInProduct sale in productInOrder.Sales)
        {
            if (count == 0)
                break;
            if (count < sale.Quantity)
                continue;
            productInOrder.FinalPrice += (count / sale.Quantity) * sale.Price;
            count -= count % sale.Quantity;
            sales.Add(sale);
        }
        productInOrder.FinalPrice += count * productInOrder.BasePrice;
        productInOrder.Sales = sales;
    }

    public void DoOrder(Order order)
    {
        foreach (ProductInOrder p in order.ProductsInOrder)
        {
            Product product = _dal.Product.Read(p.ProductID??1).Convert();
            product.QuantityInStock -= p.QuantityOrdered ?? 1;
            _dal.Product.Update(product.Convert());
        }

    }

    public void SearchSaleForProduct(ProductInOrder product, bool? isPreferredCustomer)
    {

        IEnumerable<Sale> sales = _dal.Sale.ReadAll(s => s.productID == product.ProductID && s.endDate <= DateTime.Now && s.startDate >= DateTime.Now
        && s.requiredQuantity <= product.QuantityOrdered && s.startDate <= DateTime.Now && s.endDate >= DateTime.Now).
        OrderBy(s => s.totalPrice / product.QuantityOrdered).Select(s => s.Convert());

        List<SaleInProduct> saleInProducts = sales.Select(s =>
            new SaleInProduct(s.ProductID, s.RequiredQuantity, s.TotalPrice,
            s.RequiredClub)).ToList();
    }
}
