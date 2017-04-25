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
    public partial class Delivery : Form
    {
        string p_name, Serial_num, Expiration_date;
        int p_amount, check_p_amount;

        public Delivery()
        {
            InitializeComponent();
        }

        private void Product_name_TextChanged(object sender, EventArgs e)
        {
            
            p_name = Product_name.Text;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string check_product_name;
            newCon Check_p_name = new newCon(Logon.log, Logon.pas);
            check_product_name = Check_p_name.Check_Product_Name(ref p_name);
            if (p_name == check_product_name)
            {
                int final_amount;
                newCon Check_amount = new newCon(Logon.log, Logon.pas);
                check_p_amount = Check_amount.Check_Amount(ref p_name);
                final_amount = check_p_amount + p_amount;

                newCon Update_amount = new newCon(Logon.log, Logon.pas);
                Update_amount.Amount_Update(final_amount, p_name);

                try
                {
                    newCon Add_expiration_date = new newCon(Logon.log, Logon.pas);
                    Add_expiration_date.INTO_EXP_DATE(p_name, Serial_num, Expiration_date);
                }
                catch
                {
                    MessageBox.Show("Error data format.");
                }
            }
            else
            {
                MessageBox.Show("Add this product to database.");
            }
            MessageBox.Show("Delivery Success");
        }

        private void Product_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                p_amount = Convert.ToInt32(P_amount.Text);
            }
            catch
            {
                MessageBox.Show("Enter only numbers.");
            }
        }

        private void Serial_number_TextChanged(object sender, EventArgs e)
        {
            Serial_num = Serial_number.Text;
        }

        private void P_exp_date_TextChanged(object sender, EventArgs e)
        {
            Expiration_date = P_exp_date.Text;
        }
    }
}
