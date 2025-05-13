using BO;


namespace BlApi
{
    public interface IOrder
    {
        public List<SaleInProduct> AddProductToOrder(Order order, int productId, int quantity);//מתודה להוספת מוצר להזמנה 

        public void CalcTotalPriceForProduct(ProductInOrder productInOrder);//מתודה לחישוב המחיר הסופי למוצר 


        public void CalcTotalPrice(Order order);//מתודה לחישוב המחיר הסופי להזמנה 


        public void DoOrder(Order order);//מתודה לביצוע הזמנה 


        public void SearchSaleForProduct(ProductInOrder product, bool ?isPreferredCustomer);//עדכון המבצעים המתאימים למוצר בהזמנה 
    }
}
