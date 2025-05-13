
namespace BO;

public class Customer
{
    public int ID { get; init; }//תעודת זהות
    public string? CustomerName { get; set; }//שם הלקוח
    public string? Address { get; set; }//כתובת
    public string? Phone { get; set; }  //טלפון

    public Customer(int id, string? customerName, string? address, string? phone)
    {
        ID = id;
        CustomerName = customerName;
        Address = address;
        Phone = phone;
    }
    public override string ToString() => this.ToStringProperty();
}
