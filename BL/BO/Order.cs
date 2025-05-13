
namespace BO;

public class Order
{
    public bool? IsPreferredCustomer { get; set; } // האם זו הזמנה של לקוח "מועדף" או לקוח מזדמן
    public List<ProductInOrder> ProductsInOrder { get; set; } // רשימת המוצרים בהזמנה
    public double? TotalPrice { get; set; } // המחיר הסופי לתשלום

    public Order(bool? isPreferredCustomer, List<ProductInOrder> productsInOrder, double? totalPrice)
    {
        IsPreferredCustomer = isPreferredCustomer;
        ProductsInOrder = productsInOrder;
        TotalPrice = totalPrice;
    }
    public override string ToString() => this.ToStringProperty();
}
