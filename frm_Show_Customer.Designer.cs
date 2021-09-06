namespace Agriculture_Service_Center
{
    partial class Frm_Show_Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_C_Name = new System.Windows.Forms.Label();
            this.tb_C_Name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Show = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_C_Name
            // 
            this.lbl_C_Name.AutoSize = true;
            this.lbl_C_Name.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_C_Name.Location = new System.Drawing.Point(213, 59);
            this.lbl_C_Name.Name = "lbl_C_Name";
            this.lbl_C_Name.Size = new System.Drawing.Size(146, 25);
            this.lbl_C_Name.TabIndex = 1;
            this.lbl_C_Name.Text = "Customer Name";
            // 
            // tb_C_Name
            // 
            this.tb_C_Name.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_C_Name.Location = new System.Drawing.Point(797, 55);
            this.tb_C_Name.Name = "tb_C_Name";
            this.tb_C_Name.Size = new System.Drawing.Size(350, 32);
            this.tb_C_Name.TabIndex = 1;
            this.tb_C_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ischar);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Customer);
            this.panel1.Location = new System.Drawing.Point(1, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 483);
            this.panel1.TabIndex = 3;
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.AllowUserToAddRows = false;
            this.dgv_Customer.AllowUserToDeleteRows = false;
            this.dgv_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customer.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Customer.Location = new System.Drawing.Point(0, 0);
            this.dgv_Customer.Name = "dgv_Customer";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Customer.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Customer.Size = new System.Drawing.Size(1219, 483);
            this.dgv_Customer.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.Btn_Show);
            this.panel2.Controls.Add(this.tb_C_Name);
            this.panel2.Controls.Add(this.lbl_C_Name);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1221, 215);
            this.panel2.TabIndex = 4;
            // 
            // Btn_Show
            // 
            this.Btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Show.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Show.Location = new System.Drawing.Point(568, 142);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(99, 37);
            this.Btn_Show.TabIndex = 18;
            this.Btn_Show.Text = "Show";
            this.Btn_Show.UseVisualStyleBackColor = true;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // Frm_Show_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 697);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Show_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Customer";
            this.Load += new System.EventHandler(this.Frm_Show_Customer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_C_Name;
        private System.Windows.Forms.TextBox tb_C_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Customer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Show;
    }
}