namespace Agriculture_Service_Center
{
    partial class frm_Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login_Form));
            this.btn_Click_Here_To_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Click_Here_To_Login
            // 
            this.btn_Click_Here_To_Login.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Click_Here_To_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Click_Here_To_Login.FlatAppearance.BorderSize = 0;
            this.btn_Click_Here_To_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Click_Here_To_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Click_Here_To_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Click_Here_To_Login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Click_Here_To_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Click_Here_To_Login.Location = new System.Drawing.Point(324, 251);
            this.btn_Click_Here_To_Login.Name = "btn_Click_Here_To_Login";
            this.btn_Click_Here_To_Login.Size = new System.Drawing.Size(245, 51);
            this.btn_Click_Here_To_Login.TabIndex = 0;
            this.btn_Click_Here_To_Login.Text = "click Here To Login";
            this.btn_Click_Here_To_Login.UseVisualStyleBackColor = false;
            this.btn_Click_Here_To_Login.Click += new System.EventHandler(this.btn_Click_Here_To_Login_Click);
            // 
            // frm_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(914, 531);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Click_Here_To_Login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frm_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Click_Here_To_Login;

    }
}

