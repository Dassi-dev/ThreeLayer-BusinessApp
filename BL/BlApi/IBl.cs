
namespace BlApi;

public interface IBl
{
    public  ISale ISale { get; }
    public IProduct IProduct { get; }

    public  IOrder IOrder { get; }

    public  ICustomer ICustomer { get; }

}
