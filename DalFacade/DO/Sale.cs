using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DO
{
    public record Sale//פרטי המבצע
        (int ID,//מספר מזהה ייחודי  - כמו ברקוד
        int? productID,//קוד המוצר
        int? requiredQuantity,//	כמות נדרשת לקבלת המבצע
        double? totalPrice,//	כמות נדרשת לקבלת המבצע
        bool? requiredClub,//האם המבצע מיועד לכלל הלקוחות או רק ללקוחות מועדון
        DateTime? startDate,//	תאריך תחילת המבצע
        DateTime? endDate//	תאריך סיום המבצע
    )
    {
        public Sale() : this(0,null, null, null, null, null, null)
        {

        }
        public Sale(Sale s)
        {
            this.ID = s.ID;
            this.productID = s.productID;
            this.requiredQuantity = s.requiredQuantity;
            this.totalPrice = s.totalPrice;
            this.requiredClub = s.requiredClub;
            this.startDate =   s.startDate;
            this.endDate = s.endDate;
        }
    }
}