
using BO;
using BlApi;




namespace BlImplementation;

public class ProductImplementation : IProduct
{
    ////private DalApi.IDal _dal = DalApi.Factory.Get;
    //static  DalApi.IDal _dal  = DalApi.Factory.Get;
    private DalApi.IDal _dal = DalApi.Factory.Get;


    public int Create(BO.Product item)
    {
        try
        {
            return _dal.Product.Create(item.Convert());
        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null", ex);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Product.Delete(id);
        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null", ex);
        }
    }
    public bool IsProductExists(BO.Product item)
    {

        try
        {
            _dal.Product.Read(item.ID);
            return true;

        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public BO.Product? Read(Func<BO.Product, bool> filter)
    {
        try
        {
            return _dal.Product.Read(c => filter(c.Convert())).Convert();
        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null", ex);
        }
    }

    public BO.Product? Read(int id)
    {
        try
        {
            return _dal.Product.Read(id).Convert();

        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null", ex);
        }
    }

    public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Product.ReadAll().Select(c => c.Convert()).ToList();
            return _dal.Product.ReadAll(c => filter(c.Convert())).Select(c => c.Convert()).ToList();
        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null", ex);
        }
    }


    public void Update(BO.Product item)
    {
        try
        {
            _dal.Product.Update(item.Convert());
        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null", ex);
        }
    }

    public void GetActivePromotions(int productId, bool isPreferredCustomer)//מתודה לקבלת כל המבצעים שבתוקף של המוצר 
    {

    }
}
