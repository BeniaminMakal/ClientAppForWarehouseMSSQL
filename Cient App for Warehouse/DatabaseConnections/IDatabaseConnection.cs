using System;
using System.Data.SqlClient;

namespace Cient_App_for_Warehouse
{
    public interface IDatabaseConnection
    {
        bool IsConnected { get; }
        SqlConnection Connection { get; }
        SqlConnection OpenNewConnection(User user);
        event EventHandler<DatabaseConnectionEventArgs> DatabaseConnected;
        void OnDatabaseConnected(User user);

    }
}