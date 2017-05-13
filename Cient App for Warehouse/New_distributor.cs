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
    public partial class New_distributor : Form
    {
        string d_name, d_location, d_address, d_postal_code, d_tel, d_email, d_www;
        public New_distributor()
        {
            InitializeComponent();
        }

        private void Dis_name_TextChanged(object sender, EventArgs e)
        {
            d_name = Dis_name.Text;
        }

        private void Dis_city_TextChanged(object sender, EventArgs e)
        {
            d_location = Dis_city.Text;
        }

        private void Dis_address_TextChanged(object sender, EventArgs e)
        {
            d_address = Dis_address.Text;
        }

        private void Dis_p_code_TextChanged(object sender, EventArgs e)
        {
            d_postal_code = Dis_p_code.Text;
        }

        private void Dis_tel_TextChanged(object sender, EventArgs e)
        {
            d_tel = Dis_tel.Text;
        }

        private void Dis_email_TextChanged(object sender, EventArgs e)
        {
            d_email = Dis_email.Text;
        }

        private void Dis_WWW_TextChanged(object sender, EventArgs e)
        {
            d_www = Dis_WWW.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newCon Add_Dis = new newCon(Logon.Log, Logon.Password);
            Add_Dis.Add_Distrib(d_name, d_location, d_address, d_postal_code, d_tel, d_email, d_www);
            this.Close();
        }
    }
}
