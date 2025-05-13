
 
using DO;
namespace Dal;

public static class DataSource
{
    public static List<Product>? productsList = new List<Product>();
    public static List<Sale>? salesList = new List<Sale>();
    public static List<Customer>? customersList = new List<Customer>();
    internal static class Config
    {
        internal const int ProductMinID = 100;
        internal const int SaleMinID = 10;
        private static int ProductRunId = ProductMinID;
        private static int SaleRunId = SaleMinID;
        public static int GetProductRunID => ProductRunId += 50;
        public static int GetSaleRunId => SaleRunId += 10;



    }
}

