
namespace BO;

public class Product
{
    public int ID { get; init; } // מספר מזהה ייחודי - כמו ברקוד
    public string? ProductName { get; set; } // שם המוצר
    public Category? Category { get; set; } // קטגוריה
    public double? Price { get; set; } // מחיר
    public int QuantityInStock { get; set; } // כמות במלאי
    public List<SaleInProduct> sales { get; set; } // רשימת מבצעים למוצר זה

    public Product(int id, string? productName, Category? category, double? price, int quantityInStock)
    {
        ID = id;
        ProductName = productName;
        Category = category;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    public override string ToString() => this.ToStringProperty();
}
