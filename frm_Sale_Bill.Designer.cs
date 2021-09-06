namespace Agriculture_Service_Center
{
    partial class frm_Sale_Bill
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
            this.p_Up = new System.Windows.Forms.Panel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Customer = new System.Windows.Forms.TextBox();
            this.cmb_Pay_Mode = new System.Windows.Forms.ComboBox();
            this.lbl_Pay_Mode = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.cmb_Customer = new System.Windows.Forms.ComboBox();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.tb_No = new System.Windows.Forms.TextBox();
            this.lbl_No = new System.Windows.Forms.Label();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.p_Mid = new System.Windows.Forms.Panel();
            this.btn_Material = new System.Windows.Forms.Button();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_TotalAmt = new System.Windows.Forms.Label();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.tb_SGst = new System.Windows.Forms.TextBox();
            this.lbl_SGst = new System.Windows.Forms.Label();
            this.tb_Rate = new System.Windows.Forms.TextBox();
            this.lbl_Rate = new System.Windows.Forms.Label();
            this.tb_Unit = new System.Windows.Forms.TextBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.dtp_Expiry = new System.Windows.Forms.DateTimePicker();
            this.lbl_Expiry = new System.Windows.Forms.Label();
            this.cmb_Product = new System.Windows.Forms.ComboBox();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.lbl_Sr_No = new System.Windows.Forms.Label();
            this.tb_Sr_No = new System.Windows.Forms.TextBox();
            this.p_Bottom = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.lbl_Gross_Amount = new System.Windows.Forms.Label();
            this.tb_G_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Total_Amt = new System.Windows.Forms.TextBox();
            this.lbl_Unit2 = new System.Windows.Forms.Label();
            this.tb_Unit2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_Sale_Bill = new System.Windows.Forms.DataGridView();
            this.srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_Up.SuspendLayout();
            this.p_Mid.SuspendLayout();
            this.p_Bottom.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sale_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Up
            // 
            this.p_Up.BackColor = System.Drawing.Color.LightCyan;
            this.p_Up.Controls.Add(this.lbl_Name);
            this.p_Up.Controls.Add(this.tb_Customer);
            this.p_Up.Controls.Add(this.cmb_Pay_Mode);
            this.p_Up.Controls.Add(this.lbl_Pay_Mode);
            this.p_Up.Controls.Add(this.lbl_Mobile_No);
            this.p_Up.Controls.Add(this.tb_Mobile_No);
            this.p_Up.Controls.Add(this.dtp_Date);
            this.p_Up.Controls.Add(this.lbl_Date);
            this.p_Up.Controls.Add(this.cmb_Customer);
            this.p_Up.Controls.Add(this.lbl_Customer);
            this.p_Up.Controls.Add(this.tb_No);
            this.p_Up.Controls.Add(this.lbl_No);
            this.p_Up.Controls.Add(this.btn_Customer);
            this.p_Up.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Up.Location = new System.Drawing.Point(0, 0);
            this.p_Up.Name = "p_Up";
            this.p_Up.Size = new System.Drawing.Size(1051, 121);
            this.p_Up.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.Location = new System.Drawing.Point(230, 16);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(58, 23);
            this.lbl_Name.TabIndex = 18;
            this.lbl_Name.Text = "Name:";
            // 
            // tb_Customer
            // 
            this.tb_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Customer.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Customer.Location = new System.Drawing.Point(369, 67);
            this.tb_Customer.Name = "tb_Customer";
            this.tb_Customer.Size = new System.Drawing.Size(300, 29);
            this.tb_Customer.TabIndex = 17;
            // 
            // cmb_Pay_Mode
            // 
            this.cmb_Pay_Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Pay_Mode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Pay_Mode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Pay_Mode.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmb_Pay_Mode.FormattingEnabled = true;
            this.cmb_Pay_Mode.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "UPI"});
            this.cmb_Pay_Mode.Location = new System.Drawing.Point(111, 67);
            this.cmb_Pay_Mode.Name = "cmb_Pay_Mode";
            this.cmb_Pay_Mode.Size = new System.Drawing.Size(154, 31);
            this.cmb_Pay_Mode.TabIndex = 15;
            // 
            // lbl_Pay_Mode
            // 
            this.lbl_Pay_Mode.AutoSize = true;
            this.lbl_Pay_Mode.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Pay_Mode.Location = new System.Drawing.Point(18, 70);
            this.lbl_Pay_Mode.Name = "lbl_Pay_Mode";
            this.lbl_Pay_Mode.Size = new System.Drawing.Size(89, 23);
            this.lbl_Pay_Mode.TabIndex = 16;
            this.lbl_Pay_Mode.Text = "Pay Mode:";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Mobile_No.Location = new System.Drawing.Point(688, 70);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(90, 23);
            this.lbl_Mobile_No.TabIndex = 14;
            this.lbl_Mobile_No.Text = "Mobile No:";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Mobile_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Mobile_No.Location = new System.Drawing.Point(797, 67);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(234, 29);
            this.tb_Mobile_No.TabIndex = 13;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(880, 13);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(161, 29);
            this.dtp_Date.TabIndex = 11;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.Location = new System.Drawing.Point(810, 16);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(49, 23);
            this.lbl_Date.TabIndex = 12;
            this.lbl_Date.Text = "Date:";
            // 
            // cmb_Customer
            // 
            this.cmb_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Customer.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmb_Customer.FormattingEnabled = true;
            this.cmb_Customer.Location = new System.Drawing.Point(302, 13);
            this.cmb_Customer.Name = "cmb_Customer";
            this.cmb_Customer.Size = new System.Drawing.Size(310, 31);
            this.cmb_Customer.TabIndex = 9;
            this.cmb_Customer.SelectedIndexChanged += new System.EventHandler(this.cmb_Customer_SelectedIndexChanged);
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Customer.Location = new System.Drawing.Point(274, 70);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(89, 23);
            this.lbl_Customer.TabIndex = 10;
            this.lbl_Customer.Text = "Customer:";
            // 
            // tb_No
            // 
            this.tb_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_No.Enabled = false;
            this.tb_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_No.Location = new System.Drawing.Point(66, 13);
            this.tb_No.Name = "tb_No";
            this.tb_No.Size = new System.Drawing.Size(72, 29);
            this.tb_No.TabIndex = 7;
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_No.Location = new System.Drawing.Point(19, 16);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(36, 23);
            this.lbl_No.TabIndex = 8;
            this.lbl_No.Text = "No:";
            // 
            // btn_Customer
            // 
            this.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Customer.Location = new System.Drawing.Point(634, 14);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(35, 31);
            this.btn_Customer.TabIndex = 15;
            this.btn_Customer.Text = "...";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // p_Mid
            // 
            this.p_Mid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p_Mid.BackColor = System.Drawing.Color.LightCyan;
            this.p_Mid.Controls.Add(this.btn_Material);
            this.p_Mid.Controls.Add(this.tb_Total_Amount);
            this.p_Mid.Controls.Add(this.lbl_TotalAmt);
            this.p_Mid.Controls.Add(this.tb_Amount);
            this.p_Mid.Controls.Add(this.lbl_Amount);
            this.p_Mid.Controls.Add(this.tb_SGst);
            this.p_Mid.Controls.Add(this.lbl_SGst);
            this.p_Mid.Controls.Add(this.tb_Rate);
            this.p_Mid.Controls.Add(this.lbl_Rate);
            this.p_Mid.Controls.Add(this.tb_Unit);
            this.p_Mid.Controls.Add(this.lbl_Unit);
            this.p_Mid.Controls.Add(this.dtp_Expiry);
            this.p_Mid.Controls.Add(this.lbl_Expiry);
            this.p_Mid.Controls.Add(this.cmb_Product);
            this.p_Mid.Controls.Add(this.lbl_Product);
            this.p_Mid.Controls.Add(this.lbl_Sr_No);
            this.p_Mid.Controls.Add(this.tb_Sr_No);
            this.p_Mid.Location = new System.Drawing.Point(0, 126);
            this.p_Mid.Name = "p_Mid";
            this.p_Mid.Size = new System.Drawing.Size(1051, 150);
            this.p_Mid.TabIndex = 2;
            // 
            // btn_Material
            // 
            this.btn_Material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Material.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Material.Location = new System.Drawing.Point(425, 35);
            this.btn_Material.Name = "btn_Material";
            this.btn_Material.Size = new System.Drawing.Size(35, 31);
            this.btn_Material.TabIndex = 27;
            this.btn_Material.Text = "...";
            this.btn_Material.UseVisualStyleBackColor = true;
            this.btn_Material.Click += new System.EventHandler(this.btn_Material_Click);
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Total_Amount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Total_Amount.Location = new System.Drawing.Point(918, 105);
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.ReadOnly = true;
            this.tb_Total_Amount.Size = new System.Drawing.Size(121, 29);
            this.tb_Total_Amount.TabIndex = 9;
            this.tb_Total_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Total_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Total_Amount_KeyPress);
            // 
            // lbl_TotalAmt
            // 
            this.lbl_TotalAmt.AutoSize = true;
            this.lbl_TotalAmt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalAmt.Location = new System.Drawing.Point(932, 79);
            this.lbl_TotalAmt.Name = "lbl_TotalAmt";
            this.lbl_TotalAmt.Size = new System.Drawing.Size(87, 23);
            this.lbl_TotalAmt.TabIndex = 26;
            this.lbl_TotalAmt.Text = "Total Amt:";
            // 
            // tb_Amount
            // 
            this.tb_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Amount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Amount.Location = new System.Drawing.Point(752, 105);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.ReadOnly = true;
            this.tb_Amount.Size = new System.Drawing.Size(121, 29);
            this.tb_Amount.TabIndex = 8;
            this.tb_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Amount.Location = new System.Drawing.Point(769, 79);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(75, 23);
            this.lbl_Amount.TabIndex = 24;
            this.lbl_Amount.Text = "Amount:";
            // 
            // tb_SGst
            // 
            this.tb_SGst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SGst.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_SGst.Location = new System.Drawing.Point(948, 35);
            this.tb_SGst.Name = "tb_SGst";
            this.tb_SGst.ReadOnly = true;
            this.tb_SGst.Size = new System.Drawing.Size(91, 29);
            this.tb_SGst.TabIndex = 7;
            this.tb_SGst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_SGst
            // 
            this.lbl_SGst.AutoSize = true;
            this.lbl_SGst.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_SGst.Location = new System.Drawing.Point(968, 11);
            this.lbl_SGst.Name = "lbl_SGst";
            this.lbl_SGst.Size = new System.Drawing.Size(41, 23);
            this.lbl_SGst.TabIndex = 22;
            this.lbl_SGst.Text = "Gst:";
            // 
            // tb_Rate
            // 
            this.tb_Rate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Rate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Rate.Location = new System.Drawing.Point(819, 35);
            this.tb_Rate.Name = "tb_Rate";
            this.tb_Rate.ReadOnly = true;
            this.tb_Rate.Size = new System.Drawing.Size(91, 29);
            this.tb_Rate.TabIndex = 6;
            this.tb_Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Rate
            // 
            this.lbl_Rate.AutoSize = true;
            this.lbl_Rate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Rate.Location = new System.Drawing.Point(839, 11);
            this.lbl_Rate.Name = "lbl_Rate";
            this.lbl_Rate.Size = new System.Drawing.Size(49, 23);
            this.lbl_Rate.TabIndex = 20;
            this.lbl_Rate.Text = "Rate:";
            // 
            // tb_Unit
            // 
            this.tb_Unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Unit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Unit.Location = new System.Drawing.Point(683, 35);
            this.tb_Unit.Name = "tb_Unit";
            this.tb_Unit.Size = new System.Drawing.Size(91, 29);
            this.tb_Unit.TabIndex = 5;
            this.tb_Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Unit.TextChanged += new System.EventHandler(this.tb_Unit_TextChanged);
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Unit.Location = new System.Drawing.Point(706, 11);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(45, 23);
            this.lbl_Unit.TabIndex = 18;
            this.lbl_Unit.Text = "Unit:";
            // 
            // dtp_Expiry
            // 
            this.dtp_Expiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Expiry.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtp_Expiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Expiry.Location = new System.Drawing.Point(487, 35);
            this.dtp_Expiry.Name = "dtp_Expiry";
            this.dtp_Expiry.Size = new System.Drawing.Size(149, 29);
            this.dtp_Expiry.TabIndex = 17;
            // 
            // lbl_Expiry
            // 
            this.lbl_Expiry.AutoSize = true;
            this.lbl_Expiry.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Expiry.Location = new System.Drawing.Point(537, 11);
            this.lbl_Expiry.Name = "lbl_Expiry";
            this.lbl_Expiry.Size = new System.Drawing.Size(63, 23);
            this.lbl_Expiry.TabIndex = 16;
            this.lbl_Expiry.Text = "Expiry:";
            // 
            // cmb_Product
            // 
            this.cmb_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Product.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmb_Product.FormattingEnabled = true;
            this.cmb_Product.Location = new System.Drawing.Point(148, 35);
            this.cmb_Product.Name = "cmb_Product";
            this.cmb_Product.Size = new System.Drawing.Size(260, 31);
            this.cmb_Product.TabIndex = 4;
            this.cmb_Product.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_SelectedIndexChanged);
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Product.Location = new System.Drawing.Point(231, 11);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(79, 23);
            this.lbl_Product.TabIndex = 13;
            this.lbl_Product.Text = "Product :";
            // 
            // lbl_Sr_No
            // 
            this.lbl_Sr_No.AutoSize = true;
            this.lbl_Sr_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Sr_No.Location = new System.Drawing.Point(50, 11);
            this.lbl_Sr_No.Name = "lbl_Sr_No";
            this.lbl_Sr_No.Size = new System.Drawing.Size(56, 23);
            this.lbl_Sr_No.TabIndex = 5;
            this.lbl_Sr_No.Text = "Sr No:";
            // 
            // tb_Sr_No
            // 
            this.tb_Sr_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Sr_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Sr_No.Location = new System.Drawing.Point(29, 35);
            this.tb_Sr_No.Name = "tb_Sr_No";
            this.tb_Sr_No.ReadOnly = true;
            this.tb_Sr_No.Size = new System.Drawing.Size(91, 29);
            this.tb_Sr_No.TabIndex = 3;
            this.tb_Sr_No.Text = "1";
            this.tb_Sr_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_Bottom
            // 
            this.p_Bottom.BackColor = System.Drawing.Color.LightCyan;
            this.p_Bottom.Controls.Add(this.Btn_Save);
            this.p_Bottom.Controls.Add(this.lbl_Gross_Amount);
            this.p_Bottom.Controls.Add(this.tb_G_Amount);
            this.p_Bottom.Controls.Add(this.lbl_Discount);
            this.p_Bottom.Controls.Add(this.tb_Discount);
            this.p_Bottom.Controls.Add(this.label1);
            this.p_Bottom.Controls.Add(this.tb_Total_Amt);
            this.p_Bottom.Controls.Add(this.lbl_Unit2);
            this.p_Bottom.Controls.Add(this.tb_Unit2);
            this.p_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_Bottom.Location = new System.Drawing.Point(0, 441);
            this.p_Bottom.Name = "p_Bottom";
            this.p_Bottom.Size = new System.Drawing.Size(1051, 100);
            this.p_Bottom.TabIndex = 3;
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.Location = new System.Drawing.Point(16, 9);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(85, 32);
            this.Btn_Save.TabIndex = 15;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // lbl_Gross_Amount
            // 
            this.lbl_Gross_Amount.AutoSize = true;
            this.lbl_Gross_Amount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Gross_Amount.Location = new System.Drawing.Point(549, 18);
            this.lbl_Gross_Amount.Name = "lbl_Gross_Amount";
            this.lbl_Gross_Amount.Size = new System.Drawing.Size(125, 23);
            this.lbl_Gross_Amount.TabIndex = 20;
            this.lbl_Gross_Amount.Text = "Gross Amount:";
            // 
            // tb_G_Amount
            // 
            this.tb_G_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_G_Amount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_G_Amount.Location = new System.Drawing.Point(687, 15);
            this.tb_G_Amount.Name = "tb_G_Amount";
            this.tb_G_Amount.ReadOnly = true;
            this.tb_G_Amount.Size = new System.Drawing.Size(121, 29);
            this.tb_G_Amount.TabIndex = 11;
            this.tb_G_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Discount.Location = new System.Drawing.Point(827, 18);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(83, 23);
            this.lbl_Discount.TabIndex = 18;
            this.lbl_Discount.Text = "Discount:";
            // 
            // tb_Discount
            // 
            this.tb_Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Discount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Discount.Location = new System.Drawing.Point(919, 15);
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(121, 29);
            this.tb_Discount.TabIndex = 13;
            this.tb_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Discount.TextChanged += new System.EventHandler(this.tb_Discount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(791, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total Amt:";
            // 
            // tb_Total_Amt
            // 
            this.tb_Total_Amt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Total_Amt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Total_Amt.Location = new System.Drawing.Point(918, 56);
            this.tb_Total_Amt.Name = "tb_Total_Amt";
            this.tb_Total_Amt.ReadOnly = true;
            this.tb_Total_Amt.Size = new System.Drawing.Size(121, 29);
            this.tb_Total_Amt.TabIndex = 14;
            this.tb_Total_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Unit2
            // 
            this.lbl_Unit2.AutoSize = true;
            this.lbl_Unit2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Unit2.Location = new System.Drawing.Point(365, 18);
            this.lbl_Unit2.Name = "lbl_Unit2";
            this.lbl_Unit2.Size = new System.Drawing.Size(45, 23);
            this.lbl_Unit2.TabIndex = 13;
            this.lbl_Unit2.Text = "Unit:";
            // 
            // tb_Unit2
            // 
            this.tb_Unit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Unit2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Unit2.Location = new System.Drawing.Point(416, 15);
            this.tb_Unit2.Name = "tb_Unit2";
            this.tb_Unit2.ReadOnly = true;
            this.tb_Unit2.Size = new System.Drawing.Size(121, 29);
            this.tb_Unit2.TabIndex = 10;
            this.tb_Unit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_Sale_Bill);
            this.panel3.Location = new System.Drawing.Point(0, 282);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 154);
            this.panel3.TabIndex = 4;
            // 
            // dgv_Sale_Bill
            // 
            this.dgv_Sale_Bill.AllowUserToDeleteRows = false;
            this.dgv_Sale_Bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Sale_Bill.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Sale_Bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Sale_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sale_Bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srno,
            this.Product,
            this.Expiry,
            this.unit,
            this.rate,
            this.gst,
            this.amount,
            this.totalamt});
            this.dgv_Sale_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Sale_Bill.Location = new System.Drawing.Point(0, 0);
            this.dgv_Sale_Bill.Name = "dgv_Sale_Bill";
            this.dgv_Sale_Bill.ReadOnly = true;
            this.dgv_Sale_Bill.Size = new System.Drawing.Size(1051, 154);
            this.dgv_Sale_Bill.TabIndex = 0;
            this.dgv_Sale_Bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sale_Bill_CellClick);
            // 
            // srno
            // 
            this.srno.HeaderText = "Sr_No";
            this.srno.Name = "srno";
            this.srno.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Expiry
            // 
            this.Expiry.HeaderText = "Expiry";
            this.Expiry.Name = "Expiry";
            this.Expiry.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // rate
            // 
            this.rate.HeaderText = "Rate";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // gst
            // 
            this.gst.HeaderText = "GST";
            this.gst.Name = "gst";
            this.gst.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // totalamt
            // 
            this.totalamt.HeaderText = "TotalAmt";
            this.totalamt.Name = "totalamt";
            this.totalamt.ReadOnly = true;
            // 
            // frm_Sale_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 541);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.p_Bottom);
            this.Controls.Add(this.p_Mid);
            this.Controls.Add(this.p_Up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Sale_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Bill";
            this.Load += new System.EventHandler(this.frm_Sale_Bill_Load);
            this.p_Up.ResumeLayout(false);
            this.p_Up.PerformLayout();
            this.p_Mid.ResumeLayout(false);
            this.p_Mid.PerformLayout();
            this.p_Bottom.ResumeLayout(false);
            this.p_Bottom.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sale_Bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Up;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Customer;
        private System.Windows.Forms.ComboBox cmb_Pay_Mode;
        private System.Windows.Forms.Label lbl_Pay_Mode;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.ComboBox cmb_Customer;
        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.TextBox tb_No;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.Panel p_Mid;
        private System.Windows.Forms.TextBox tb_Total_Amount;
        private System.Windows.Forms.Label lbl_TotalAmt;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.TextBox tb_SGst;
        private System.Windows.Forms.Label lbl_SGst;
        private System.Windows.Forms.TextBox tb_Rate;
        private System.Windows.Forms.Label lbl_Rate;
        private System.Windows.Forms.TextBox tb_Unit;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.DateTimePicker dtp_Expiry;
        private System.Windows.Forms.Label lbl_Expiry;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.ComboBox cmb_Product;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.Label lbl_Sr_No;
        private System.Windows.Forms.TextBox tb_Sr_No;
        private System.Windows.Forms.Panel p_Bottom;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label lbl_Gross_Amount;
        private System.Windows.Forms.TextBox tb_G_Amount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Total_Amt;
        private System.Windows.Forms.Label lbl_Unit2;
        private System.Windows.Forms.TextBox tb_Unit2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_Sale_Bill;
        private System.Windows.Forms.Button btn_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn srno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamt;

    }
}