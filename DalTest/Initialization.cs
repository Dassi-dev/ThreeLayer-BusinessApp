using DO;
using DalApi;

namespace DalTest;

public class Initialization
{
    private static IDal? s_dal;
    public static void CreateCustomer()
    {
        s_dal.Customer.Create(new Customer(215282583, "Sari", "Tel-Aviv", "0583214067"));
        s_dal.Customer.Create(new Customer(215282584, "Yael", "Modi'in", "0583275017"));
        s_dal.Customer.Create(new Customer(215282458, "Moshe", "Heifa", "0583214057"));
        s_dal.Customer.Create(new Customer(215287893, "Yair", "Jerusalem", "0583212757"));
        s_dal.Customer.Create(new Customer(215282583, "Michal", "Tel-Aviv", "0583217047"));
    }
    public static void CreateSale()
    {
        s_dal.Sale.Create(new Sale(0,100,3,150,true,DateTime.Now, DateTime.Now.AddDays(14)));
        s_dal.Sale.Create(new Sale(0, 150, 5, 100, true, DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(1).AddMonths(2))); 
        s_dal.Sale.Create(new Sale(0, 200, 1, 100, true, DateTime.Now.AddDays(1), DateTime.Now.AddDays(2)));
        s_dal.Sale.Create(new Sale(0, 250, 1, 3850, false, DateTime.Now.AddDays(1), DateTime.Now.AddDays(2)));
        s_dal.Sale.Create(new Sale(0, 300, 2, 65, true, DateTime.Now, DateTime.Now.AddYears(1)));
    }
    public static void CreateProduct()
    {
        s_dal.Product.Create(new Product(0,"PinkShirt", Category.Clothing,60,20));
        s_dal.Product.Create(new Product(0, "Hairband", Category.Accessorize, 30, 30));
        s_dal.Product.Create(new Product(0, "Booster", Category.CarEquipment, 200, 7));
        s_dal.Product.Create(new Product(0, "DonaStroller", Category.Stroller, 4000, 2));
        s_dal.Product.Create(new Product(0, "buttel", Category.Equipment, 40, 20));

    }
    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        CreateCustomer();
        CreateProduct();
        CreateSale();
    }

}
