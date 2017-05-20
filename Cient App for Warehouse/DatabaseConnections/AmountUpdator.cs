using System.Data.SqlClient;

namespace Cient_App_for_Warehouse
{
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
                SqlCommand.Connection = _databaseconnection.Connection;
                return result;
            }
            finally
            {
                if (_databaseconnection.Connection != null)
                {
                    _databaseconnection.Connection.Close();
                }
            }
        }
    }
}