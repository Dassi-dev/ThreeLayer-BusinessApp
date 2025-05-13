
using DalApi;
using DO;
using Tools;
namespace DalTest
{
    internal class Program
    {
        static readonly IDal s_dal = DalApi.Factory.Get;
        static void Main(string[] args)
        {
            Console.WriteLine("To Initaliz press 1 eles press 0 ");
            int initaliz;
            if (!int.TryParse(Console.ReadLine(), out initaliz))
                throw new DalKeyNotFoundException("pressing not legal");
            if (initaliz == 1)
                DalTest.Initialization.Initialize();

            int select = printMainMenu();
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        productMenu();
                        break;
                    case 2:
                        saleMenu();
                        break;
                    case 3:
                        customerMenu();
                        break;
                      case 4:
                        LogManager.DeleteLog();
                        break;
                    default:
                        Console.WriteLine("Wrong selection, please select again");
                        break;
                }
                select = printMainMenu();
            }
        }

        private static int printMainMenu()
        {
            Console.WriteLine("For product press 1");
            Console.WriteLine("For sale press 2");
            Console.WriteLine("For customer press 3");
            Console.WriteLine("TO delete old files in Log file press 4");
            Console.WriteLine("To exit press 0");
            int select;
            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;
            return select;
        }
        private static int printSubMenu(string item)
        {
            Console.WriteLine($"To add {item} press 1");
            Console.WriteLine($"To read {item} press 2");
            Console.WriteLine($"To readAll {item}s press 3");
            Console.WriteLine($"To update {item} press 4");
            Console.WriteLine($"To delete {item} press 5");
            Console.WriteLine("To go back press 0");

            int select;
            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;

            return select;
        }
        private static void saleMenu()
        {
            int select = printSubMenu("sale");
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        s_dal.Sale.Create(insertSaleDetailes());
                        break;
                    case 2:
                        read<Sale>(s_dal.Sale);
                        break;
                    case 3:
                        readAll<Sale>(s_dal.Sale);
                        break;
                    case 4:
                        s_dal.Sale.Update(updateSale());
                        break;
                    case 5:
                        delete<Sale>(s_dal.Sale);
                        break;
                    default:
                        Console.WriteLine("Wrong selection, please select again");
                        break;
                }
                select = printSubMenu("sale");
            }
        }
        private static void customerMenu()
        {
            int select = printSubMenu("customer");
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        s_dal.Customer.Create(insertCustomerDetailes());
                        break;
                    case 2:
                        read<Customer>(s_dal.Customer);
                        break;
                    case 3:
                        readAll<Customer>(s_dal.Customer);
                        break;
                    case 4:
                        s_dal.Customer.Update(updateCustomer());
                        break;
                    case 5:
                        delete<Customer>(s_dal.Customer);
                        break;
                    default:
                        Console.WriteLine("Wrong selection, please select again");
                        break;
                }
                select = printSubMenu("customer");
            }
        }
        private static void productMenu()
        {
            int select = printSubMenu("product");
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        s_dal.Product.Create(insertProductDetailes());
                        break;
                    case 2:
                        read<Product>(s_dal.Product);
                        break;
                    case 3:
                        readAll<Product>(s_dal.Product);
                        break;
                    case 4:
                        s_dal.Product.Update(updateProduct());
                        break;
                    case 5:
                        delete<Product>(s_dal.Product);
                        break;
                    default:
                        Console.WriteLine("Wrong selection, please select again");
                        break;
                }
                select = printSubMenu("product");
            }
        }
        private static int printCategoryOptions()
        {
            Category c;
            Console.WriteLine("choose category:");
            Console.WriteLine("for Clothing press 1");
            Console.WriteLine("for Stroller press 2");
            Console.WriteLine("for Equipment press 3");
            Console.WriteLine("for Accessorize press 4");
            Console.WriteLine("for CarEquipment press 5");
            int select;
            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;
            return select;
        }
        private static Category chooseCategory()
        {
            int select = printCategoryOptions();
            while (!(select >= 1 && select <= 5))
                select = printCategoryOptions();
            return (Category)select;

        }
        private static void read<T>(ICrud<T> crud)
        {
            int id;
            Console.WriteLine("insert id for read");
            int.TryParse(Console.ReadLine(), out id);
            Console.WriteLine(crud.Read(id));
        }
        private static void readAll<T>(ICrud<T> crud)
        {
            foreach (var item in crud.ReadAll())
            {
                Console.WriteLine(item);
            }
        }

        private static Sale insertSaleDetailes(int id = 0)
        {
            Sale sale;
            try
            {
                if (id == 0)
                    Console.WriteLine("insert sale details");
                int productID;
                Console.Write("productID: ");
                int.TryParse(Console.ReadLine(), out productID);
                int requiredQuantity;
                Console.Write("required Quantity for getting the sale: ");
                int.TryParse(Console.ReadLine(), out requiredQuantity);
                double totalPrice;
                Console.Write("total Price of the sale: ");
                double.TryParse(Console.ReadLine(), out totalPrice);
                bool requiredClub;
                Console.Write("if required Club: ");
                bool.TryParse(Console.ReadLine(), out requiredClub);
                DateTime startDate;
                Console.Write("start Date Club: ");
                DateTime.TryParse(Console.ReadLine(), out startDate);
                DateTime endDate;
                Console.Write("end Date Club: ");
                DateTime.TryParse(Console.ReadLine(), out endDate);
                return sale = new Sale(id, productID, requiredQuantity, totalPrice, requiredClub, startDate, endDate);
            }
            catch
            {
                Console.WriteLine("you insert uncorrect infomation");
                return sale = new Sale();
            }
        }
        private static Sale updateSale()
        {
            int id;
            Console.WriteLine("insert your updating details");
            Console.WriteLine("id: ");
            int.TryParse(Console.ReadLine(), out id);
            return insertSaleDetailes(id);
        }
        private static Customer insertCustomerDetailes(int id = 0)
        {
            Customer customer;
            try
            {
                if (id == 0)
                    Console.WriteLine("insert customer details");
                int ID;
                Console.Write("ID: ");
                int.TryParse(Console.ReadLine(), out ID);
                string customerName;
                Console.Write("customer Name: ");
                customerName = Console.ReadLine();
                string address;
                Console.Write("address: ");
                address = Console.ReadLine();
                string phone;
                Console.Write("phone: ");
                phone = Console.ReadLine();
                return customer = new Customer(ID, customerName, address, phone);
            }
            catch
            {
                Console.WriteLine("you insert uncorrect infomation");
                return customer = new Customer();
            }
        }
        private static Customer updateCustomer()
        {
            int id;
            Console.WriteLine("insert your updating details");
            Console.WriteLine("id: ");
            int.TryParse(Console.ReadLine(), out id);
            return insertCustomerDetailes(id);
        }
        private static Product insertProductDetailes(int id =0)
        {
            Product product;
            try
            {
                if (id == 0)
                    Console.WriteLine("insert product details");
                Console.Write("name: ");
                string productName = Console.ReadLine();
                Category category = chooseCategory();
                double price;
                Console.WriteLine("price: ");
                double.TryParse(Console.ReadLine(), out price);
                int quantityInStock;
                Console.WriteLine("insert product quantity In Stock");
                int.TryParse(Console.ReadLine(), out quantityInStock);
                return product = new Product(0, productName, category, price, quantityInStock);
            }
            catch
            {
                Console.WriteLine("you insert uncorrect infomation");
                return product = new Product();
            }
        }
        private static Product updateProduct()
        {
            int id;
            Console.WriteLine("insert your updating details");
            Console.WriteLine("id: ");
            int.TryParse(Console.ReadLine(), out id);
            return insertProductDetailes(id);
        }
        private static void delete<T>(ICrud<T> crud)
        {
            int id;
            Console.WriteLine("insert id for delete");
            int.TryParse(Console.ReadLine(), out id);
            crud.Delete(id);
        }
    }
}
