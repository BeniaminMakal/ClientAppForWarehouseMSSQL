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
    public partial class New_Customer : Form
    {
        string Cus_name, C_NIP, C_City, C_Address, C_Postal_code, C_Tel, C_Email, C_WWW, C_Cus_type;
        public New_Customer()
        {
            InitializeComponent();
        }

        private void Customer_name_TextChanged(object sender, EventArgs e)
        {
            Cus_name = Customer_name.Text;
        }

        private void Customer_NIP_TextChanged(object sender, EventArgs e)
        {
            C_NIP = Customer_name.Text;
        }

        private void Cus_City_TextChanged(object sender, EventArgs e)
        {
            C_City = Cus_City.Text;
        }

        private void New_Customer_Load(object sender, EventArgs e)
        {

        }

        private void Cus_Address_TextChanged(object sender, EventArgs e)
        {
            C_Address = Cus_Address.Text;
        }

        private void Cus_Tel_TextChanged(object sender, EventArgs e)
        {
            C_Tel = Cus_Tel.Text;
        }

        private void Cus_Email_TextChanged(object sender, EventArgs e)
        {
            C_Email = Cus_Email.Text;
        }

        private void Cus_WWW_TextChanged(object sender, EventArgs e)
        {
            C_WWW = Cus_WWW.Text;
        }

        private void Cus_Postal_Code_TextChanged(object sender, EventArgs e)
        {
            C_Postal_code = Cus_Postal_Code.Text;
        }

        private void Detal_CheckedChanged(object sender, EventArgs e)
        {
            if (Detal.Checked)
            {
                C_Cus_type = "DETAL";
            }
        }

        private void Hurt_CheckedChanged(object sender, EventArgs e)
        {
            if (Hurt.Checked)
            {
                C_Cus_type = "HURT";
            }
        }

        private void VIP_CheckedChanged(object sender, EventArgs e)
        {
            if (VIP.Checked)
            {
                C_Cus_type = "VIP";
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            newCon Add_Cus = new newCon(Logon.Log, Logon.Password);
            Add_Cus.Add_Cust(Cus_name, C_NIP, C_City, C_Address, C_Postal_code, C_Tel, C_Email, C_WWW, C_Cus_type);
            this.Close();
        }
    }
}
