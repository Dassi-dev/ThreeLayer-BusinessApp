using DO;
using DalApi;
using System.Xml.Linq;
namespace Dal;

internal class ProductImplementation : IProduct

{
    const string PATH = @"..\xml\products.xml";
    const string PRODUCTS = "Products";
    const string PRODUCT = "Product";
    const string PRODUCTID = "ID";
    const string PRODUCTNAME = "productName";
    const string CATEGORY = "category";
    const string PRICE = "price";
    const string QUANTITYONSTOCK = "quantityInStock";


    public int Create(Product item)
    {
        XElement productElement = XElement.Load(PATH);
        Product p = item with { ID = Config.ProductRunId };

        productElement.Add(new XElement(PRODUCT, new XElement(PRODUCTID, p.ID),
                                             new XElement(PRODUCTNAME, item.productName),
                                             new XElement(CATEGORY, item.category),
                                             new XElement(PRICE, item.price),
                                             new XElement(QUANTITYONSTOCK, item.quantityInStock)));
        productElement.Save(PATH);
        return p.ID;
    }

    public void Delete(int id)
    {
        XElement productElement = XElement.Load(PATH);
        productElement.Descendants(PRODUCTID).FirstOrDefault(p => p.Value.Equals(id)).Parent.Remove();
        productElement.Save(PATH);
    }

    public Product? Read(Func<Product, bool> filter)
    {
        XElement productElement = XElement.Load(PATH);
        XElement productByID = XElement.Load(PATH).Descendants(PRODUCT)
            .FirstOrDefault(p => filter != null && filter(new Product((int)p.Element(PRODUCTID), (string)p.Element(PRODUCTNAME), (Category)Enum.Parse(typeof(Category), p.Element(CATEGORY).Value), (double)p.Element(PRICE), (int)p.Element(QUANTITYONSTOCK))));
        if (productByID == null)
            throw new DalKeyNotFoundException("");
        Product product = new Product((int)productByID.Element(PRODUCTID), (string)productByID.Element(PRODUCTNAME), (Category)Enum.Parse(typeof(Category), productByID.Element(CATEGORY).Value), (double)productByID.Element(PRICE), (int)productByID.Element(QUANTITYONSTOCK));
        productElement.Save(PATH);
        return product;
    }

    public Product? Read(int id)
    {
        XElement productElement = XElement.Load(PATH);
        XElement p = productElement.Descendants(PRODUCT).FirstOrDefault(p => int.Parse(p.Element(PRODUCTID).Value) == id);
        if (p == null)
            throw new DalKeyNotFoundException("");
        Product product = new Product(int.Parse(p.Element(PRODUCTID).Value), (string)p.Element(PRODUCTNAME).Value, Enum.Parse<Category>(p.Element(CATEGORY).Value), double.Parse(p.Element(PRICE).Value), int.Parse(p.Element(QUANTITYONSTOCK).Value));
        productElement.Save(PATH);
        return product;

    }
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        XElement productElement = XElement.Load(PATH);
        if (filter == null)
        {
            List<Product> list = new List<Product>(productElement.Descendants(PRODUCT)
                .Select(p => new Product(int.Parse(p.Element(PRODUCTID).Value), p.Element(PRODUCTNAME).Value, Enum.Parse<Category>(p.Element(CATEGORY).Value), double.Parse(p.Element(PRICE).Value), int.Parse(p.Element(QUANTITYONSTOCK).Value))).ToList());
            productElement.Save(PATH);
            return list;
        }
        List<Product> list1 = new List<Product>(productElement.Descendants(PRODUCT)
                            .Select(p => new Product(int.Parse(p.Element(PRODUCTID).Value), (string)p.Element(PRODUCTNAME).Value, Enum.Parse<Category>(p.Element(CATEGORY).Value), double.Parse(p.Element(PRICE).Value), int.Parse(p.Element(QUANTITYONSTOCK).Value))).Where(p => filter(p)).ToList());
        productElement.Save(PATH);
        return list1;

    }

    public void Update(Product item)
    {
        XElement productElement = XElement.Load(PATH);
        Delete(item.ID);
        productElement.Element(PRODUCTS).Add(item);
        productElement.Save(PATH);
    }
}
