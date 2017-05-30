using System;

namespace Cient_App_for_Warehouse
{
    public interface ICustomerTypes
    {
        string CustomerType { get; }
        int Discount { get; }
    }
    public class CustomerTypes : ICustomerTypes
    {
        public string CustomerType { get; set; }

        public int Discount { get; set; }
    }
}
