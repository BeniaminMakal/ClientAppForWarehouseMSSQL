namespace Cient_App_for_Warehouse
{
    partial class New_Brewery
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.Br_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.P_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Br_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Br_WWW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(28, 40);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 2;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "City";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(28, 79);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(100, 20);
            this.Location.TabIndex = 4;
            this.Location.TextChanged += new System.EventHandler(this.Location_TextChanged);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(25, 102);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 5;
            this.Address.Text = "Address";
            // 
            // Br_Address
            // 
            this.Br_Address.Location = new System.Drawing.Point(28, 118);
            this.Br_Address.Name = "Br_Address";
            this.Br_Address.Size = new System.Drawing.Size(100, 20);
            this.Br_Address.TabIndex = 6;
            this.Br_Address.TextChanged += new System.EventHandler(this.Br_Address_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Postal code";
            // 
            // P_code
            // 
            this.P_code.Location = new System.Drawing.Point(28, 157);
            this.P_code.Name = "P_code";
            this.P_code.Size = new System.Drawing.Size(100, 20);
            this.P_code.TabIndex = 8;
            this.P_code.TextChanged += new System.EventHandler(this.P_code_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telephone";
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(158, 40);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(100, 20);
            this.Tel.TabIndex = 10;
            this.Tel.TextChanged += new System.EventHandler(this.Tel_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // Br_email
            // 
            this.Br_email.Location = new System.Drawing.Point(158, 79);
            this.Br_email.Name = "Br_email";
            this.Br_email.Size = new System.Drawing.Size(100, 20);
            this.Br_email.TabIndex = 12;
            this.Br_email.TextChanged += new System.EventHandler(this.Br_email_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "WWW";
            // 
            // Br_WWW
            // 
            this.Br_WWW.Location = new System.Drawing.Point(158, 118);
            this.Br_WWW.Name = "Br_WWW";
            this.Br_WWW.Size = new System.Drawing.Size(100, 20);
            this.Br_WWW.TabIndex = 14;
            this.Br_WWW.TextChanged += new System.EventHandler(this.Br_WWW_TextChanged);
            // 
            // New_Brewery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 199);
            this.Controls.Add(this.Br_WWW);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Br_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.P_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Br_Address);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name.Text = "New_Brewery";
            this.Text = "New_Brewery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox Br_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox P_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Br_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Br_WWW;
    }
}