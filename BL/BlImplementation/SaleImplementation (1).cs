

using BlApi;
using BO;

namespace BlImplementation;

internal class SaleImplementation : ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Sale item)
    {
        try
        {
            return _dal.Sale.Create(item.Convert());
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
            _dal.Sale.Delete(id);
        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null",ex);
        }
    }
    public bool IsSaleExists(BO.Sale item)
    {
        try
        {
            _dal.Sale.Read(item.ID);
            return true;

        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        try
        {
            return _dal.Sale.Read(c => filter(c.Convert())).Convert();
        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null",ex);
        }
    }

    public Sale? Read(int id)
    {
        try
        {
            return _dal.Sale.Read(id).Convert();

        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null",ex);
        }
    }

    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Sale.ReadAll().Select(c => c.Convert()).ToList();
            return _dal.Sale.ReadAll(c => filter(c.Convert())).Select(c => c.Convert()).ToList();
        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null",ex);
        }
    }

    public void Update(Sale item)
    {
        try
        {
            _dal.Sale.Update(item.Convert());
        }
        catch (Exception ex)
        {
            throw new BlArgumentNullException("Argument Null",ex);
        }
    }
}
