using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cient_App_for_Warehouse.Domain
{
    public interface IDataTable
    {
        Guid ID { get; }
    }

    public class DataTable : IDataTable
    {
        public Guid ID { get; private set; }
        IEnumerable<Product> Products;

        public DataTable()
        {
            ID = Guid.NewGuid();
        }
    }
}
