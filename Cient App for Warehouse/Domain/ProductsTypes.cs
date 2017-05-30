using System;

namespace Cient_App_for_Warehouse
{
    public interface IProductsTypes
    {
        Guid ProductTypeID { get; }
        string ProductTypeName { get; }
    }

    public class ProductsTypes : IProductsTypes
    {
        public Guid ProductTypeID { get; private set; }
        public string ProductTypeName { get; private set; }
    }
}
