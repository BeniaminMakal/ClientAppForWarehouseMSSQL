﻿using System;

namespace Cient_App_for_Warehouse
{
    public class User : IUser
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Position { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public void SetFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public void SetLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        public void SetPosition(string position)
        {
            throw new NotImplementedException();
        }

        public void SetLogin(string login)
        {
            throw new NotImplementedException();
        }

        public void SetPassword(string password)
        {
            throw new NotImplementedException();
        }
    }
}