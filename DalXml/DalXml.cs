using DalApi;
using System.Diagnostics;

namespace Dal
{
    internal sealed class DalXml : IDal
    {
        private DalXml()
        {

        }
        public IProduct Product => new ProductImplementation();
        public ISale Sale => new SaleImplementation();
        public ICustomer Customer => new CustomerImplementation();
        public static DalXml Instance { get; } = new DalXml();

    }
}
