using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cient_App_for_Warehouse
{
    public interface IUser
    {
        Guid ID { get; }
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
}
