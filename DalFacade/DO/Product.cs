

using System.Data.Common;

namespace DO
{
    public record Product //פרטי המוצר
        (int ID,//מספר מזהה ייחודי  - כמו ברקוד
        string? productName,//שם המוצר
        Category? category,//	קטגוריה
        double? price,//	מחיר
        int quantityInStock)//כמות במלאי
    {
        public Product() : this(0, null, null, null, 0)
        {

        }
        
        public Product(Product p)
        {
            this.ID = p.ID;
            this.productName = p.productName;
            this.category = p.category;
            this.price = p.price;
            this.quantityInStock = p.quantityInStock;
        }
    }
}
