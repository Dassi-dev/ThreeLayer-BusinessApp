
namespace BO;

public class Sale
{
    public int ID { get; init; } // מספר מזהה ייחודי - כמו ברקוד
    public int? ProductID { get; set; } // קוד המוצר
    public int? RequiredQuantity { get; set; } // כמות נדרשת לקבלת המבצע
    public double? TotalPrice { get; set; } // מחיר כולל
    public bool? RequiredClub { get; set; } // האם המבצע מיועד לכלל הלקוחות או רק ללקוחות מועדון
    public DateTime? StartDate { get; set; } // תאריך תחילת המבצע
    public DateTime? EndDate { get; set; } // תאריך סיום המבצע

    public Sale(int id, int? productId, int? requiredQuantity, double? totalPrice, bool? requiredClub, DateTime? startDate, DateTime? endDate)
    {
        ID = id;
        ProductID = productId;
        RequiredQuantity = requiredQuantity;
        TotalPrice = totalPrice;
        RequiredClub = requiredClub;
        StartDate = startDate;
        EndDate = endDate;
    }
    public override string ToString() => this.ToStringProperty();
}
