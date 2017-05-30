using System;
using System.Collections.Generic;

namespace Cient_App_for_Warehouse.Repositories
{
    public interface IProductRepository : IRepository
    {
        Product Get(string productName);

        Product Get(Guid productID);

        IEnumerable<Product> GetAll();

        void Add(Product product);

        void Update(Product product);

        void Remowe(Guid productID);

    }


}
