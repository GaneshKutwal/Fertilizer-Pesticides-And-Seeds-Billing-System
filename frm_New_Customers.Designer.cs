namespace Agriculture_Service_Center
{
    partial class frm_New_Customers
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
            this.lbl_C_Date = new System.Windows.Forms.Label();
            this.lbl_CId = new System.Windows.Forms.Label();
            this.lbl_C_Name = new System.Windows.Forms.Label();
            this.lbl_C_Address = new System.Windows.Forms.Label();
            this.lbl_C_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_C_Email_Id = new System.Windows.Forms.Label();
            this.dtp_C_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_C_Id = new System.Windows.Forms.TextBox();
            this.tb_C_Name = new System.Windows.Forms.TextBox();
            this.tb_C_Address = new System.Windows.Forms.TextBox();
            this.tb_C_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_C_Email_Id = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_C_Date
            // 
            this.lbl_C_Date.AutoSize = true;
            this.lbl_C_Date.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_C_Date.Location = new System.Drawing.Point(143, 61);
            this.lbl_C_Date.Name = "lbl_C_Date";
            this.lbl_C_Date.Size = new System.Drawing.Size(49, 23);
            this.lbl_C_Date.TabIndex = 0;
            this.lbl_C_Date.Text = "Date:";
            // 
            // lbl_CId
            // 
            this.lbl_CId.AutoSize = true;
            this.lbl_CId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_CId.Location = new System.Drawing.Point(143, 126);
            this.lbl_CId.Name = "lbl_CId";
            this.lbl_CId.Size = new System.Drawing.Size(107, 23);
            this.lbl_CId.TabIndex = 1;
            this.lbl_CId.Text = "Customer Id:";
            // 
            // lbl_C_Name
            // 
            this.lbl_C_Name.AutoSize = true;
            this.lbl_C_Name.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_C_Name.Location = new System.Drawing.Point(143, 190);
            this.lbl_C_Name.Name = "lbl_C_Name";
            this.lbl_C_Name.Size = new System.Drawing.Size(58, 23);
            this.lbl_C_Name.TabIndex = 2;
            this.lbl_C_Name.Text = "Name:";
            // 
            // lbl_C_Address
            // 
            this.lbl_C_Address.AutoSize = true;
            this.lbl_C_Address.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_C_Address.Location = new System.Drawing.Point(143, 255);
            this.lbl_C_Address.Name = "lbl_C_Address";
            this.lbl_C_Address.Size = new System.Drawing.Size(79, 23);
            this.lbl_C_Address.TabIndex = 3;
            this.lbl_C_Address.Text = "Address:";
            // 
            // lbl_C_Mobile_No
            // 
            this.lbl_C_Mobile_No.AutoSize = true;
            this.lbl_C_Mobile_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_C_Mobile_No.Location = new System.Drawing.Point(143, 320);
            this.lbl_C_Mobile_No.Name = "lbl_C_Mobile_No";
            this.lbl_C_Mobile_No.Size = new System.Drawing.Size(90, 23);
            this.lbl_C_Mobile_No.TabIndex = 4;
            this.lbl_C_Mobile_No.Text = "Mobile No:";
            // 
            // lbl_C_Email_Id
            // 
            this.lbl_C_Email_Id.AutoSize = true;
            this.lbl_C_Email_Id.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_C_Email_Id.Location = new System.Drawing.Point(143, 384);
            this.lbl_C_Email_Id.Name = "lbl_C_Email_Id";
            this.lbl_C_Email_Id.Size = new System.Drawing.Size(74, 23);
            this.lbl_C_Email_Id.TabIndex = 6;
            this.lbl_C_Email_Id.Text = "Email Id:";
            // 
            // dtp_C_Date
            // 
            this.dtp_C_Date.Enabled = false;
            this.dtp_C_Date.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtp_C_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_C_Date.Location = new System.Drawing.Point(518, 55);
            this.dtp_C_Date.Name = "dtp_C_Date";
            this.dtp_C_Date.Size = new System.Drawing.Size(291, 29);
            this.dtp_C_Date.TabIndex = 1;
            // 
            // tb_C_Id
            // 
            this.tb_C_Id.Enabled = false;
            this.tb_C_Id.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_C_Id.Location = new System.Drawing.Point(518, 120);
            this.tb_C_Id.Name = "tb_C_Id";
            this.tb_C_Id.Size = new System.Drawing.Size(291, 29);
            this.tb_C_Id.TabIndex = 1;
            this.tb_C_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Isnumberic);
            // 
            // tb_C_Name
            // 
            this.tb_C_Name.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_C_Name.Location = new System.Drawing.Point(518, 185);
            this.tb_C_Name.Name = "tb_C_Name";
            this.tb_C_Name.Size = new System.Drawing.Size(291, 29);
            this.tb_C_Name.TabIndex = 2;
            this.tb_C_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ischar);
            // 
            // tb_C_Address
            // 
            this.tb_C_Address.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_C_Address.Location = new System.Drawing.Point(518, 249);
            this.tb_C_Address.Name = "tb_C_Address";
            this.tb_C_Address.Size = new System.Drawing.Size(291, 29);
            this.tb_C_Address.TabIndex = 3;
            // 
            // tb_C_Mobile_No
            // 
            this.tb_C_Mobile_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_C_Mobile_No.Location = new System.Drawing.Point(518, 314);
            this.tb_C_Mobile_No.MaxLength = 10;
            this.tb_C_Mobile_No.Name = "tb_C_Mobile_No";
            this.tb_C_Mobile_No.Size = new System.Drawing.Size(291, 29);
            this.tb_C_Mobile_No.TabIndex = 4;
            this.tb_C_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Isnumberic);
            // 
            // tb_C_Email_Id
            // 
            this.tb_C_Email_Id.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_C_Email_Id.Location = new System.Drawing.Point(518, 378);
            this.tb_C_Email_Id.Name = "tb_C_Email_Id";
            this.tb_C_Email_Id.Size = new System.Drawing.Size(291, 29);
            this.tb_C_Email_Id.TabIndex = 5;
            // 
            // Btn_Add
            // 
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Add.Location = new System.Drawing.Point(329, 449);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(99, 37);
            this.Btn_Add.TabIndex = 6;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // frm_New_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(954, 553);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.tb_C_Email_Id);
            this.Controls.Add(this.tb_C_Mobile_No);
            this.Controls.Add(this.tb_C_Address);
            this.Controls.Add(this.tb_C_Name);
            this.Controls.Add(this.tb_C_Id);
            this.Controls.Add(this.dtp_C_Date);
            this.Controls.Add(this.lbl_C_Email_Id);
            this.Controls.Add(this.lbl_C_Mobile_No);
            this.Controls.Add(this.lbl_C_Address);
            this.Controls.Add(this.lbl_C_Name);
            this.Controls.Add(this.lbl_CId);
            this.Controls.Add(this.lbl_C_Date);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_New_Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " New Customer";
            this.Load += new System.EventHandler(this.frm_New_Customers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_C_Date;
        private System.Windows.Forms.Label lbl_CId;
        private System.Windows.Forms.Label lbl_C_Name;
        private System.Windows.Forms.Label lbl_C_Address;
        private System.Windows.Forms.Label lbl_C_Mobile_No;
        private System.Windows.Forms.Label lbl_C_Email_Id;
        private System.Windows.Forms.DateTimePicker dtp_C_Date;
        private System.Windows.Forms.TextBox tb_C_Id;
        private System.Windows.Forms.TextBox tb_C_Name;
        private System.Windows.Forms.TextBox tb_C_Address;
        private System.Windows.Forms.TextBox tb_C_Mobile_No;
        private System.Windows.Forms.TextBox tb_C_Email_Id;
        private System.Windows.Forms.Button Btn_Add;
    }
}