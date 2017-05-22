using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cient_App_for_Warehouse
{
    public class FakeDatabaseConnection : IDatabaseConnection
    {
        public bool IsConnected { get; private set; }

        public SqlConnection Connection { get; private set; }

        public event EventHandler<DatabaseConnectionEventArgs> DatabaseConnected;

        public void OnDatabaseConnected(User user)
        {
            if (DatabaseConnected != null)
                DatabaseConnected(this, new DatabaseConnectionEventArgs() { User = user });
        }

        public SqlConnection OpenNewConnection(User user)
        {
            Connection = new SqlConnection(@"Data Source = localhost\SQLEXPRESS;" +
                                                      " Initial Catalog = Warehouse.Tests; User Id = " + user.Login +
                                                      "; Password = " + user.Password + "; ");
            Connection.Open();
            IsConnected = true;
            return Connection;
        }
    }

    public class DatabaseConnection : IDatabaseConnection
    {
        public bool IsConnected { get; private set; }

        public SqlConnection Connection { get; private set; }

        public event EventHandler<DatabaseConnectionEventArgs> DatabaseConnected;


        public SqlConnection OpenNewConnection(User user)
        {
            Connection = new SqlConnection(@"Data Source = localhost\SQLEXPRESS;" +
                                          " Initial Catalog = Warehouse; User Id = " + user.Login +
                                          "; Password = " + user.Password + "; ");
            Connection.Open();
            IsConnected = true;
            return Connection;
        }


        public void OnDatabaseConnected(User user)
        {
            if (DatabaseConnected != null)
                DatabaseConnected(this, new DatabaseConnectionEventArgs() { User = user });
        }
    }
}
