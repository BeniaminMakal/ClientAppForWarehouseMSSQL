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
    public partial class New_Brewery : Form
    {
        string B_name, B_location, B_address, B_postal_code, B_Telephone, B_Email, B_WWW;
        public New_Brewery()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            B_name = Name.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newCon Add_Brewery = new newCon(Logon.log, Logon.pas);
            Add_Brewery.Add_Brew(B_name, B_location, B_address, B_postal_code, B_Telephone, B_Email, B_WWW);
            this.Close();
        }

        private void Location_TextChanged(object sender, EventArgs e)
        {
            B_location = Location.Text;
        }

        private void Br_Address_TextChanged(object sender, EventArgs e)
        {
            B_address = Br_Address.Text;
        }

        private void P_code_TextChanged(object sender, EventArgs e)
        {
            B_postal_code = P_code.Text;
        }

        private void Tel_TextChanged(object sender, EventArgs e)
        {
            B_Telephone = Tel.Text;
        }

        private void Br_email_TextChanged(object sender, EventArgs e)
        {
            B_Email = Br_email.Text;
        }

        private void Br_WWW_TextChanged(object sender, EventArgs e)
        {
            B_WWW = Br_WWW.Text;
        }
    }
}
