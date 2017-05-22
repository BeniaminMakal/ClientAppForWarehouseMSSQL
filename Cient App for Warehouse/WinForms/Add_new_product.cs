using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cient_App_for_Warehouse
{
    public partial class Add_new_product : Form
    {
        int Product_price, Product_amount;
        string P_name, P_brewery, P_distributor, P_Exp_date, P_price, P_type, P_unit_of_measurement, Check_P_type = "0", Check_brewery = "0", serial_number = "0";
        long P_bar_code;
        public Add_new_product()
        {
            InitializeComponent();
        }

        private void Prod_distributor_TextChanged(object sender, EventArgs e)
        {
            P_distributor = Prod_distributor.Text;
        }

        private void Bar_code_TextChanged(object sender, EventArgs e)
        {
            P_bar_code = long.Parse(Bar_code.Text);
        }

        private void Serial_number_TextChanged(object sender, EventArgs e)
        {
            serial_number = Serial_number.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                newCon Check_P_Brewery = new newCon(Logon.Log, Logon.Password);
                Check_brewery = Check_P_Brewery.Chceck_Brewery(ref P_brewery);

                if (Check_brewery == "0")
                {
                    MessageBox.Show("We don't have this brewery in our database. First of all, you have to add it to database.");
                    this.Close();
                }

                newCon Check_Product_type = new newCon(Logon.Log, Logon.Password);
                Check_P_type = Check_Product_type.Chceck_P_type(ref P_type);

                if (Check_P_type == "0")
                {
                    newCon Add_Product_type = new newCon(Logon.Log, Logon.Password);
                    Add_Product_type.Add_P_type(P_type);
                }
                
                newCon Add_product = new newCon(Logon.Log, Logon.Password);
                Add_product.INTO_PRODUCTS(Product_price, Product_amount, P_name, P_brewery, P_distributor, P_price, P_type, P_unit_of_measurement, P_bar_code);
                this.Close();

                newCon Add_exp_date = new newCon(Logon.Log, Logon.Password);
                Add_exp_date.INTO_EXP_DATE(P_name, serial_number, P_Exp_date);
            }
            catch
            {
                MessageBox.Show("You have to fill all the text boxes.");
            }
        }

        private void Prod_name_TextChanged(object sender, EventArgs e)
        {
            string check_p_name;
            P_name = Prod_name.Text;
            newCon Check_prod_name = new newCon(Logon.Log, Logon.Password);
            check_p_name = Check_prod_name.Check_Product_Name(ref P_name);
            if (P_name == check_p_name)
            {
                MessageBox.Show("This product is in database.");
            }
        }

        private void Prod_brewery_TextChanged(object sender, EventArgs e)
        {
            P_brewery = Prod_brewery.Text;
        }

        private void Prod_expiration_date_TextChanged(object sender, EventArgs e)
        {
            P_Exp_date = Prod_expiration_date.Text;
        }

        private void Prod_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Product_price = Convert.ToInt32(Prod_price.Text);
            }
            catch 
            {
                MessageBox.Show("Incorrect value");
            }
        }

        private void Prod_type_TextChanged(object sender, EventArgs e)
        {
            P_type = Prod_type.Text;
        }

        private void Prod_amount_TextChanged(object sender, EventArgs e)
        {
            Product_amount = Convert.ToInt32(Prod_amount.Text);
        }

        private void Prod_unit_of_measurement_TextChanged(object sender, EventArgs e)
        {
            P_unit_of_measurement = Prod_unit_of_measurement.Text;
        }
    }
}
