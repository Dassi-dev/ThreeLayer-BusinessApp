
using DalApi;
namespace Dal;

internal sealed class  DalList:IDal
{
    private DalList()
    {
        
    }
    public IProduct Product => new ProductImplementation();
    public ISale Sale => new SaleImplementation();
    public ICustomer Customer => new CustomerImplementation();
    public static DalList Instance { get; } = new DalList();

}
