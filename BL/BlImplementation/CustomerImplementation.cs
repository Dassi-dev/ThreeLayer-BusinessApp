

using BlApi;
using BO;
namespace BlImplementation;
internal class CustomerImplementation : ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Customer item)
    {
        try
        {
            return _dal.Customer.Create(item.Convert());
        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null",ex);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Customer.Delete(id);
        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null",ex);
        }
    }

    public bool IsCustomerExists(BO.Customer item)
    {

        try
        {
            _dal.Customer.Read(item.ID);
            return true;

        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        try
        {
            return _dal.Customer.Read(c=>filter(c.Convert())).Convert();
        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null", ex);
        }
    }

    public Customer? Read(int id)
    {
        try
        {
            return _dal.Customer.Read(id).Convert();

        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null", ex);
        }
    }

    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        try
        {
            if(filter == null)
                return _dal.Customer.ReadAll().Select(c=>c.Convert()).ToList();
            return _dal.Customer.ReadAll(c=>filter(c.Convert())).Select(c => c.Convert()).ToList();
        }
        catch(Exception ex)
        {
            throw new BlArgumentNullException("Argument Null", ex);
        }
    }

    public void Update(Customer item)
    {
        try
        {
             _dal.Customer.Update(item.Convert());
        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null", ex);
        }
    }
}
