using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cient_App_for_Warehouse
{
    public interface IUser
    {
        string FirstName { get; }
        string LastName { get; }
        string Position { get; }
        string Login { get; }
        string Password { get; }

        void SetFirstName(string firstName);
        void SetLastName(string lastName);
        void SetPosition(string position);
        void SetLogin(string login);
        void SetPassword(string password);
    }

    public interface IDatabaseConnection
    {
        bool IsConnected { get; }
        SqlConnection connection { get; }
        void OpenNewConnection(User user);

    }

    public interface IAmountUpdator
    {
        int AmountUpdator(int amount, string productName);
    }

}
