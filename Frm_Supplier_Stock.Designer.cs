namespace Agriculture_Service_Center
{
    partial class Frm_Supplier_Stock
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_S_Name = new System.Windows.Forms.TextBox();
            this.Btn_Show = new System.Windows.Forms.Button();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Supllier_Stock = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supllier_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.tb_S_Name);
            this.panel2.Controls.Add(this.Btn_Show);
            this.panel2.Controls.Add(this.lbl_Supplier_Name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 247);
            this.panel2.TabIndex = 6;
            // 
            // tb_S_Name
            // 
            this.tb_S_Name.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_S_Name.Location = new System.Drawing.Point(683, 63);
            this.tb_S_Name.Name = "tb_S_Name";
            this.tb_S_Name.Size = new System.Drawing.Size(301, 32);
            this.tb_S_Name.TabIndex = 19;
            // 
            // Btn_Show
            // 
            this.Btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Show.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Show.Location = new System.Drawing.Point(473, 152);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(99, 37);
            this.Btn_Show.TabIndex = 18;
            this.Btn_Show.Text = "Show";
            this.Btn_Show.UseVisualStyleBackColor = true;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(144, 63);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(146, 25);
            this.lbl_Supplier_Name.TabIndex = 1;
            this.lbl_Supplier_Name.Text = "Supplier Name :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Supllier_Stock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 349);
            this.panel1.TabIndex = 7;
            // 
            // dgv_Supllier_Stock
            // 
            this.dgv_Supllier_Stock.AllowUserToAddRows = false;
            this.dgv_Supllier_Stock.AllowUserToDeleteRows = false;
            this.dgv_Supllier_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Supllier_Stock.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Supllier_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Supllier_Stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Supllier_Stock.Location = new System.Drawing.Point(0, 0);
            this.dgv_Supllier_Stock.Name = "dgv_Supllier_Stock";
            this.dgv_Supllier_Stock.Size = new System.Drawing.Size(1037, 349);
            this.dgv_Supllier_Stock.TabIndex = 1;
            // 
            // Frm_Supplier_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Supplier_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Stock";
            this.Load += new System.EventHandler(this.Frm_Supplier_Stock_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supllier_Stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Show;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Supllier_Stock;
        private System.Windows.Forms.TextBox tb_S_Name;
    }
}