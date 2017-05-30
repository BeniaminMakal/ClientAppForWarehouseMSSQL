using System;
using System.CodeDom;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cient_App_for_Warehouse.GetDataFromDatabase
{
    public class GetDataFromDatabaseEventArgs : EventArgs
    {
        public LogInformation LogInformation { get; set; }
    }

    public class LogInformation
    {
        public string ProductName { get; set; }
        public string UserName { get; set; }

        public LogInformation(string productName, string userName)
        {
            ProductName = productName;
            UserName = userName;
        }
    }

    public interface IGetterPriceOfBeer
    {
        int GetPriceOfBeer(string productName, Employee user);
    }

    public class GetterPriceOfBeer : IGetterPriceOfBeer
    {
        private readonly IDatabaseConnection _databaseConnection;
        public event EventHandler<EventArgs> PriceOfBeerDelivered;

        public GetterPriceOfBeer(IDatabaseConnection DatabaseConnection)
        {
            _databaseConnection = DatabaseConnection;
        }

        public int GetPriceOfBeer(string productName, Employee user)
        {
            int price = 0;
            SqlDataReader reader = null;
            LogInformation logInformation = new LogInformation(productName, user.FirstName);
            try
            {
                var sqlCommand = new SqlCommand("SELECT Price FROM Products WHERE Product_name = @productName;");
                sqlCommand.Parameters.AddWithValue("@productName", productName);
                sqlCommand.Connection = _databaseConnection.OpenNewConnection(user);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    price = Convert.ToInt32(String.Format("{0}", reader["Price"]));
                }
                OnGotPriceOfBeer(logInformation);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return price;
        }

        protected virtual void OnGotPriceOfBeer(LogInformation logInformation)
        {
            if (PriceOfBeerDelivered != null)
                PriceOfBeerDelivered(this, new GetDataFromDatabaseEventArgs() { LogInformation = logInformation });
        }
    }
}