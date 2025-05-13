
using System.Reflection;
using System.Text;

namespace BO;

internal static class Tools
{
    public static string ToStringProperty<T>(this T obj, string prefix = "")
    {
        StringBuilder sb = new StringBuilder();

        Type type = obj.GetType();
        foreach (PropertyInfo prop in type.GetProperties())
        {

            sb.AppendLine($"{prefix}{prop.Name}= {prop.GetValue(obj)}");

        }

        return sb.ToString();
    }
    public static DO.Customer Convert(this BO.Customer customer)
    {
        return new DO.Customer(customer.ID, customer.CustomerName, customer.Address, customer.Phone);
    }
    public static BO.Customer Convert(this DO.Customer customer)
    {
        return new BO.Customer(customer.ID, customer.customerName, customer.address, customer.phone);
    }
    public static DO.Sale Convert(this BO.Sale sale)
    {
        return new DO.Sale(sale.ID, sale.ProductID, sale.RequiredQuantity, sale.TotalPrice, sale.RequiredClub, sale.StartDate, sale.EndDate);
    }
    public static BO.Sale Convert(this DO.Sale sale)
    {
        return new BO.Sale(sale.ID, sale.productID, sale.requiredQuantity, sale.totalPrice, sale.requiredClub, sale.startDate, sale.endDate);
    }
    public static DO.Product Convert(this BO.Product product)
    {
        return new DO.Product(product.ID, product.ProductName, (DO.Category)product.Category, product.Price, product.QuantityInStock);
    }
    public static BO.Product Convert(this DO.Product product)
    {
        return new BO.Product(product.ID, product.productName, (BO.Category)product.category, product.price, product.quantityInStock);
    }
}
