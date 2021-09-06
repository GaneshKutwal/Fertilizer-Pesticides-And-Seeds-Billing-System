namespace Agriculture_Service_Center
{
    partial class frm_Update_Customer
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
            this.Btn_Update = new System.Windows.Forms.Button();
            this.tb_C_Email_Id = new System.Windows.Forms.TextBox();
            this.tb_C_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_C_Address = new System.Windows.Forms.TextBox();
            this.tb_C_Name = new System.Windows.Forms.TextBox();
            this.tb_C_Id = new System.Windows.Forms.TextBox();
            this.dtp_C_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_C_Email_Id = new System.Windows.Forms.Label();
            this.lbl_C_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_C_Address = new System.Windows.Forms.Label();
            this.lbl_C_Name = new System.Windows.Forms.Label();
            this.lbl_CId = new System.Windows.Forms.Label();
            this.lbl_C_Date = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Update.Location = new System.Drawing.Point(307, 422);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(85, 32);
            this.Btn_Update.TabIndex = 23;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // tb_C_Email_Id
            // 
            this.tb_C_Email_Id.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_C_Email_Id.Location = new System.Drawing.Point(480, 333);
            this.tb_C_Email_Id.Name = "tb_C_Email_Id";
            this.tb_C_Email_Id.Size = new System.Drawing.Size(250, 29);
            this.tb_C_Email_Id.TabIndex = 21;
            // 
            // tb_C_Mobile_No
            // 
            this.tb_C_Mobile_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_C_Mobile_No.Location = new System.Drawing.Point(480, 277);
            this.tb_C_Mobile_No.MaxLength = 10;
            this.tb_C_Mobile_No.Name = "tb_C_Mobile_No";
            this.tb_C_Mobile_No.Size = new System.Drawing.Size(250, 29);
            this.tb_C_Mobile_No.TabIndex = 20;
            this.tb_C_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Numberic);
            // 
            // tb_C_Address
            // 
            this.tb_C_Address.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_C_Address.Location = new System.Drawing.Point(480, 221);
            this.tb_C_Address.Name = "tb_C_Address";
            this.tb_C_Address.Size = new System.Drawing.Size(250, 29);
            this.tb_C_Address.TabIndex = 19;
            // 
            // tb_C_Name
            // 
            this.tb_C_Name.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_C_Name.Location = new System.Drawing.Point(480, 165);
            this.tb_C_Name.Name = "tb_C_Name";
            this.tb_C_Name.Size = new System.Drawing.Size(250, 29);
            this.tb_C_Name.TabIndex = 17;
            this.tb_C_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IS_Char);
            // 
            // tb_C_Id
            // 
            this.tb_C_Id.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_C_Id.Location = new System.Drawing.Point(480, 109);
            this.tb_C_Id.Name = "tb_C_Id";
            this.tb_C_Id.Size = new System.Drawing.Size(250, 29);
            this.tb_C_Id.TabIndex = 14;
            this.tb_C_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Numberic);
            // 
            // dtp_C_Date
            // 
            this.dtp_C_Date.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtp_C_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_C_Date.Location = new System.Drawing.Point(480, 53);
            this.dtp_C_Date.Name = "dtp_C_Date";
            this.dtp_C_Date.Size = new System.Drawing.Size(250, 29);
            this.dtp_C_Date.TabIndex = 12;
            // 
            // lbl_C_Email_Id
            // 
            this.lbl_C_Email_Id.AutoSize = true;
            this.lbl_C_Email_Id.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_C_Email_Id.Location = new System.Drawing.Point(123, 333);
            this.lbl_C_Email_Id.Name = "lbl_C_Email_Id";
            this.lbl_C_Email_Id.Size = new System.Drawing.Size(74, 23);
            this.lbl_C_Email_Id.TabIndex = 22;
            this.lbl_C_Email_Id.Text = "Email Id:";
            // 
            // lbl_C_Mobile_No
            // 
            this.lbl_C_Mobile_No.AutoSize = true;
            this.lbl_C_Mobile_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_C_Mobile_No.Location = new System.Drawing.Point(123, 277);
            this.lbl_C_Mobile_No.Name = "lbl_C_Mobile_No";
            this.lbl_C_Mobile_No.Size = new System.Drawing.Size(90, 23);
            this.lbl_C_Mobile_No.TabIndex = 18;
            this.lbl_C_Mobile_No.Text = "Mobile No:";
            // 
            // lbl_C_Address
            // 
            this.lbl_C_Address.AutoSize = true;
            this.lbl_C_Address.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_C_Address.Location = new System.Drawing.Point(123, 221);
            this.lbl_C_Address.Name = "lbl_C_Address";
            this.lbl_C_Address.Size = new System.Drawing.Size(79, 23);
            this.lbl_C_Address.TabIndex = 16;
            this.lbl_C_Address.Text = "Address:";
            // 
            // lbl_C_Name
            // 
            this.lbl_C_Name.AutoSize = true;
            this.lbl_C_Name.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_C_Name.Location = new System.Drawing.Point(123, 165);
            this.lbl_C_Name.Name = "lbl_C_Name";
            this.lbl_C_Name.Size = new System.Drawing.Size(58, 23);
            this.lbl_C_Name.TabIndex = 15;
            this.lbl_C_Name.Text = "Name:";
            // 
            // lbl_CId
            // 
            this.lbl_CId.AutoSize = true;
            this.lbl_CId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_CId.Location = new System.Drawing.Point(123, 109);
            this.lbl_CId.Name = "lbl_CId";
            this.lbl_CId.Size = new System.Drawing.Size(107, 23);
            this.lbl_CId.TabIndex = 13;
            this.lbl_CId.Text = "Customer Id:";
            // 
            // lbl_C_Date
            // 
            this.lbl_C_Date.AutoSize = true;
            this.lbl_C_Date.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_C_Date.Location = new System.Drawing.Point(123, 53);
            this.lbl_C_Date.Name = "lbl_C_Date";
            this.lbl_C_Date.Size = new System.Drawing.Size(49, 23);
            this.lbl_C_Date.TabIndex = 11;
            this.lbl_C_Date.Text = "Date:";
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(776, 110);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(85, 31);
            this.btn_Search.TabIndex = 24;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Update_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(871, 501);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.Btn_Update);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Update_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Customer";
            this.Load += new System.EventHandler(this.frm_Update_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.TextBox tb_C_Email_Id;
        private System.Windows.Forms.TextBox tb_C_Mobile_No;
        private System.Windows.Forms.TextBox tb_C_Address;
        private System.Windows.Forms.TextBox tb_C_Name;
        private System.Windows.Forms.TextBox tb_C_Id;
        private System.Windows.Forms.DateTimePicker dtp_C_Date;
        private System.Windows.Forms.Label lbl_C_Email_Id;
        private System.Windows.Forms.Label lbl_C_Mobile_No;
        private System.Windows.Forms.Label lbl_C_Address;
        private System.Windows.Forms.Label lbl_C_Name;
        private System.Windows.Forms.Label lbl_CId;
        private System.Windows.Forms.Label lbl_C_Date;
        private System.Windows.Forms.Button btn_Search;

    }
}