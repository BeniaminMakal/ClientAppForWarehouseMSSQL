using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cient_App_for_Warehouse.GetDataFromDatabase
{
    public class test
    {
        
    }
    //class GetPriveOfBeer
    //{
    //    public int GetPrice(ref string Product_Name)
    //    {
    //        SqlDataReader reader = null;
    //        try
    //        {
    //            SqlCommand command = new SqlCommand();
    //            command.CommandType = CommandType.Text;
    //            command.CommandText = "SELECT Price FROM Products WHERE Product_name = @name";
    //            command.Parameters.AddWithValue("@name", Product_Name);
    //            command.Connection = this.polaczenie2;
    //            reader = command.ExecuteReader();

    //            while (reader.Read())
    //            {
    //                Price = Convert.ToInt32((String.Format("{0}", reader["Price"])));

    //            }

    //        }

    //        finally
    //        {
    //            if (reader != null)
    //            {
    //                reader.Close();
    //            }

    //            if (polaczenie2 != null)
    //            {
    //                polaczenie2.Close();
    //            }
    //        }
    //        return Price;
    //    }
    //}
}
