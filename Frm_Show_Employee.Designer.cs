namespace Agriculture_Service_Center
{
    partial class Frm_Show_Employee
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
            this.tb_S_Name = new System.Windows.Forms.TextBox();
            this.lbl_S_Name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Supplier = new System.Windows.Forms.DataGridView();
            this.Btn_Show = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_S_Name
            // 
            this.tb_S_Name.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_S_Name.Location = new System.Drawing.Point(683, 48);
            this.tb_S_Name.Name = "tb_S_Name";
            this.tb_S_Name.Size = new System.Drawing.Size(301, 32);
            this.tb_S_Name.TabIndex = 1;
            // 
            // lbl_S_Name
            // 
            this.lbl_S_Name.AutoSize = true;
            this.lbl_S_Name.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_S_Name.Location = new System.Drawing.Point(183, 51);
            this.lbl_S_Name.Name = "lbl_S_Name";
            this.lbl_S_Name.Size = new System.Drawing.Size(147, 25);
            this.lbl_S_Name.TabIndex = 4;
            this.lbl_S_Name.Text = "Employee Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Supplier);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 419);
            this.panel2.TabIndex = 8;
            // 
            // dgv_Supplier
            // 
            this.dgv_Supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Supplier.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Supplier.Location = new System.Drawing.Point(0, 0);
            this.dgv_Supplier.Name = "dgv_Supplier";
            this.dgv_Supplier.Size = new System.Drawing.Size(1037, 419);
            this.dgv_Supplier.TabIndex = 1;
            // 
            // Btn_Show
            // 
            this.Btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Show.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Show.Location = new System.Drawing.Point(487, 123);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(85, 32);
            this.Btn_Show.TabIndex = 17;
            this.Btn_Show.Text = "Show";
            this.Btn_Show.UseVisualStyleBackColor = true;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.Btn_Show);
            this.panel1.Controls.Add(this.tb_S_Name);
            this.panel1.Controls.Add(this.lbl_S_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 178);
            this.panel1.TabIndex = 7;
            // 
            // Frm_Show_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1037, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Show_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Employee";
            this.Load += new System.EventHandler(this.Frm_Show_Employee_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_S_Name;
        private System.Windows.Forms.Label lbl_S_Name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Supplier;
        private System.Windows.Forms.Button Btn_Show;
        private System.Windows.Forms.Panel panel1;
    }
}