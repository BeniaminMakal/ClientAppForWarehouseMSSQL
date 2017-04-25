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
    public partial class New_employee : Form
    {
        string E_name, E_surname, E_login, E_position, E_pass;
        public New_employee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Em_name_TextChanged(object sender, EventArgs e)
        {
            E_name = Em_name.Text;
        }

        private void Em_surname_TextChanged(object sender, EventArgs e)
        {
            E_surname = Em_surname.Text;
        }

        private void Em_pass_TextChanged(object sender, EventArgs e)
        {
            E_pass = Em_pass.Text;
        }

        private void Em_login_TextChanged(object sender, EventArgs e)
        {
            E_login = Em_login.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                E_position = "cashier";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                E_position = "warehouseman";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
