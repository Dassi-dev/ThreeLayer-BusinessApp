using DalApi;
using DO;
using System.Xml.Serialization;

namespace Dal;

internal class SaleImplementation : ISale
{
    const string PATH = @"..\xml\sales.xml";

    public int Create(Sale sale)
    {
        Sale s = sale with { ID = Config.SaleRunId};
        List<Sale> sales =LoadList();
        sales.Add(s);
        SaveList(sales);
        return s.ID;
    }

    public void Delete(int id)
    {
        List<Sale> sales = LoadList();
        Sale Sale = sales.FirstOrDefault(Sale => Sale.ID == id);
        sales.Remove(Sale);
        SaveList(sales);
    }

    public Sale? Read(int id)
    {
        List<Sale> sales = LoadList();
        return sales.FirstOrDefault(sale => sale.ID == id);
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        List<Sale> sales = LoadList();
        return sales.FirstOrDefault(filter);
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        List<Sale> sales = LoadList();
        if (!sales.Any())
        {
            throw new DalArgumentNullException("Sales not found");
        }
        if (filter != null)
        {
            IEnumerable<Sale> SalesList = sales.Where(c => filter(c)).Select(c => c);
            return (List<Sale?>)SalesList;
        }
        return sales;
    }

    public void Update(Sale item)
    {
        List<Sale> sales = LoadList();
        Sale? sale = sales.FirstOrDefault(c => c.ID == item.ID);
        if (sale == null)
        {
            throw new DalKeyNotFoundException("Sale not found");
        }
        sales.Remove(sale);
        SaveList(sales);
    }
    public List<Sale> LoadList()
    { 
        XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        List<Sale> sales;
        using (StreamReader sr = new StreamReader(PATH))
        {
            try
            {
                sales = serializer.Deserialize(sr) as List<Sale>;
            }
            catch
            {
                return new List<Sale>();

            }
        }
        return sales;
    }
    public void SaveList(List<Sale> sales)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        using (StreamWriter sw = new StreamWriter(PATH))
        {
            serializer.Serialize(sw, sales);
        }
    }
}
