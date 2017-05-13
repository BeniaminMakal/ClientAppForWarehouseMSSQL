using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cient_App_for_Warehouse
{
    class DatabaseConnection : IDatabaseConnection
    {
        public bool IsConnected { get; private set; }
        public SqlConnection connection { get; private set; }
        public void OpenNewConnection(User user)
        {
            connection.ConnectionString = "Data Source = (local);" +
                                          " Initial Catalog = Warehouse; User Id = " + user.Login +
                                          "; Password = " + user.Password + "; ";
            connection.Open();
            IsConnected = true;
        }

       
    }

    public class AmountUpdator : IAmountUpdator
    {
        private readonly IDatabaseConnection _databaseconnection;

        public AmountUpdator(IDatabaseConnection DatabaseConnection)
        {
            _databaseconnection = DatabaseConnection;
        }

        int IAmountUpdator.AmountUpdator(int amount, string productName)
        {
            try
            {
                int result = 0;
                var SqlCommand = new SqlCommand("UPDATE Products SET Amount = @amount WHERE Product_name = @P_name;");
                SqlCommand.Parameters.AddWithValue("@amount", amount);
                SqlCommand.Parameters.AddWithValue("@P_name", productName);
                SqlCommand.Connection = _databaseconnection.connection;
                return result;
            }
            finally
            {
                if (_databaseconnection.connection != null)
                {
                    _databaseconnection.connection.Close();
                }
            }
        }
    }



}
