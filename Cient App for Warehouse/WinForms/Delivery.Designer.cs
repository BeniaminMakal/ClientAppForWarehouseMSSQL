namespace Cient_App_for_Warehouse
{
    partial class Delivery
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
            this.Product_name = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.P_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Serial_number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.P_exp_date = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // Product_name
            // 
            this.Product_name.Location = new System.Drawing.Point(25, 39);
            this.Product_name.Name = "Product_name";
            this.Product_name.Size = new System.Drawing.Size(100, 20);
            this.Product_name.TabIndex = 1;
            this.Product_name.TextChanged += new System.EventHandler(this.Product_name_TextChanged);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(25, 66);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 2;
            this.Amount.Text = "Amount";
            // 
            // P_amount
            // 
            this.P_amount.Location = new System.Drawing.Point(25, 83);
            this.P_amount.Name = "P_amount";
            this.P_amount.Size = new System.Drawing.Size(100, 20);
            this.P_amount.TabIndex = 3;
            this.P_amount.TextChanged += new System.EventHandler(this.Product_amount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serial number";
            // 
            // Serial_number
            // 
            this.Serial_number.Location = new System.Drawing.Point(25, 126);
            this.Serial_number.Name = "Serial_number";
            this.Serial_number.Size = new System.Drawing.Size(100, 20);
            this.Serial_number.TabIndex = 5;
            this.Serial_number.TextChanged += new System.EventHandler(this.Serial_number_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Expiration date";
            // 
            // P_exp_date
            // 
            this.P_exp_date.Location = new System.Drawing.Point(175, 39);
            this.P_exp_date.Name = "P_exp_date";
            this.P_exp_date.Size = new System.Drawing.Size(100, 20);
            this.P_exp_date.TabIndex = 7;
            this.P_exp_date.TextChanged += new System.EventHandler(this.P_exp_date_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "e.g. 2017-02-12 20:22:21:000";
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.P_exp_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Serial_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.P_amount);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Product_name);
            this.Controls.Add(this.label1);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Product_name;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox P_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Serial_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox P_exp_date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}