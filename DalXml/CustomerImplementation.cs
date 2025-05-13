using DalApi;
using DO;
using System.Xml.Serialization;
namespace Dal;

internal class CustomerImplementation : ICustomer
{
    const string PATH = @"..\xml\customers.xml"; 

    public int Create(Customer customer)
    {
        List<Customer> customers=LoadList();
        customers.Add(customer);
        SaveList(customers);
        return customer.ID;
    }

    public void Delete(int id)
    {
        List<Customer> customers= LoadList();
        Customer customer = customers.FirstOrDefault(customer => customer.ID == id);
        customers.Remove(customer);
        SaveList(customers);
    }

    public Customer? Read(int id)
    {
        List<Customer> customers = LoadList();
        return customers.FirstOrDefault(customer => customer.ID == id);
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        List<Customer> customers = LoadList();
        return customers.FirstOrDefault(filter);
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        List<Customer> customers = LoadList();
        if (!customers.Any())
        {
            throw new DalArgumentNullException("customers not found");
        }
        if (filter != null)
        {
            IEnumerable<Customer> customersList = customers.Where(c => filter(c)).Select(c => c);
            return (List<Customer?>)customersList;
        }
        return customers;
    }

    public void Update(Customer item)
    {
        List<Customer> customers = LoadList();
        Customer? customer = customers.FirstOrDefault(c => c.ID == item.ID);
        if (customer == null)
        {
            throw new DalKeyNotFoundException("customer not found");
        }
        customers.Remove(customer);
        SaveList(customers);
    }
    public List<Customer> LoadList()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer> customers;
        using (StreamReader sr = new StreamReader(PATH))
        {
            try
            {
                customers = serializer.Deserialize(sr) as List<Customer>;
            }
            catch
            {
                return new List<Customer>();
            }
        }
        return customers;
    }
    public void SaveList(List<Customer> customers)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        using (StreamWriter sw = new StreamWriter(PATH))
        {
            serializer.Serialize(sw, customers);
        }
    }
}
