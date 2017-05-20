using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Cient_App_for_Warehouse
{

    
   

    /// <summary>
    /// Klasa służy do łączenia się z bazą oraz wykonywania na niej wszystkich czynności: SELECY, UPDATE, INSERT, DELETE
    /// </summary>
    class newCon
    {
        #region "Definiowanie zmiennych"
        int Price = 0;
        int ID = 0, Invoice_ID = 0, Discount = 0, Sale_ID = 0, Employee_ID = 0, Amount = 0;
        string unit_of_measurement, NIP = "0", P_type = "0", P_brewery = "0", P_name = "0";
        public string beer_name { get; set; }
        private SqlConnection polaczenie2;
        SqlCommand com = new SqlCommand();
        #endregion
        public newCon(string login, string password)
        {
            polaczenie2 = new SqlConnection();
            polaczenie2.ConnectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog= Warehouse; User Id=" + login + "; Password = " + password + ";";

            com = new SqlCommand();
            com.Connection = polaczenie2;
            com.CommandType = CommandType.Text;
            polaczenie2.Open();
        }
        #region "Metoda wprowadzająca dane"
        public int wprowadz_dane(string a)
        {
            try
            {
                int result = 0;
                com = new SqlCommand(a);
                com.Connection = this.polaczenie2;
                result = com.ExecuteNonQuery();
                return result;
            }
            finally
            {
                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }
        }
        #endregion
        #region "Metoda pobierająca dane do DataTable. Wykorzystywana tylko dla gridview1"
        public DataTable pobierz_dane(string q)
        {
            SqlDataReader reader = null;
            try
            {
                DataTable dt = new DataTable();

                com = new SqlCommand(q);
                com.Connection = this.polaczenie2;
                reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }
        }
        #endregion
        /// <summary>
        /// Aktualizuje ilość określonego towaru w magazynie.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="P_name"></param>
        /// <returns>Zwraca liczbę zaktualizowanych wierszy.</returns>
#region "Amount_Update"
        public int Amount_Update(int amount, string P_name)
        {
            try
            {
                int result = 0;
                com = new SqlCommand("UPDATE Products SET Amount = @amount WHERE Product_name = @P_name;");
                com.Parameters.AddWithValue("@amount", amount);
                com.Parameters.AddWithValue("@P_name", P_name);
                com.Connection = this.polaczenie2;
                result = com.ExecuteNonQuery();
                return result;
            }
            finally
            {

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }

        }
        #endregion
        /// <summary>
        /// Wprowadza do bazy nowego klienta.
        /// </summary>
        /// 
        /// 
        /// <param name="Cus_name"></param>
        /// <param name="C_NIP"></param>
        /// <param name="C_City"></param>
        /// <param name="C_Address"></param>
        /// <param name="C_Postal_code"></param>
        /// <param name="C_Tel"></param>
        /// <param name="C_Email"></param>
        /// <param name="C_WWW"></param>
        /// <param name="C_Cus_type"></param>
        /// <returns>Zwraca liczbę zaktualizowanych wierszy.</returns>
#region "Add Customer"
        public int Add_Cust(string Cus_name, string C_NIP, string C_City, string C_Address, string C_Postal_code, string C_Tel, string C_Email, string C_WWW, string C_Cus_type)
        {
            try
            {
                int result = 0;
                com = new SqlCommand("INSERT INTO Customers (Customer_name, NIP, City, C_Address, Postal_code, Telephone, Email, WWW, Cus_Type) VALUES (@Customer_name, @NIP, @City, @C_Address, @Postal_code, @Telephone, @Email, @WWW, @Cus_Type)");
                com.Parameters.AddWithValue("@Customer_name", Cus_name);
                com.Parameters.AddWithValue("@NIP", C_NIP);
                com.Parameters.AddWithValue("@City", C_City);
                com.Parameters.AddWithValue("@C_Address", C_Address);
                com.Parameters.AddWithValue("@Postal_code", C_Postal_code);
                com.Parameters.AddWithValue("@Telephone", C_Tel);
                com.Parameters.AddWithValue("@Email", C_Email);
                com.Parameters.AddWithValue("@WWW", C_WWW);
                com.Parameters.AddWithValue("@Cus_Type", C_Cus_type);
                com.Connection = this.polaczenie2;
                result = com.ExecuteNonQuery();
                return result;
            }
            finally
            {

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }

        }
        #endregion
        /// <summary>
        /// Wprowadza nowy browar do bazy danych.
        /// </summary>
        /// <param name="B_name"></param>
        /// <param name="B_location"></param>
        /// <param name="B_address"></param>
        /// <param name="B_postal_code"></param>
        /// <param name="B_Telephone"></param>
        /// <param name="B_Email"></param>
        /// <param name="B_WWW"></param>
        /// <returns>Zwraca liczbę zaktualizowanych wierszy.</returns>
        public int Add_Brew(string B_name, string B_location, string B_address, string B_postal_code, string B_Telephone, string B_Email, string B_WWW)
        {
            try
            {
                int result = 0;
                com = new SqlCommand("INSERT INTO Breweries (Br_name, Br_Location, Adress, Postal_code, Telephone, Email, WWW) VALUES (@Br_name, @Br_Location, @Adress, @Postal_code, @Telephone, @Email, @WWW)");
                com.Parameters.AddWithValue("@Br_name", B_name);
                com.Parameters.AddWithValue("@Br_Location", B_location);
                com.Parameters.AddWithValue("@Adress", B_address);
                com.Parameters.AddWithValue("@Postal_code", B_postal_code);
                com.Parameters.AddWithValue("@Telephone", B_Telephone);
                com.Parameters.AddWithValue("@Email", B_Email);
                com.Parameters.AddWithValue("@WWW", B_WWW);
                com.Connection = this.polaczenie2;
                result = com.ExecuteNonQuery();
                return result;
            }
            finally
            {

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }

        }
        public int Add_Distrib(string d_name, string d_location, string d_address, string d_postal_code, string d_tel, string d_email, string d_www)
        {
            try
            {
                int result = 0;
                com = new SqlCommand("INSERT INTO Distributors (Dis_name, Dis_Location, Adress, Postal_code, Telephone, Email, WWW) VALUES (@Dis_name, @Dis_Location, @Adress, @Postal_code, @Telephone, @Email, @WWW)");
                com.Parameters.AddWithValue("@Dis_name", d_name);
                com.Parameters.AddWithValue("@Dis_Location", d_location);
                com.Parameters.AddWithValue("@Adress", d_address);
                com.Parameters.AddWithValue("@Postal_code", d_postal_code);
                com.Parameters.AddWithValue("@Telephone", d_tel);
                com.Parameters.AddWithValue("@Email", d_email);
                com.Parameters.AddWithValue("@WWW", d_www);
                com.Connection = this.polaczenie2;
                result = com.ExecuteNonQuery();
                return result;
            }
            finally
            {

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }

        }
        public int Add_Employee(string E_name, string E_surname, string E_login, string E_position, string E_pass)
        {
            try
            {
                int result = 0;
                com = new SqlCommand("IF NOT EXISTS (SELECT name FROM sys.sql_logins WHERE name = @Em_login) BEGIN CREATE LOGIN @Em_login WITH PASSWORD = @Password END CREATE USER @Em_login FOR LOGIN @Em_login GO INSERT INTO Employees (Em_login, Position, Em_name, Surname) VALUES (@Em_login, @Position, @Em_name, @Surname) GO");
                com.Parameters.AddWithValue("@Em_login", E_login);
                com.Parameters.AddWithValue("@Posiotion", E_position);
                com.Parameters.AddWithValue("@Em_name", E_name);
                com.Parameters.AddWithValue("@Surname", E_surname);
                com.Parameters.AddWithValue("@Password", E_pass);
                com.Connection = this.polaczenie2;
                result = com.ExecuteNonQuery();
                return result;
            }
            finally
            {

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }

        }
        public int Add_P_type(string P_type)
        {
            try
            {
                int result = 0;
                com = new SqlCommand("INSERT INTO Products_Types (P_Type_Name) VALUES (@P_type)");
                com.Parameters.AddWithValue("@P_type", P_type);
                com.Connection = this.polaczenie2;
                result = com.ExecuteNonQuery();
                return result;
            }
            finally
            {

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }

        }
        public int INTO_SALE(int Employee_ID, string Cus_name, int Invoice_ID)
        {
            try
            {
                int result = 0;
                com = new SqlCommand("INSERT INTO Sale (Employee_ID, Customer_name, Invoice_ID) VALUES (@Employee_ID, @Customer_name, @Invoice_ID)");
                com.Parameters.AddWithValue("@Invoice_ID", Invoice_ID);
                com.Parameters.AddWithValue("@Employee_ID", Employee_ID);
                com.Parameters.AddWithValue("@Customer_name", Cus_name);
                com.Connection = this.polaczenie2;
                result = com.ExecuteNonQuery();
                return result;
            }
            finally
            {

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }

        }
        public int INTO_INV_HEAD(int Cus_ID, double sum, string payment, double Discount)
        {
            try
            {
                int result = 0;
                com = new SqlCommand("INSERT INTO Invoice_headers(Customer_ID, Invoice_value, Payment, Discount) VALUES  (@Cus_ID, @sum, @payment, @Discount)");
                com.Parameters.AddWithValue("@Cus_ID", Cus_ID);
                com.Parameters.AddWithValue("@sum", sum);
                com.Parameters.AddWithValue("@payment", payment);
                com.Parameters.AddWithValue("@Discount", Discount);
                com.Connection = this.polaczenie2;
                result = com.ExecuteNonQuery();
                return result;
            }
            finally
            {

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }
            
        }

        public int INTO_INV_ITEMS(string Product_name, int Invoice_ID, int Amount, string unit_of_measurement, int Unit_price, long bar_code)
        {
            try
            {
                int result = 0;
                com = new SqlCommand("INSERT INTO Invoice_items(Product_name, Invoice_ID, Amount, Unit_of_measurement, Unit_price, Bar_code) VALUES (@Product_name, @Invoice_ID, @Amount, @Unit_of_measurement, @Unit_price, @Bar_code)");
                com.Parameters.AddWithValue("@Product_name", Product_name);
                com.Parameters.AddWithValue("@Invoice_ID", Invoice_ID);
                com.Parameters.AddWithValue("@Amount", Amount);
                com.Parameters.AddWithValue("@Unit_of_measurement", unit_of_measurement);
                com.Parameters.AddWithValue("@Unit_price", Unit_price);
                com.Parameters.AddWithValue("@Bar_code", bar_code);
                com.Connection = this.polaczenie2;
                result = com.ExecuteNonQuery();
                return result;
            }
            finally
            {

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }

        }
        public int INTO_PRODUCTS(int Product_price, int Product_amount, string P_name, string P_brewery, string P_distributor, string P_price, string P_type, string P_unit_of_measurement, long bar_code)
        {
            try
            {
                int result = 0;
                com = new SqlCommand("INSERT INTO Products(Product_name, Brewery, Distributor, Price, P_type, Amount, Unit_of_measurement, Bar_code) VALUES (@Product_name, @Brewery, @Distributor, @Price, @P_type, @Amount, @Unit_of_measurement, @Bar_code)");
                com.Parameters.AddWithValue("@Product_name", P_name);
                com.Parameters.AddWithValue("@Brewery", P_brewery);
                com.Parameters.AddWithValue("@Distributor", P_distributor);
                com.Parameters.AddWithValue("@Price", Product_price);
                com.Parameters.AddWithValue("@P_type", P_type);
                com.Parameters.AddWithValue("@Amount", Product_amount);
                com.Parameters.AddWithValue("@Unit_of_measurement", P_unit_of_measurement);
                com.Parameters.AddWithValue("@Bar_code", bar_code);
                com.Connection = this.polaczenie2;
                result = com.ExecuteNonQuery();
                return result;
            }
            finally
            {

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }

        }
        public int INTO_EXP_DATE(string P_name, string serial_number, string expiration_date)
        {
            try
            {
                int result = 0;
                com = new SqlCommand("INSERT INTO Expiration_dates(Product_name, Serial_number, Expiration_date) VALUES  (@Product_name, @Serial_number, @Expiration_date)");
                com.Parameters.AddWithValue("@Product_name", P_name);
                com.Parameters.AddWithValue("@Serial_number", serial_number);
                com.Parameters.AddWithValue("@Expiration_date", expiration_date);
                com.Connection = this.polaczenie2;
                result = com.ExecuteNonQuery();
                return result;
            }
            finally
            {

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }

        }
        public string Chceck_P_type(ref string Prod_type)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT P_Type_Name FROM Products_Types WHERE P_Type_Name = @name";
                command.Parameters.AddWithValue("@name", Prod_type);
                command.Connection = this.polaczenie2;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    P_type = (String.Format("{0}", reader["P_Type_Name"]));

                }

            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }
            return P_type;
        }
        public string Chceck_P_name(ref long bar_code)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Product_name FROM Products WHERE Bar_code = @Bar_code";
                command.Parameters.AddWithValue("@Bar_code", bar_code);
                command.Connection = this.polaczenie2;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    P_name = (String.Format("{0}", reader["Product_name"]));

                }

            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }
            return P_name;
        }
        public string Chceck_Brewery(ref string Brewery)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Br_name FROM Breweries WHERE Br_name = @name";
                command.Parameters.AddWithValue("@name", Brewery);
                command.Connection = this.polaczenie2;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    P_brewery = (String.Format("{0}", reader["Br_name"]));

                }

            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }
            return P_brewery;
        }
        public int GetPrice(ref string Product_Name)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Price FROM Products WHERE Product_name = @name";
                command.Parameters.AddWithValue("@name", Product_Name);
                command.Connection = this.polaczenie2;
                reader = command.ExecuteReader();
                
                    while (reader.Read())
                {
                    Price = Convert.ToInt32((String.Format("{0}", reader["Price"])));

                }
                
            }
            
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }
            return Price;
        }
        public int GetID (ref string Cus_name)
        {
            try
            {
                com.CommandText = "SELECT Customer_ID FROM Customers WHERE Customer_name = @name2";
                com.Parameters.AddWithValue("@name2", Cus_name);
                com.Connection = this.polaczenie2;
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    ID = Convert.ToInt32((String.Format("{0}", reader["Customer_ID"])));

                }

            }

            finally
            {

            }
            return ID;

        }

        public int Get_Invoice_ID()
        {
            try
            {
                com.CommandText = "SELECT MAX(Invoice_ID) AS Invoice_ID FROM Invoice_headers";
                com.Connection = this.polaczenie2;
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Invoice_ID = Convert.ToInt32(String.Format("{0}", reader["Invoice_ID"]));

                }

            }

            finally
            {

            }
            return Invoice_ID;
        }
        public int Get_Discount(ref string Cus_name)
        {
            try
            {
                com.CommandText = "SELECT Discount FROM Cus_Types AS C JOIN Customers AS Cus ON C.Cus_Type = Cus.Cus_Type WHERE Customer_name = @Cus_name; ";
                com.Parameters.AddWithValue("@Cus_name", Cus_name);
                com.Connection = this.polaczenie2;
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Discount = Convert.ToInt32((String.Format("{0}", reader["Discount"])));

                }

            }

            finally
            {

            }
            return Discount;
        }
        public int Get_Sale_ID()
        {
            try
            {
                com.CommandText = "SELECT MAX(Sale_ID) AS Sale_ID FROM Sale";
                com.Connection = this.polaczenie2;
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Sale_ID = Convert.ToInt32((String.Format("{0}", reader["Sale_ID"])));

                }

            }

            finally
            {

            }
            return Sale_ID;
        }
        public int Get_Employee_ID(ref string Em_Login)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Employee_ID FROM Employees WHERE Em_LOGIN = @login";
                command.Parameters.AddWithValue("@login", Em_Login);
                command.Connection = this.polaczenie2;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee_ID = Convert.ToInt32((String.Format("{0}", reader["Employee_ID"])));

                }

            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }
            return Employee_ID;
        }
        public string Get_unit_of_measurement(ref string Product_Name)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Unit_of_measurement FROM Products WHERE Product_name = @name";
                command.Parameters.AddWithValue("@name", Product_Name);
                command.Connection = this.polaczenie2;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    unit_of_measurement = (String.Format("{0}", reader["Unit_of_measurement"]));

                }

            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }
            return unit_of_measurement;
        }
        public int Check_Amount(ref string Product_Name)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Amount FROM Products WHERE Product_name = @name";
                command.Parameters.AddWithValue("@name", Product_Name);
                command.Connection = this.polaczenie2;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Amount = Convert.ToInt32((String.Format("{0}", reader["Amount"])));

                }

            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }
            return Amount;
        }
        public string Check_NIP(ref string Cus_name)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT NIP FROM Customers WHERE Customer_name = @Cus_name;";
                command.Parameters.AddWithValue("@Cus_name", Cus_name);
                command.Connection = this.polaczenie2;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    NIP = (String.Format("{0}", reader["NIP"]));

                }

            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }
            return NIP;
        }
        public string Check_Product_Name(ref string Product_name)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Product_name FROM Products WHERE Product_name = @P_name;";
                command.Parameters.AddWithValue("@P_name", Product_name);
                command.Connection = this.polaczenie2;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    P_name = (String.Format("{0}", reader["Product_name"]));

                }

            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (polaczenie2 != null)
                {
                    polaczenie2.Close();
                }
            }
            return P_name;
        }
    }
    
    public class Beer
    {
        
        public string beer_name { get; set; }
        private SqlConnection polaczenie3;
        SqlCommand com;
        public Beer(string login, string password)
        {
            polaczenie3 = new SqlConnection();
            polaczenie3.ConnectionString = "Data Source= (local); Initial Catalog= Warehouse; User Id=" + login + "; Password = " + password + ";";
            com = new SqlCommand();
            com.Connection = polaczenie3;
            com.CommandType = CommandType.Text;

            polaczenie3.Open();
        }
        
    }
    
    class WinAuth{
            private SqlConnection polaczenie2;
        public WinAuth(string mySource, string myCatalog)
        {
            polaczenie2 = new SqlConnection();
            polaczenie2.ConnectionString = "Server=mySource;Database=myCatalog;Trusted_Connection = True";
            polaczenie2.Open();
        }
        public DataTable pobierz_dane(string q)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;
            SqlCommand com;
            com = new SqlCommand(q);

            com.Connection = this.polaczenie2;
            dr = com.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
    }

   
    }
    


