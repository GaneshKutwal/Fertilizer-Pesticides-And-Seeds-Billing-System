namespace Agriculture_Service_Center
{
    partial class Frm_Update_Employee
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_S_Date = new System.Windows.Forms.DateTimePicker();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.tb_Aadhar_No = new System.Windows.Forms.TextBox();
            this.tb_S_Email = new System.Windows.Forms.TextBox();
            this.tb_S_Mobile = new System.Windows.Forms.TextBox();
            this.tb_S_Address = new System.Windows.Forms.TextBox();
            this.tb_S_Name = new System.Windows.Forms.TextBox();
            this.tb_S_ID = new System.Windows.Forms.TextBox();
            this.lbl_Adhar_No = new System.Windows.Forms.Label();
            this.lbl_S_Email = new System.Windows.Forms.Label();
            this.lbl_S_Mobile = new System.Windows.Forms.Label();
            this.lbl_S_Address = new System.Windows.Forms.Label();
            this.lbl_S_Name = new System.Windows.Forms.Label();
            this.lbl_S_Id = new System.Windows.Forms.Label();
            this.lbl_S_Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(725, 110);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(85, 31);
            this.btn_Search.TabIndex = 47;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_S_Date
            // 
            this.dtp_S_Date.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtp_S_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_S_Date.Location = new System.Drawing.Point(410, 49);
            this.dtp_S_Date.Name = "dtp_S_Date";
            this.dtp_S_Date.Size = new System.Drawing.Size(250, 29);
            this.dtp_S_Date.TabIndex = 61;
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Update.Location = new System.Drawing.Point(263, 477);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(85, 32);
            this.Btn_Update.TabIndex = 53;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // tb_Aadhar_No
            // 
            this.tb_Aadhar_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Aadhar_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Aadhar_No.Location = new System.Drawing.Point(410, 385);
            this.tb_Aadhar_No.MaxLength = 12;
            this.tb_Aadhar_No.Name = "tb_Aadhar_No";
            this.tb_Aadhar_No.Size = new System.Drawing.Size(250, 29);
            this.tb_Aadhar_No.TabIndex = 52;
            this.tb_Aadhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ISNUMBERIC);
            // 
            // tb_S_Email
            // 
            this.tb_S_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_S_Email.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_S_Email.Location = new System.Drawing.Point(410, 329);
            this.tb_S_Email.Name = "tb_S_Email";
            this.tb_S_Email.Size = new System.Drawing.Size(250, 29);
            this.tb_S_Email.TabIndex = 51;
            // 
            // tb_S_Mobile
            // 
            this.tb_S_Mobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_S_Mobile.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_S_Mobile.Location = new System.Drawing.Point(410, 273);
            this.tb_S_Mobile.MaxLength = 10;
            this.tb_S_Mobile.Name = "tb_S_Mobile";
            this.tb_S_Mobile.Size = new System.Drawing.Size(250, 29);
            this.tb_S_Mobile.TabIndex = 50;
            this.tb_S_Mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ISNUMBERIC);
            // 
            // tb_S_Address
            // 
            this.tb_S_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_S_Address.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_S_Address.Location = new System.Drawing.Point(410, 217);
            this.tb_S_Address.Name = "tb_S_Address";
            this.tb_S_Address.Size = new System.Drawing.Size(250, 29);
            this.tb_S_Address.TabIndex = 49;
            // 
            // tb_S_Name
            // 
            this.tb_S_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_S_Name.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_S_Name.Location = new System.Drawing.Point(410, 161);
            this.tb_S_Name.Name = "tb_S_Name";
            this.tb_S_Name.Size = new System.Drawing.Size(250, 29);
            this.tb_S_Name.TabIndex = 48;
            this.tb_S_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ISCHAR);
            // 
            // tb_S_ID
            // 
            this.tb_S_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_S_ID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_S_ID.Location = new System.Drawing.Point(410, 105);
            this.tb_S_ID.Name = "tb_S_ID";
            this.tb_S_ID.Size = new System.Drawing.Size(250, 29);
            this.tb_S_ID.TabIndex = 46;
            // 
            // lbl_Adhar_No
            // 
            this.lbl_Adhar_No.AutoSize = true;
            this.lbl_Adhar_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Adhar_No.Location = new System.Drawing.Point(89, 390);
            this.lbl_Adhar_No.Name = "lbl_Adhar_No";
            this.lbl_Adhar_No.Size = new System.Drawing.Size(94, 23);
            this.lbl_Adhar_No.TabIndex = 56;
            this.lbl_Adhar_No.Text = "Aadhar No.";
            // 
            // lbl_S_Email
            // 
            this.lbl_S_Email.AutoSize = true;
            this.lbl_S_Email.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_S_Email.Location = new System.Drawing.Point(89, 334);
            this.lbl_S_Email.Name = "lbl_S_Email";
            this.lbl_S_Email.Size = new System.Drawing.Size(51, 23);
            this.lbl_S_Email.TabIndex = 54;
            this.lbl_S_Email.Text = "Email";
            // 
            // lbl_S_Mobile
            // 
            this.lbl_S_Mobile.AutoSize = true;
            this.lbl_S_Mobile.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_S_Mobile.Location = new System.Drawing.Point(89, 278);
            this.lbl_S_Mobile.Name = "lbl_S_Mobile";
            this.lbl_S_Mobile.Size = new System.Drawing.Size(91, 23);
            this.lbl_S_Mobile.TabIndex = 55;
            this.lbl_S_Mobile.Text = "Mobile NO.";
            // 
            // lbl_S_Address
            // 
            this.lbl_S_Address.AutoSize = true;
            this.lbl_S_Address.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_S_Address.Location = new System.Drawing.Point(89, 222);
            this.lbl_S_Address.Name = "lbl_S_Address";
            this.lbl_S_Address.Size = new System.Drawing.Size(74, 23);
            this.lbl_S_Address.TabIndex = 57;
            this.lbl_S_Address.Text = "Address";
            // 
            // lbl_S_Name
            // 
            this.lbl_S_Name.AutoSize = true;
            this.lbl_S_Name.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_S_Name.Location = new System.Drawing.Point(89, 166);
            this.lbl_S_Name.Name = "lbl_S_Name";
            this.lbl_S_Name.Size = new System.Drawing.Size(53, 23);
            this.lbl_S_Name.TabIndex = 60;
            this.lbl_S_Name.Text = "Name";
            // 
            // lbl_S_Id
            // 
            this.lbl_S_Id.AutoSize = true;
            this.lbl_S_Id.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_S_Id.Location = new System.Drawing.Point(89, 110);
            this.lbl_S_Id.Name = "lbl_S_Id";
            this.lbl_S_Id.Size = new System.Drawing.Size(24, 23);
            this.lbl_S_Id.TabIndex = 58;
            this.lbl_S_Id.Text = "Id";
            // 
            // lbl_S_Date
            // 
            this.lbl_S_Date.AutoSize = true;
            this.lbl_S_Date.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_S_Date.Location = new System.Drawing.Point(89, 54);
            this.lbl_S_Date.Name = "lbl_S_Date";
            this.lbl_S_Date.Size = new System.Drawing.Size(44, 23);
            this.lbl_S_Date.TabIndex = 59;
            this.lbl_S_Date.Text = "Date";
            // 
            // Frm_Update_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dtp_S_Date);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.tb_Aadhar_No);
            this.Controls.Add(this.tb_S_Email);
            this.Controls.Add(this.tb_S_Mobile);
            this.Controls.Add(this.tb_S_Address);
            this.Controls.Add(this.tb_S_Name);
            this.Controls.Add(this.tb_S_ID);
            this.Controls.Add(this.lbl_Adhar_No);
            this.Controls.Add(this.lbl_S_Email);
            this.Controls.Add(this.lbl_S_Mobile);
            this.Controls.Add(this.lbl_S_Address);
            this.Controls.Add(this.lbl_S_Name);
            this.Controls.Add(this.lbl_S_Id);
            this.Controls.Add(this.lbl_S_Date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Update_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Employee";
            this.Load += new System.EventHandler(this.Frm_Update_Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_S_Date;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.TextBox tb_Aadhar_No;
        private System.Windows.Forms.TextBox tb_S_Email;
        private System.Windows.Forms.TextBox tb_S_Mobile;
        private System.Windows.Forms.TextBox tb_S_Address;
        private System.Windows.Forms.TextBox tb_S_Name;
        private System.Windows.Forms.TextBox tb_S_ID;
        private System.Windows.Forms.Label lbl_Adhar_No;
        private System.Windows.Forms.Label lbl_S_Email;
        private System.Windows.Forms.Label lbl_S_Mobile;
        private System.Windows.Forms.Label lbl_S_Address;
        private System.Windows.Forms.Label lbl_S_Name;
        private System.Windows.Forms.Label lbl_S_Id;
        private System.Windows.Forms.Label lbl_S_Date;

    }
}