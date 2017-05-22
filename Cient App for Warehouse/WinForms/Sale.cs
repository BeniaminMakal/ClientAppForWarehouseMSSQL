using Cient_App_for_Warehouse.GetDataFromDatabase;
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
    
    public partial class Sale : Form
    {
        public static string Cus_name;
        public static int Invoice_ID;
        public static int Final_Invoice_Value;
        public static string P_name;
        public static string P_amount;
        int sum = 0, amount_sum = 0, ID = 0, Sale_ID = 0, Employee_ID = 0, Unit_price = 0, P_price = 0, residual = 0, Amount_base = 0, check_amount = 0;
        long P_bar_code;
        double sum_with_discount = 0, Discount = 0;

        public static int x = 1;
        public static string Cus_NIP;
        string payment, unit_of_measurement, NIP = "0", serial_number = "0", exp_date = "0";



        public Sale()
        {
            InitializeComponent();
        }

        public void Sale_Load(object sender, EventArgs e)
        {
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Products_Click(object sender, EventArgs e)
        {
            
            newCon Check_amount = new newCon(Logon.Log, Logon.Password);
            check_amount = Check_amount.Check_Amount(ref P_name);
            int P_amount_test = Convert.ToInt32(P_amount);
            if(P_amount_test <= check_amount)
            {

                ListViewItem itm;

                IDatabaseConnection _databaseConnection = new DatabaseConnection();
                _databaseConnection.OpenNewConnection(user);
                GetterPriceOfBeer getterPriceOfBeer = new GetterPriceOfBeer()

                int price = 0;
                newCon a = new newCon(Logon.Log, Logon.Password);
                price = a.GetPrice(ref P_name);
                
                string[] arr = new string[7];


                if (price != 0)
                {
                    if (serial_number != "0")
                    {
                        if (exp_date != "0")
                        {
                            newCon Check_Unit_of_measurement = new newCon(Logon.Log, Logon.Password);
                            unit_of_measurement = Check_Unit_of_measurement.Get_unit_of_measurement(ref P_name);
                            arr[0] = Convert.ToString(x);
                            arr[1] = P_name;
                            arr[2] = P_amount;
                            arr[3] = Convert.ToString(price);
                            arr[4] = unit_of_measurement;
                            arr[5] = serial_number;
                            arr[6] = exp_date;
                            arr[7] = Convert.ToString(P_bar_code);
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                            x++;
                        }
                        else
                        {
                            MessageBox.Show("Enter a expiration date.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a serial number.");
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect name of beer");
                }



                try
                {
                    string Product_Name = P_name;

                    newCon b = new newCon(Logon.Log, Logon.Password);

                    Unit_price = b.GetPrice(ref Product_Name);
                    sum += Unit_price * int.Parse(Amount.Text);
                    amount_sum += int.Parse(Amount.Text);
                }
                catch
                {
                    MessageBox.Show("Incorrect name of beer");
                }



                Quantity_TextBox.Text = Convert.ToString(amount_sum);
                Invoice_value.Text = Convert.ToString(sum);
            }
            else
            {
                MessageBox.Show("Too much bottles.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.AutoSize = true;
        }

        private void End_Sale_Click(object sender, EventArgs e)
        {
            
            int Cus_ID, Invoice_ID;
            newCon Check_Cus_ID = new newCon(Logon.Log, Logon.Password);
            Cus_ID = Check_Cus_ID.GetID(ref Cus_name);

            newCon Check_Invoice_ID = new newCon(Logon.Log, Logon.Password);
            Invoice_ID = Check_Invoice_ID.Get_Invoice_ID();
            Invoice_ID += 1;

            newCon Check_Discount = new newCon(Logon.Log, Logon.Password);
            Discount = Check_Discount.Get_Discount(ref Cus_name);

            newCon Check_Employee_ID = new newCon(Logon.Log, Logon.Password);

            Employee_ID = Check_Employee_ID.Get_Employee_ID(ref Logon.Log);
          
            sum_with_discount = sum - (sum * (Discount / 100));

            newCon Add2 = new newCon(Logon.Log, Logon.Password);
            Add2.INTO_INV_HEAD(Cus_ID, sum_with_discount, payment, Discount);

            newCon Add1 = new newCon(Logon.Log, Logon.Password);
            Add1.INTO_SALE(Employee_ID, Cus_name, Invoice_ID);

            foreach (ListViewItem lvi in listView1.Items)
            {
                P_name = lvi.SubItems[1].Text;
                P_amount = lvi.SubItems[2].Text;
                P_price = Convert.ToInt32(lvi.SubItems[3].Text);
                unit_of_measurement = lvi.SubItems[4].Text;
                serial_number = lvi.SubItems[5].Text;
                exp_date = lvi.SubItems[6].Text;

                newCon Add3 = new newCon(Logon.Log, Logon.Password);
                Add3.INTO_INV_ITEMS(P_name, Invoice_ID, Convert.ToInt32(P_amount), unit_of_measurement, P_price, P_bar_code);

                newCon GetAmount = new newCon(Logon.Log, Logon.Password);
                Amount_base = GetAmount.Check_Amount(ref P_name);

                residual = Amount_base - Convert.ToInt32(P_amount);

                newCon Update1 = new newCon(Logon.Log, Logon.Password);
                Update1.Amount_Update(residual, P_name);



            }

            this.Close();
   
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Bar_code_TextChanged(object sender, EventArgs e)
        {
            P_bar_code = long.Parse(Bar_code.Text);

            newCon Check_P_name = new newCon(Logon.Log, Logon.Password);
            Product_name.Text = Check_P_name.Chceck_P_name(ref P_bar_code);

        }

        private void Cus_Name_TextChanged(object sender, EventArgs e)
        {
            Cus_name = Cus_Name.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NIP_number_TextChanged(object sender, EventArgs e)
        {

            Cus_NIP = NIP_number.Text;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            listView1.Update();
        }


        private void Product_name_TextChanged(object sender, EventArgs e)
        {
            P_name = Product_name.Text;
        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                P_amount = Amount.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Please input the number.");
            }
        }

        private void NIP_number_Click(object sender, EventArgs e)
        {
            newCon Get_NIP = new newCon(Logon.Log, Logon.Password);
            NIP = Get_NIP.Check_NIP(ref Cus_name);
            NIP_number.Text = NIP;
        }

       

        private void Invoice_value_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void CASH_CheckedChanged(object sender, EventArgs e)
        {
            if(CASH.Checked)
            {
                payment = "CASH";
            }
        }

        private void CREDIT_CARD_CheckedChanged(object sender, EventArgs e)
        {
            if(CREDIT_CARD.Checked)
            {
                payment = "CREDIT CARD";
            }
        }

        private void TRANSFER_CheckedChanged(object sender, EventArgs e)
        {
            if(TRANSFER.Checked)
            {
                payment = "TRANSFER";
            }
        }

        private void Quantity_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_Click(object sender, EventArgs e)
        {
            
        }
    }
}
