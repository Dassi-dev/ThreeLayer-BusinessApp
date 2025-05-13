using BO;
using BlApi;
namespace BlTest
{
    internal class Program
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

        static void Main(string[] args)
        {
            orderMenu();

        }

        private static void read<T>(ICrud<T> crud)
        {
            Console.WriteLine("insert id for read");
            int id = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(crud.Read(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        private static void readAll<T>(ICrud<T> crud)
        {
            foreach (var item in crud.ReadAll())
            {
                Console.WriteLine(item);
            }
        }
        private static void delete<T>(ICrud<T> crud)
        {
            Console.WriteLine("insert id for delete");
            int id = int.Parse(Console.ReadLine());
            try
            {
                crud.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        private static int printSubMenu(string item)
        {
            Console.WriteLine($"To add {item} press 1");
            Console.WriteLine($"To read {item} press 2");
            Console.WriteLine($"To read all {item}s press 3");
            Console.WriteLine($"To update {item} press 4");
            Console.WriteLine($"To delete {item} press 5");
            Console.WriteLine("To go back press 0");

            int select;
            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;

            return select;
        }

        private static Customer customerDetails()
        {
            Console.WriteLine("insert CustomerId");
            int customerId;
            if (!int.TryParse(Console.ReadLine(), out customerId))
                customerId = 0;
            Console.WriteLine("insert CustomerName");
            string customerName = Console.ReadLine();
            Console.WriteLine("insert Address");
            string address = Console.ReadLine();
            Console.WriteLine("insert Phone");
            string phone = Console.ReadLine();

            Customer customer = new Customer(customerId, customerName, address, phone);
            return customer;
        }

        private static void createCustomer()
        {
            Customer customer = customerDetails();
            s_bl.ICustomer.Create(customer);
        }

        private static void updateCustomer()
        {

            Customer customer = customerDetails();
            s_bl.ICustomer.Update(customer);
        }
        private static void orderMenu()
        {

            int select = printSubMenu("order");
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        createCustomer();
                        break;
                    case 2:
                        read<Customer>(s_bl.ICustomer);
                        break;
                    case 3:
                        readAll<Customer>(s_bl.ICustomer);
                        break;
                    case 4:
                        updateCustomer();
                        break;
                    case 5:
                        delete<Customer>(s_bl.ICustomer);
                        break;
                    default:
                        Console.WriteLine("Wrong selection, please select again");
                        break;
                }
                select = printSubMenu("customer");
            }

        }
    }
    }
