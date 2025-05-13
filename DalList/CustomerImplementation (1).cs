using System.Reflection;
using DO;
using DalApi;
using Tools;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    public int Create(Customer item)//Creates new entity object in DAL
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create Customer");
        if (DataSource.productsList.Any(c => c.ID == item.ID))
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customer already exist " + item.ToString());
            throw new DalKeyAlreadyExistException("ID already exists");

        }
        DataSource.customersList.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "added customer" + item.ToString());
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create Customer");
        return item.ID;
    }
    public Customer? Read(int id) //Reads entity object by its ID 
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read Customer by id");
        Customer? c = DataSource.customersList.FirstOrDefault(c => c.ID == id);
        if (c == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customer not found");
            throw new DalKeyNotFoundException("customer not found");
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read Customer by id");
        return c;
    }
    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read Customer by filter");
        Customer? customer = DataSource.customersList.FirstOrDefault(filter);
        if (customer == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customer not found");
            throw new DalKeyNotFoundException("customer not found");
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read Customer by filter");
        return customer;
    }
    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null) // stage 2
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll Customer");
        if (!DataSource.customersList.Any())
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customers not found");
            throw new DalArgumentNullException("customers not found");
        }
        if(filter != null)
        {
            IEnumerable<Customer> customersList = DataSource.customersList.Where(c => filter(c)).Select(c => c);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll Customer");
            return (List<Customer?>)customersList;
        }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll Customer");
        return DataSource.customersList;
    }
    public void Update(Customer item) //Updates entity object
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Update Customer");
        Customer? customer = DataSource.customersList.FirstOrDefault(c => c.ID == item.ID);
        if(customer == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customer not found");
            throw new DalKeyNotFoundException("customer not found");
        }
        DataSource.customersList.Remove(customer);
        DataSource.customersList.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Update customer"+item.ToString());
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Update Customer");
    }
    public void Delete(int id)//Deletes an object by its Id
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Delete Customer");
        Customer customer = Read(id);
        if (customer == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customer not found");
            throw new DalKeyNotFoundException("customer not found");
        }
        DataSource.customersList.Remove(customer);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Delete customer"+customer.ToString());
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Delete Customer");
    }
}
