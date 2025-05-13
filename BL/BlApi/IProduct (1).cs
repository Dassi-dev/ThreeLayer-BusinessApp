using BO;

namespace BlApi
{
    public interface IProduct : ICrud<Product>
    {
        public int Create(Product item); //Creates new entity object in DAL
        public Product? Read(Func<Product, bool> filter); // stage 2
        public Product? Read(int id); //Reads entity object by its ID 
        public List<Product?> ReadAll(Func<Product, bool>? filter = null); // stage 2
        public void Update(Product item); //Updates entity object
        public void Delete(int id); //Deletes an object by its Id
        public void GetActivePromotions(int productId, bool isPreferredCustomer);//מתודה לקבלת כל המבצעים שבתוקף של המוצר 

    }
}
