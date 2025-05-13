using DO;
using DalApi;
using Tools;
using System.Reflection;
namespace Dal;

internal class SaleImplementation : ISale
{
    public int Create(Sale item)//Creates new entity object in DAL
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale");
        Sale s = item with { ID = DataSource.Config.GetSaleRunId };
        DataSource.salesList.Add(s);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale" + item.ToString());
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale");
        return s.ID;
    }
    public Sale? Read(int id) //Reads entity object by its ID 
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale by id");
        Sale? s = DataSource.salesList.FirstOrDefault(s => s.ID == id);
        if (s == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, " sale not found");
            throw new DalKeyNotFoundException("sale not found");
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale by id");
        return s;
    }
    public Sale? Read(Func<Sale, bool> filter) // stage 2 
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale by filter");
        Sale? s = DataSource.salesList.FirstOrDefault(filter);
        if (s == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, " sale not found");
            throw new DalKeyNotFoundException("sale not found");
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale by filter");
        return s;
    }
    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)// stage 2
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll sale");
        if (!DataSource.salesList.Any())
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "sales not found");
            throw new DalArgumentNullException("the salesList is empty");
        }
        if (filter != null)
        {
            IEnumerable<Sale> salelist = DataSource.salesList.Where(filter).Select(s => s);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll sale");
            return (List<Sale?>)salelist;
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll sale");
        return DataSource.salesList;

    }
    public void Update(Sale item) //Updates entity object
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");
        Sale? Sale = DataSource.salesList.FirstOrDefault(c => c.ID == item.ID);
        if (Sale == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, " sale not found");
            throw new DalKeyNotFoundException("sale not found");
        }
        DataSource.salesList.Remove(Sale);
        DataSource.salesList.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale" + item.ToString());
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");

    }
    public void Delete(int id)//Deletes an object by its Id
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale");
        Sale Sale = Read(id);
        if (Sale == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, " sale not found");
            throw new DalKeyNotFoundException("sale not found");
        }
        DataSource.salesList.Remove(Sale);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale" + Sale.ToString());
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale");
    }
}
