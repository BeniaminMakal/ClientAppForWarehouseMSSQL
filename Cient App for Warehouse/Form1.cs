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
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form 
    {
        string cell_text;

        public Form1()
        {
            InitializeComponent();
            Pracownik_info.Text = "Pracownik: " + Logon.log;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DataTable DT = (DataTable)dataGridView1.DataSource;
            if (DT != null)
                DT.Clear();
        }

        private void Info_Breweries_Click(object sender, EventArgs e)
        {
            DataTable DT = null;
            if (DT != null)
                DT.Clear();
            newCon baza_win = new newCon(Logon.log, Logon.pas);
            dataGridView1.DataSource = baza_win.pobierz_dane("Select * FROM Breweries");
        }

        private void Info_Client_Click(object sender, EventArgs e)
        {
             DataTable DT = null;
            if (DT != null)
                DT.Clear();
            newCon baza_win = new newCon(Logon.log, Logon.pas);
            dataGridView1.DataSource = baza_win.pobierz_dane("Select * FROM Customers");
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Info_Commodities_Click(object sender, EventArgs e)
        {
            DataTable DT = null;
            if (DT != null)
                DT.Clear();
            newCon baza_win = new newCon(Logon.log, Logon.pas);
            dataGridView1.DataSource = baza_win.pobierz_dane("Select * FROM Products");
        }

        private void New_Sale(object sender, EventArgs e)
        {
            Sale Sale = new Sale();
            Sale.Visible = true;
            Sale.TopMost = true;
            Sale.Show();

        }

        private void Pracownik_info_Click(object sender, EventArgs e)
        {
           
        }

        private void Info_Invoices_Click(object sender, EventArgs e)
        {
            DataTable DT = null;
            if (DT != null)
                DT.Clear();
            newCon baza_win = new newCon(Logon.log, Logon.pas);
            dataGridView1.DataSource = baza_win.pobierz_dane("Select * FROM Invoice_headers");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cell_text = dataGridView1.CurrentCell.Value.ToString();
            switch (dataGridView1.CurrentCell.OwningColumn.HeaderText.ToString())
            {
                case "Invoice_ID":
                    DataTable DT = null;
                    if (DT != null)
                        DT.Clear();
                    newCon baza_win = new newCon(Logon.log, Logon.pas);
                    dataGridView1.DataSource = baza_win.pobierz_dane("Select * FROM Invoice_items WHERE Invoice_ID =" + cell_text + ";");
                    break;

                case "Customer_name":
                    
                    DataTable DT1 = null;
                    if (DT1 != null)
                        DT1.Clear();
                    newCon baza_win1 = new newCon(Logon.log, Logon.pas);
                    dataGridView1.DataSource = baza_win1.pobierz_dane("SELECT IH.Customer_ID, IH.Invoice_ID, IH.Invoice_value, IH.Discount, IH.Date_time, IH.Payment FROM Customers AS C JOIN Invoice_headers AS IH ON C.Customer_ID=IH.Customer_ID WHERE Customer_name ='" + cell_text + "';");
                    
                    break;

                case "Br_name":
                    
                    DataTable DT2 = null;
                    if (DT2 != null)
                        DT2.Clear();
                    newCon baza_win2 = new newCon(Logon.log, Logon.pas);
                    dataGridView1.DataSource = baza_win2.pobierz_dane("SELECT * FROM Products WHERE Brewery ='" + cell_text + "';");
                    
                    break;

                case "Dis_name":
                    
                        DataTable DT3 = null;
                        if (DT3 != null)
                            DT3.Clear();
                        newCon baza_win3 = new newCon(Logon.log, Logon.pas);
                        dataGridView1.DataSource = baza_win3.pobierz_dane("SELECT * FROM Products WHERE Distributor ='" + cell_text + "';");

                    break;

                case "P_type":
                  
                        DataTable DT4 = null;
                        if (DT4 != null)
                        DT4.Clear();
                        newCon baza_win4 = new newCon(Logon.log, Logon.pas);
                        dataGridView1.DataSource = baza_win4.pobierz_dane("SELECT * FROM Products WHERE P_type ='" + cell_text + "';");
                    break;

                case "Product_name":
                    DataTable DT5 = null;
                    if (DT5 != null)
                        DT5.Clear();
                    newCon baza_win5 = new newCon(Logon.log, Logon.pas);
                    dataGridView1.DataSource = baza_win5.pobierz_dane("SELECT * FROM Expiration_dates WHERE Product_name ='" + cell_text + "';");
                    break;

            }

        }

        private void New_customer_Click(object sender, EventArgs e)
        {
            New_Customer New_Cus = new New_Customer();
            New_Cus.Visible = true;
            New_Cus.TopMost = true;
            New_Cus.Show();
        }

        private void Add_Brewery_Click(object sender, EventArgs e)
        {
            New_Brewery New_Brew = new New_Brewery();
            New_Brew.Visible = true;
            New_Brew.TopMost = true;
            New_Brew.Show();
        }

        private void Add_Distributor_Click(object sender, EventArgs e)
        {
            New_distributor New_Dis = new New_distributor();
            New_Dis.Visible = true;
            New_Dis.TopMost = true;
            New_Dis.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable DT = null;
            if (DT != null)
                DT.Clear();
            newCon baza_win = new newCon(Logon.log, Logon.pas);
            dataGridView1.DataSource = baza_win.pobierz_dane("Select * FROM Distributors");
        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            New_employee Add_Em = new New_employee();
            Add_Em.Visible = true;
            Add_Em.TopMost = true;
            Add_Em.Show();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            DataTable DT = null;
            if (DT != null)
                DT.Clear();
            newCon baza_win = new newCon(Logon.log, Logon.pas);
            dataGridView1.DataSource = baza_win.pobierz_dane("Select * FROM Employees");
        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            Add_new_product Add_pr = new Add_new_product();
            Add_pr.Visible = true;
            Add_pr.TopMost = true;
            Add_pr.Show();
        }

        private void New_Delivery_Click(object sender, EventArgs e)
        {
            Delivery New_delivery = new Delivery();
            New_delivery.Visible = true;
            New_delivery.TopMost = true;
            New_delivery.Show();
        }
    }
}
