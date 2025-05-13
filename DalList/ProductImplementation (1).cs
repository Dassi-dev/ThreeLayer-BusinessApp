using DO;
using DalApi;
using Tools;
using System.Reflection;
namespace Dal;

internal class ProductImplementation : IProduct
{
    public int Create(Product item)//Creates new entity object in DAL
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create product");
        Product p = item with { ID = DataSource.Config.GetProductRunID };
        DataSource.productsList.Add(p);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create product "+item.ToString());
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create product");
        return p.ID;
    }
    public Product? Read(int id) //Reads entity object by its ID 
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product by id");
        Product? p = DataSource.productsList.FirstOrDefault(p => p.ID == id);
        if (p == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "product not found");
            throw new DalKeyNotFoundException("product not found");
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product by id");
        return p;
    }
    public  Product? Read(Func<Product, bool> filter)//Reads entity object by its ID 
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product by filter");
        Product? p = DataSource.productsList.FirstOrDefault(filter);
        if (p == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "product not found");
            throw new DalKeyNotFoundException("product not found");
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product by filter");
        return p;
    }
    public List<Product?> ReadAll(Func<Product, bool>? filter = null) // stage 2
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll product");
        if (!DataSource.productsList.Any())
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "products not found");
            throw new DalArgumentNullException("products not found");
        }
        if(filter != null)
        {
            IEnumerable<Product> productsList = DataSource.productsList.Where(filter).Select(p => p);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll product");
            return (List<Product?>)productsList;
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll product");
        return DataSource.productsList;
    }
    public void Update(Product item) //Updates entity object
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update product");
        Product? Product = DataSource.productsList.FirstOrDefault(c => c.ID == item.ID);
        if (Product == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "product not found");
            throw new DalKeyNotFoundException("product not found");
        }
        DataSource.productsList.Remove(Product);
        DataSource.productsList.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update product "+item.ToString());
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update product");
    }
    public void Delete(int id)//Deletes an object by its Id
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete product");
        Product Product = Read(id);
        if (Product == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "product not found");
            throw new DalKeyNotFoundException("product not found");
        }
        DataSource.productsList.Remove(Product);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete product"+ Product.ToString());
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete product");

    }
}
