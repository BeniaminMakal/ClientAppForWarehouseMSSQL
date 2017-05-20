namespace Cient_App_for_Warehouse
{
    partial class Sale
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cus_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Invoice_value = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.End_Sale = new System.Windows.Forms.Button();
            this.CASH = new System.Windows.Forms.RadioButton();
            this.CREDIT_CARD = new System.Windows.Forms.RadioButton();
            this.TRANSFER = new System.Windows.Forms.RadioButton();
            this.NIPPPPPP = new System.Windows.Forms.Label();
            this.NIP_number = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.Product_name = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Quantity_TextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.LP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prod_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ilosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.P_serial_number = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.P_exp_date = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Bar_code = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cus_Name
            // 
            this.Cus_Name.Location = new System.Drawing.Point(25, 55);
            this.Cus_Name.Name = "Cus_Name";
            this.Cus_Name.Size = new System.Drawing.Size(100, 20);
            this.Cus_Name.TabIndex = 1;
            this.Cus_Name.TextChanged += new System.EventHandler(this.Cus_Name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Creating a new sale";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Products
            // 
            this.Products.Location = new System.Drawing.Point(171, 263);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(97, 23);
            this.Products.TabIndex = 6;
            this.Products.Text = "Add Product";
            this.Products.UseVisualStyleBackColor = true;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Payment:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Invoice value";
            // 
            // Invoice_value
            // 
            this.Invoice_value.Location = new System.Drawing.Point(379, 333);
            this.Invoice_value.Name = "Invoice_value";
            this.Invoice_value.ReadOnly = true;
            this.Invoice_value.Size = new System.Drawing.Size(100, 20);
            this.Invoice_value.TabIndex = 10;
            this.Invoice_value.TextChanged += new System.EventHandler(this.Invoice_value_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Products:";
            // 
            // End_Sale
            // 
            this.End_Sale.Location = new System.Drawing.Point(485, 331);
            this.End_Sale.Name = "End_Sale";
            this.End_Sale.Size = new System.Drawing.Size(75, 23);
            this.End_Sale.TabIndex = 13;
            this.End_Sale.Text = "End Sale";
            this.End_Sale.UseVisualStyleBackColor = true;
            this.End_Sale.Click += new System.EventHandler(this.End_Sale_Click);
            // 
            // CASH
            // 
            this.CASH.AutoSize = true;
            this.CASH.Location = new System.Drawing.Point(25, 147);
            this.CASH.Name = "CASH";
            this.CASH.Size = new System.Drawing.Size(54, 17);
            this.CASH.TabIndex = 14;
            this.CASH.TabStop = true;
            this.CASH.Text = "CASH";
            this.CASH.UseVisualStyleBackColor = true;
            this.CASH.CheckedChanged += new System.EventHandler(this.CASH_CheckedChanged);
            // 
            // CREDIT_CARD
            // 
            this.CREDIT_CARD.AutoSize = true;
            this.CREDIT_CARD.Location = new System.Drawing.Point(25, 165);
            this.CREDIT_CARD.Name = "CREDIT_CARD";
            this.CREDIT_CARD.Size = new System.Drawing.Size(98, 17);
            this.CREDIT_CARD.TabIndex = 15;
            this.CREDIT_CARD.TabStop = true;
            this.CREDIT_CARD.Text = "CREDIT CARD";
            this.CREDIT_CARD.UseVisualStyleBackColor = true;
            this.CREDIT_CARD.CheckedChanged += new System.EventHandler(this.CREDIT_CARD_CheckedChanged);
            // 
            // TRANSFER
            // 
            this.TRANSFER.AutoSize = true;
            this.TRANSFER.Location = new System.Drawing.Point(25, 184);
            this.TRANSFER.Name = "TRANSFER";
            this.TRANSFER.Size = new System.Drawing.Size(83, 17);
            this.TRANSFER.TabIndex = 16;
            this.TRANSFER.TabStop = true;
            this.TRANSFER.Text = "TRANSFER";
            this.TRANSFER.UseVisualStyleBackColor = true;
            this.TRANSFER.CheckedChanged += new System.EventHandler(this.TRANSFER_CheckedChanged);
            // 
            // NIPPPPPP
            // 
            this.NIPPPPPP.AutoSize = true;
            this.NIPPPPPP.Location = new System.Drawing.Point(25, 80);
            this.NIPPPPPP.Name = "NIPPPPPP";
            this.NIPPPPPP.Size = new System.Drawing.Size(25, 13);
            this.NIPPPPPP.TabIndex = 17;
            this.NIPPPPPP.Text = "NIP";
            this.NIPPPPPP.Click += new System.EventHandler(this.label7_Click);
            // 
            // NIP_number
            // 
            this.NIP_number.Location = new System.Drawing.Point(25, 95);
            this.NIP_number.Name = "NIP_number";
            this.NIP_number.Size = new System.Drawing.Size(100, 20);
            this.NIP_number.TabIndex = 18;
            this.NIP_number.Click += new System.EventHandler(this.NIP_number_Click);
            this.NIP_number.TextChanged += new System.EventHandler(this.NIP_number_TextChanged);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(485, 295);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 19;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Product_name
            // 
            this.Product_name.Location = new System.Drawing.Point(168, 97);
            this.Product_name.Name = "Product_name";
            this.Product_name.Size = new System.Drawing.Size(100, 20);
            this.Product_name.TabIndex = 22;
            this.Product_name.TextChanged += new System.EventHandler(this.Product_name_TextChanged);
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(168, 141);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(100, 20);
            this.Amount.TabIndex = 23;
            this.Amount.TextChanged += new System.EventHandler(this.Amount_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Product name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Amount";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(266, 316);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(43, 13);
            this.Quantity.TabIndex = 26;
            this.Quantity.Text = "Amount";
            this.Quantity.Click += new System.EventHandler(this.Quantity_Click);
            // 
            // Quantity_TextBox
            // 
            this.Quantity_TextBox.Location = new System.Drawing.Point(269, 334);
            this.Quantity_TextBox.Name = "Quantity_TextBox";
            this.Quantity_TextBox.ReadOnly = true;
            this.Quantity_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Quantity_TextBox.TabIndex = 27;
            this.Quantity_TextBox.TextChanged += new System.EventHandler(this.Quantity_TextBox_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LP,
            this.Prod_name,
            this.Ilosc,
            this.Price});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(283, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(277, 231);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // LP
            // 
            this.LP.Text = "LP";
            this.LP.Width = 30;
            // 
            // Prod_name
            // 
            this.Prod_name.Text = "Product";
            this.Prod_name.Width = 92;
            // 
            // Ilosc
            // 
            this.Ilosc.Text = "Quantity";
            this.Ilosc.Width = 65;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Serial number";
            // 
            // P_serial_number
            // 
            this.P_serial_number.Location = new System.Drawing.Point(168, 186);
            this.P_serial_number.Name = "P_serial_number";
            this.P_serial_number.Size = new System.Drawing.Size(100, 20);
            this.P_serial_number.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Expiration date";
            // 
            // P_exp_date
            // 
            this.P_exp_date.Location = new System.Drawing.Point(168, 229);
            this.P_exp_date.Name = "P_exp_date";
            this.P_exp_date.Size = new System.Drawing.Size(100, 20);
            this.P_exp_date.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Bar code";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Bar_code
            // 
            this.Bar_code.Location = new System.Drawing.Point(168, 55);
            this.Bar_code.Name = "Bar_code";
            this.Bar_code.Size = new System.Drawing.Size(100, 20);
            this.Bar_code.TabIndex = 35;
            this.Bar_code.TextChanged += new System.EventHandler(this.Bar_code_TextChanged);
            // 
            // Sale
            // 
            this.AcceptButton = this.Products;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 362);
            this.Controls.Add(this.Bar_code);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.P_exp_date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.P_serial_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Quantity_TextBox);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Product_name);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.NIP_number);
            this.Controls.Add(this.NIPPPPPP);
            this.Controls.Add(this.TRANSFER);
            this.Controls.Add(this.CREDIT_CARD);
            this.Controls.Add(this.CASH);
            this.Controls.Add(this.End_Sale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Invoice_value);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cus_Name);
            this.Controls.Add(this.label1);
            this.Name = "Sale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cus_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Invoice_value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button End_Sale;
        private System.Windows.Forms.RadioButton CASH;
        private System.Windows.Forms.RadioButton CREDIT_CARD;
        private System.Windows.Forms.RadioButton TRANSFER;
        private System.Windows.Forms.Label NIPPPPPP;
        private System.Windows.Forms.TextBox NIP_number;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TextBox Product_name;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox Quantity_TextBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader LP;
        private System.Windows.Forms.ColumnHeader Prod_name;
        private System.Windows.Forms.ColumnHeader Ilosc;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox P_serial_number;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox P_exp_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Bar_code;
    }
}