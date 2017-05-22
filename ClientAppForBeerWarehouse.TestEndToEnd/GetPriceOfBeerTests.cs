using Cient_App_for_Warehouse;
using Cient_App_for_Warehouse.GetDataFromDatabase;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientAppForBeerWarehouse.TestEndToEnd
{

    [TestFixture]
    public class GetPriceOfBeerTests
    {
        public User user;
        public IDatabaseConnection fakeDatabaseConnection;
        public GetterPriceOfBeer getterPriceOfBeer;
        public string productName = "Coin";
        public int amount;
        public int result;

        [SetUp]
        public void Setup()
        {
            user = new User("cashier1", "cashier1");
            fakeDatabaseConnection = new FakeDatabaseConnection();
            int amount = 5;
            
            getterPriceOfBeer = new GetterPriceOfBeer(fakeDatabaseConnection);
            
        }

        [Test]
        public void price_of_beer_coin_shoulf_be_11()
        {
            result =  getterPriceOfBeer.GetPriceOfBeer(productName, user);


            Assert.GreaterOrEqual(result, 11);
        }
       
    }
}
