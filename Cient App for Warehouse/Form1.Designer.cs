namespace Cient_App_for_Warehouse
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Clear = new System.Windows.Forms.Button();
            this.Info_Client = new System.Windows.Forms.Button();
            this.Breweries = new System.Windows.Forms.Button();
            this.wholesaleDataSet = new Cient_App_for_Warehouse.WholesaleDataSet();
            this.breweriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breweriesTableAdapter = new Cient_App_for_Warehouse.WholesaleDataSetTableAdapters.BreweriesTableAdapter();
            this.tableAdapterManager = new Cient_App_for_Warehouse.WholesaleDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new Cient_App_for_Warehouse.WholesaleDataSetTableAdapters.CustomersTableAdapter();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Info_Commodities = new System.Windows.Forms.Button();
            this.Sale = new System.Windows.Forms.Button();
            this.Info_Invoices = new System.Windows.Forms.Button();
            this.Pracownik_info = new System.Windows.Forms.Label();
            this.New_customer = new System.Windows.Forms.Button();
            this.Add_Brewery = new System.Windows.Forms.Button();
            this.Add_Distributor = new System.Windows.Forms.Button();
            this.Add_Employee = new System.Windows.Forms.Button();
            this.Add_Product = new System.Windows.Forms.Button();
            this.New_Delivery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Employees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wholesaleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(913, 260);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Info_Client
            // 
            this.Info_Client.Location = new System.Drawing.Point(12, 260);
            this.Info_Client.Name = "Info_Client";
            this.Info_Client.Size = new System.Drawing.Size(75, 23);
            this.Info_Client.TabIndex = 4;
            this.Info_Client.Text = "Customers";
            this.Info_Client.UseVisualStyleBackColor = true;
            this.Info_Client.Click += new System.EventHandler(this.Info_Client_Click);
            // 
            // Breweries
            // 
            this.Breweries.Location = new System.Drawing.Point(93, 260);
            this.Breweries.Name = "Breweries";
            this.Breweries.Size = new System.Drawing.Size(75, 23);
            this.Breweries.TabIndex = 5;
            this.Breweries.Text = "Breweries";
            this.Breweries.UseVisualStyleBackColor = true;
            this.Breweries.Click += new System.EventHandler(this.Info_Breweries_Click);
            // 
            // wholesaleDataSet
            // 
            this.wholesaleDataSet.DataSetName = "WholesaleDataSet";
            this.wholesaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // breweriesBindingSource
            // 
            this.breweriesBindingSource.DataMember = "Breweries";
            this.breweriesBindingSource.DataSource = this.wholesaleDataSet;
            // 
            // breweriesTableAdapter
            // 
            this.breweriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BreweriesTableAdapter = this.breweriesTableAdapter;
            this.tableAdapterManager.Cus_TypesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.DistributorsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.Invoice_headersTableAdapter = null;
            this.tableAdapterManager.Invoice_itemsTableAdapter = null;
            this.tableAdapterManager.Products_TypesTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SaleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cient_App_for_Warehouse.WholesaleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.wholesaleDataSet;
            // 
            // Info_Commodities
            // 
            this.Info_Commodities.Location = new System.Drawing.Point(174, 260);
            this.Info_Commodities.Name = "Info_Commodities";
            this.Info_Commodities.Size = new System.Drawing.Size(75, 23);
            this.Info_Commodities.TabIndex = 6;
            this.Info_Commodities.Text = "Commodities";
            this.Info_Commodities.UseVisualStyleBackColor = true;
            this.Info_Commodities.Click += new System.EventHandler(this.Info_Commodities_Click);
            // 
            // Sale
            // 
            this.Sale.Location = new System.Drawing.Point(12, 289);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(75, 23);
            this.Sale.TabIndex = 7;
            this.Sale.Text = "New Sale";
            this.Sale.UseVisualStyleBackColor = true;
            this.Sale.Click += new System.EventHandler(this.New_Sale);
            // 
            // Info_Invoices
            // 
            this.Info_Invoices.Location = new System.Drawing.Point(418, 259);
            this.Info_Invoices.Name = "Info_Invoices";
            this.Info_Invoices.Size = new System.Drawing.Size(75, 23);
            this.Info_Invoices.TabIndex = 8;
            this.Info_Invoices.Text = "Invoices";
            this.Info_Invoices.UseVisualStyleBackColor = true;
            this.Info_Invoices.Click += new System.EventHandler(this.Info_Invoices_Click);
            // 
            // Pracownik_info
            // 
            this.Pracownik_info.AutoSize = true;
            this.Pracownik_info.Location = new System.Drawing.Point(902, 302);
            this.Pracownik_info.Name = "Pracownik_info";
            this.Pracownik_info.Size = new System.Drawing.Size(77, 13);
            this.Pracownik_info.TabIndex = 9;
            this.Pracownik_info.Text = "Pracownik info";
            this.Pracownik_info.Click += new System.EventHandler(this.Pracownik_info_Click);
            // 
            // New_customer
            // 
            this.New_customer.Location = new System.Drawing.Point(93, 289);
            this.New_customer.Name = "New_customer";
            this.New_customer.Size = new System.Drawing.Size(110, 23);
            this.New_customer.TabIndex = 10;
            this.New_customer.Text = "Add new customer";
            this.New_customer.UseVisualStyleBackColor = true;
            this.New_customer.Click += new System.EventHandler(this.New_customer_Click);
            // 
            // Add_Brewery
            // 
            this.Add_Brewery.Location = new System.Drawing.Point(209, 289);
            this.Add_Brewery.Name = "Add_Brewery";
            this.Add_Brewery.Size = new System.Drawing.Size(105, 23);
            this.Add_Brewery.TabIndex = 11;
            this.Add_Brewery.Text = "Add new brewery";
            this.Add_Brewery.UseVisualStyleBackColor = true;
            this.Add_Brewery.Click += new System.EventHandler(this.Add_Brewery_Click);
            // 
            // Add_Distributor
            // 
            this.Add_Distributor.Location = new System.Drawing.Point(321, 289);
            this.Add_Distributor.Name = "Add_Distributor";
            this.Add_Distributor.Size = new System.Drawing.Size(107, 23);
            this.Add_Distributor.TabIndex = 12;
            this.Add_Distributor.Text = "Add new distributor";
            this.Add_Distributor.UseVisualStyleBackColor = true;
            this.Add_Distributor.Click += new System.EventHandler(this.Add_Distributor_Click);
            // 
            // Add_Employee
            // 
            this.Add_Employee.Location = new System.Drawing.Point(435, 289);
            this.Add_Employee.Name = "Add_Employee";
            this.Add_Employee.Size = new System.Drawing.Size(117, 23);
            this.Add_Employee.TabIndex = 13;
            this.Add_Employee.Text = "Add new empoyee";
            this.Add_Employee.UseVisualStyleBackColor = true;
            this.Add_Employee.Click += new System.EventHandler(this.Add_Employee_Click);
            // 
            // Add_Product
            // 
            this.Add_Product.Location = new System.Drawing.Point(559, 289);
            this.Add_Product.Name = "Add_Product";
            this.Add_Product.Size = new System.Drawing.Size(99, 23);
            this.Add_Product.TabIndex = 14;
            this.Add_Product.Text = "Add new product";
            this.Add_Product.UseVisualStyleBackColor = true;
            this.Add_Product.Click += new System.EventHandler(this.Add_Product_Click);
            // 
            // New_Delivery
            // 
            this.New_Delivery.Location = new System.Drawing.Point(824, 261);
            this.New_Delivery.Name = "New_Delivery";
            this.New_Delivery.Size = new System.Drawing.Size(75, 23);
            this.New_Delivery.TabIndex = 15;
            this.New_Delivery.Text = "Delivery";
            this.New_Delivery.UseVisualStyleBackColor = true;
            this.New_Delivery.Click += new System.EventHandler(this.New_Delivery_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(987, 238);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Distributors";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employees
            // 
            this.Employees.Location = new System.Drawing.Point(337, 259);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(75, 23);
            this.Employees.TabIndex = 19;
            this.Employees.Text = "Employees";
            this.Employees.UseVisualStyleBackColor = true;
            this.Employees.Click += new System.EventHandler(this.Employees_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 322);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.New_Delivery);
            this.Controls.Add(this.Add_Product);
            this.Controls.Add(this.Add_Employee);
            this.Controls.Add(this.Add_Distributor);
            this.Controls.Add(this.Add_Brewery);
            this.Controls.Add(this.New_customer);
            this.Controls.Add(this.Pracownik_info);
            this.Controls.Add(this.Info_Invoices);
            this.Controls.Add(this.Sale);
            this.Controls.Add(this.Info_Commodities);
            this.Controls.Add(this.Breweries);
            this.Controls.Add(this.Info_Client);
            this.Controls.Add(this.Clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wholesaleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Info_Client;
        private System.Windows.Forms.Button Breweries;
        private WholesaleDataSet wholesaleDataSet;
        private System.Windows.Forms.BindingSource breweriesBindingSource;
        private WholesaleDataSetTableAdapters.BreweriesTableAdapter breweriesTableAdapter;
        private WholesaleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private WholesaleDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.Button Info_Commodities;
        private System.Windows.Forms.Button Sale;
        private System.Windows.Forms.Button Info_Invoices;
        private System.Windows.Forms.Label Pracownik_info;
        private System.Windows.Forms.Button New_customer;
        private System.Windows.Forms.Button Add_Brewery;
        private System.Windows.Forms.Button Add_Distributor;
        private System.Windows.Forms.Button Add_Employee;
        private System.Windows.Forms.Button Add_Product;
        private System.Windows.Forms.Button New_Delivery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Employees;
    }
}

