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
    public partial class Logon : Form
    {

        public static string Log, Password;
        public static Employee user; 

        public Logon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            Log = objTextBox.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox2 = (TextBox)sender;
            Password = objTextBox2.Text;
        }

        private void NewLogin_Click(object sender, EventArgs e)
        {
            string userName;

            

            try
            {
                user = new Employee(Log, Password);
                var databaseConnection = new DatabaseConnection();
                databaseConnection.OpenNewConnection(user);

                LoginWriter writer = new LoginWriter();

                writer.WriteToFile(user.Login);

                this.Hide();

                Form1 form1 = new Form1();
                form1.Visible = true;
                form1.TopMost = true;
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void Login_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new Employee(Log, Password);

                newCon baza = new newCon(Log, Password);
                this.Hide();


                Form1 form1 = new Form1();
                form1.Visible = true;
                form1.TopMost = true;
                form1.Closed += (s, args) => this.Close();
                form1.Show();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }


    }
}
