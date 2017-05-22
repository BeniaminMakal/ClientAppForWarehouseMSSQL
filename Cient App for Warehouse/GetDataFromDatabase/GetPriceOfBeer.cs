using System;
using System.CodeDom;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cient_App_for_Warehouse.GetDataFromDatabase
{
    public interface IGetterPriceOfBeer
    {
        int GetPriceOfBeer(string productName, User user);
    }

    public class GetterPriceOfBeer : IGetterPriceOfBeer
    {
        private readonly IDatabaseConnection _databaseConnection;
        public event EventHandler<EventArgs> PriceOfBeerDelivered;

        public GetterPriceOfBeer(IDatabaseConnection DatabaseConnection)
        {
            _databaseConnection = DatabaseConnection;
        }

        public int GetPriceOfBeer(string productName, User user)
        {
            int price = 0;
            SqlDataReader reader = null;
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
            }
            catch (System.Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return price;

        }
    }
}