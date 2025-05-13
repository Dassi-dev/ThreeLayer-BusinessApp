
namespace BO;

public class ProductInOrder
{
    public int? ProductID { get; init; } // מזהה מוצר
    public string? ProductName { get; set; } // שם מוצר
    public double? BasePrice { get; set; } // מחיר בסיס למוצר
    public int? QuantityOrdered { get; set; } // כמות בהזמנה
    public List<SaleInProduct> Sales { get; set; } // רשימת מבצעים למוצר זה
    public double? FinalPrice { get; set; } // מחיר סופי למוצר

    public ProductInOrder(int? productId, string? productName, double? basePrice, int? quantityOrdered, List<SaleInProduct> sales, double? finalPrice)
    {
        ProductID = productId;
        ProductName = productName;
        BasePrice = basePrice;
        QuantityOrdered = quantityOrdered;
        Sales = sales;
        FinalPrice = finalPrice;
    }

    public override string ToString() => this.ToStringProperty();
}
