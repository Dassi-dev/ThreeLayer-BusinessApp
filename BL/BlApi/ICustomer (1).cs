using BO;

namespace BlApi
{
    public interface ICustomer : ICrud<Customer>
    {
        public bool IsCustomerExists(Customer item);//מתודה לבדיקה האם לקוח קיים
        public int Create(Customer item); //Creates new entity object in DAL
        public Customer? Read(Func<Customer, bool> filter); // stage 2
        public Customer? Read(int id); //Reads entity object by its ID 
        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null); // stage 2
        public void Update(Customer item); //Updates entity object
        public void Delete(int id); //Deletes an object by its Id
    }

}
