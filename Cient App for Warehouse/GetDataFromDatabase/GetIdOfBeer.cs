using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cient_App_for_Warehouse.GetDataFromDatabase
{
    public interface IGetterIdOfBeer
    {
        int GetIdBeer();
    }
    public class GetterIdOdBeer : IGetterIdOfBeer
    {

        private readonly IDatabaseConnection _databaseConnection;


        public GetterIdOdBeer(IDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }
        public int GetIdBeer()
        {
            throw new NotImplementedException();
        }
    }
}
