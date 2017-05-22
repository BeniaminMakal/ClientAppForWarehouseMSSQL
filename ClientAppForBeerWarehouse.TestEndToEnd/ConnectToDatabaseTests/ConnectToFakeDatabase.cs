using Cient_App_for_Warehouse;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientAppForBeerWarehouse.TestEndToEnd
{
    class ConnectToFakeDatabase
    {
        public User user;
        public IDatabaseConnection fakeDatabaseConnection;

        [SetUp]
        public void Setup()
        {
            user = new User("cashier1", "cashier1");
            fakeDatabaseConnection = new FakeDatabaseConnection();
            int amount = 5;
            string productName = "Coin";
        }

        [Test]
        public void test_connection_to_database_prop_IsConnected_should_be_true()
        {
            fakeDatabaseConnection.OpenNewConnection(user);

            Assert.IsTrue(fakeDatabaseConnection.IsConnected);
        }
    }
}
