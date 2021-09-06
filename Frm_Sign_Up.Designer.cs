namespace Agriculture_Service_Center
{
    partial class Frm_Sign_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sign_Up));
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panal_Right = new System.Windows.Forms.Panel();
            this.lbl_Error_Username = new System.Windows.Forms.Label();
            this.lbl_Error_Admin_Key = new System.Windows.Forms.Label();
            this.lbl_Error_Confirm_Password = new System.Windows.Forms.Label();
            this.btn_Sign_Up = new System.Windows.Forms.Button();
            this.btn_X = new System.Windows.Forms.Button();
            this.tb_Admin_Key = new System.Windows.Forms.TextBox();
            this.lbl_Admin_Key = new System.Windows.Forms.Label();
            this.tb_Confirm_Password = new System.Windows.Forms.TextBox();
            this.lbl_Con_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Sign_Up = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Left.SuspendLayout();
            this.panal_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel_Left.Controls.Add(this.pictureBox1);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(316, 485);
            this.panel_Left.TabIndex = 0;
            // 
            // panal_Right
            // 
            this.panal_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panal_Right.Controls.Add(this.lbl_Error_Username);
            this.panal_Right.Controls.Add(this.lbl_Error_Admin_Key);
            this.panal_Right.Controls.Add(this.lbl_Error_Confirm_Password);
            this.panal_Right.Controls.Add(this.btn_Sign_Up);
            this.panal_Right.Controls.Add(this.btn_X);
            this.panal_Right.Controls.Add(this.tb_Admin_Key);
            this.panal_Right.Controls.Add(this.lbl_Admin_Key);
            this.panal_Right.Controls.Add(this.tb_Confirm_Password);
            this.panal_Right.Controls.Add(this.lbl_Con_Password);
            this.panal_Right.Controls.Add(this.tb_Password);
            this.panal_Right.Controls.Add(this.lbl_Password);
            this.panal_Right.Controls.Add(this.tb_Username);
            this.panal_Right.Controls.Add(this.lbl_Username);
            this.panal_Right.Controls.Add(this.lbl_Sign_Up);
            this.panal_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panal_Right.Location = new System.Drawing.Point(316, 0);
            this.panal_Right.Name = "panal_Right";
            this.panal_Right.Size = new System.Drawing.Size(407, 485);
            this.panal_Right.TabIndex = 1;
            // 
            // lbl_Error_Username
            // 
            this.lbl_Error_Username.AutoSize = true;
            this.lbl_Error_Username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Username.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error_Username.Location = new System.Drawing.Point(49, 151);
            this.lbl_Error_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error_Username.Name = "lbl_Error_Username";
            this.lbl_Error_Username.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_Error_Username.Size = new System.Drawing.Size(158, 18);
            this.lbl_Error_Username.TabIndex = 11;
            this.lbl_Error_Username.Text = "Username Already Taken ";
            this.lbl_Error_Username.Visible = false;
            // 
            // lbl_Error_Admin_Key
            // 
            this.lbl_Error_Admin_Key.AutoSize = true;
            this.lbl_Error_Admin_Key.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Admin_Key.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error_Admin_Key.Location = new System.Drawing.Point(49, 400);
            this.lbl_Error_Admin_Key.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error_Admin_Key.Name = "lbl_Error_Admin_Key";
            this.lbl_Error_Admin_Key.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_Error_Admin_Key.Size = new System.Drawing.Size(112, 18);
            this.lbl_Error_Admin_Key.TabIndex = 7;
            this.lbl_Error_Admin_Key.Text = "Invalid Admin Key";
            this.lbl_Error_Admin_Key.Visible = false;
            // 
            // lbl_Error_Confirm_Password
            // 
            this.lbl_Error_Confirm_Password.AutoSize = true;
            this.lbl_Error_Confirm_Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Confirm_Password.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error_Confirm_Password.Location = new System.Drawing.Point(49, 313);
            this.lbl_Error_Confirm_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error_Confirm_Password.Name = "lbl_Error_Confirm_Password";
            this.lbl_Error_Confirm_Password.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_Error_Confirm_Password.Size = new System.Drawing.Size(165, 18);
            this.lbl_Error_Confirm_Password.TabIndex = 7;
            this.lbl_Error_Confirm_Password.Text = "Password Does Not Match";
            this.lbl_Error_Confirm_Password.Visible = false;
            // 
            // btn_Sign_Up
            // 
            this.btn_Sign_Up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Sign_Up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sign_Up.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sign_Up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sign_Up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sign_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sign_Up.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign_Up.ForeColor = System.Drawing.Color.White;
            this.btn_Sign_Up.Location = new System.Drawing.Point(48, 426);
            this.btn_Sign_Up.Name = "btn_Sign_Up";
            this.btn_Sign_Up.Size = new System.Drawing.Size(263, 36);
            this.btn_Sign_Up.TabIndex = 5;
            this.btn_Sign_Up.Text = "Sign Up";
            this.btn_Sign_Up.UseVisualStyleBackColor = false;
            this.btn_Sign_Up.Click += new System.EventHandler(this.btn_Sign_Up_Click);
            // 
            // btn_X
            // 
            this.btn_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_X.FlatAppearance.BorderSize = 0;
            this.btn_X.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_X.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_X.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_X.ForeColor = System.Drawing.Color.White;
            this.btn_X.Location = new System.Drawing.Point(365, 2);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(34, 26);
            this.btn_X.TabIndex = 6;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // tb_Admin_Key
            // 
            this.tb_Admin_Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Admin_Key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Admin_Key.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Admin_Key.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Admin_Key.Location = new System.Drawing.Point(48, 370);
            this.tb_Admin_Key.Multiline = true;
            this.tb_Admin_Key.Name = "tb_Admin_Key";
            this.tb_Admin_Key.PasswordChar = '*';
            this.tb_Admin_Key.Size = new System.Drawing.Size(263, 25);
            this.tb_Admin_Key.TabIndex = 4;
            this.tb_Admin_Key.Text = "Admin Key";
            this.tb_Admin_Key.Enter += new System.EventHandler(this.tb_Admin_Key_Enter);
            this.tb_Admin_Key.Leave += new System.EventHandler(this.tb_Admin_Key_Leave);
            // 
            // lbl_Admin_Key
            // 
            this.lbl_Admin_Key.AutoSize = true;
            this.lbl_Admin_Key.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin_Key.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Admin_Key.Location = new System.Drawing.Point(48, 335);
            this.lbl_Admin_Key.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Admin_Key.Name = "lbl_Admin_Key";
            this.lbl_Admin_Key.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_Admin_Key.Size = new System.Drawing.Size(104, 24);
            this.lbl_Admin_Key.TabIndex = 0;
            this.lbl_Admin_Key.Text = "Admin Key";
            // 
            // tb_Confirm_Password
            // 
            this.tb_Confirm_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Confirm_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Confirm_Password.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Confirm_Password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Confirm_Password.Location = new System.Drawing.Point(48, 285);
            this.tb_Confirm_Password.Multiline = true;
            this.tb_Confirm_Password.Name = "tb_Confirm_Password";
            this.tb_Confirm_Password.PasswordChar = '*';
            this.tb_Confirm_Password.Size = new System.Drawing.Size(263, 25);
            this.tb_Confirm_Password.TabIndex = 3;
            this.tb_Confirm_Password.Text = "Password";
            this.tb_Confirm_Password.Enter += new System.EventHandler(this.tb_Confirm_Password_Enter);
            this.tb_Confirm_Password.Leave += new System.EventHandler(this.tb_Confirm_Password_Leave);
            // 
            // lbl_Con_Password
            // 
            this.lbl_Con_Password.AutoSize = true;
            this.lbl_Con_Password.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Con_Password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Con_Password.Location = new System.Drawing.Point(48, 247);
            this.lbl_Con_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Con_Password.Name = "lbl_Con_Password";
            this.lbl_Con_Password.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_Con_Password.Size = new System.Drawing.Size(178, 24);
            this.lbl_Con_Password.TabIndex = 0;
            this.lbl_Con_Password.Text = "Confirm Passsword";
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Password.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Password.Location = new System.Drawing.Point(48, 207);
            this.tb_Password.Multiline = true;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(263, 25);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.Text = "Password";
            this.tb_Password.Enter += new System.EventHandler(this.tb_Password_Enter);
            this.tb_Password.Leave += new System.EventHandler(this.tb_Password_Leave);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Password.Location = new System.Drawing.Point(48, 169);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_Password.Size = new System.Drawing.Size(101, 24);
            this.lbl_Password.TabIndex = 0;
            this.lbl_Password.Text = "Password:";
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Username.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Username.Location = new System.Drawing.Point(48, 121);
            this.tb_Username.Multiline = true;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(263, 25);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.Text = "Username";
            this.tb_Username.Enter += new System.EventHandler(this.tb_Username_Enter);
            this.tb_Username.Leave += new System.EventHandler(this.tb_Username_Leave);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Username.Location = new System.Drawing.Point(48, 91);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_Username.Size = new System.Drawing.Size(104, 24);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_Sign_Up
            // 
            this.lbl_Sign_Up.AutoSize = true;
            this.lbl_Sign_Up.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sign_Up.ForeColor = System.Drawing.Color.Red;
            this.lbl_Sign_Up.Location = new System.Drawing.Point(140, 38);
            this.lbl_Sign_Up.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sign_Up.Name = "lbl_Sign_Up";
            this.lbl_Sign_Up.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_Sign_Up.Size = new System.Drawing.Size(107, 31);
            this.lbl_Sign_Up.TabIndex = 0;
            this.lbl_Sign_Up.Text = "Sign Up";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 485);
            this.Controls.Add(this.panal_Right);
            this.Controls.Add(this.panel_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Sign_Up";
            this.panel_Left.ResumeLayout(false);
            this.panal_Right.ResumeLayout(false);
            this.panal_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panal_Right;
        private System.Windows.Forms.Label lbl_Sign_Up;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Admin_Key;
        private System.Windows.Forms.Label lbl_Admin_Key;
        private System.Windows.Forms.TextBox tb_Confirm_Password;
        private System.Windows.Forms.Label lbl_Con_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_Sign_Up;
        private System.Windows.Forms.Label lbl_Error_Confirm_Password;
        private System.Windows.Forms.Label lbl_Error_Admin_Key;
        private System.Windows.Forms.Label lbl_Error_Username;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}