
namespace BO;

public class SaleInProduct
{
    public int? SaleID { get; init; } // מזהה מבצע
    public int? Quantity{ get; set; } // כמות למבצע
    public double? Price { get; set; } // מחיר
    public bool? IsForAllCustomers { get; set; } // האם המבצע מיועד לכל הלקוחות

    public SaleInProduct(int? saleID, int? quantity, double? price, bool? isForAllCustomers)
    {
        SaleID = saleID;
        Quantity = quantity;
        Price = price;
        IsForAllCustomers = isForAllCustomers;
    }
    public override string ToString() => this.ToStringProperty();
}
