namespace Agriculture_Service_Center
{
    partial class frm_Purchase_Bill
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
            this.P_Up = new System.Windows.Forms.Panel();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.btn_N = new System.Windows.Forms.Button();
            this.cmb_Distrubutor = new System.Windows.Forms.ComboBox();
            this.lbl_Distrubutor = new System.Windows.Forms.Label();
            this.tb_No = new System.Windows.Forms.TextBox();
            this.lbl_No = new System.Windows.Forms.Label();
            this.p_Mid = new System.Windows.Forms.Panel();
            this.tb_P_Total_Amt = new System.Windows.Forms.TextBox();
            this.lbl_TotalAmt = new System.Windows.Forms.Label();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.tb_SGst = new System.Windows.Forms.TextBox();
            this.lbl_Gst = new System.Windows.Forms.Label();
            this.tb_Rate = new System.Windows.Forms.TextBox();
            this.lbl_Rate = new System.Windows.Forms.Label();
            this.tb_Unit = new System.Windows.Forms.TextBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.dtp_Expiry = new System.Windows.Forms.DateTimePicker();
            this.lbl_Expiry = new System.Windows.Forms.Label();
            this.btn_Material = new System.Windows.Forms.Button();
            this.cmb_Product = new System.Windows.Forms.ComboBox();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.lbl_Sr_No = new System.Windows.Forms.Label();
            this.tb_Sr_No = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_Purchase_Bill = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Unit2 = new System.Windows.Forms.TextBox();
            this.lbl_Unit2 = new System.Windows.Forms.Label();
            this.tb_Total_Amt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.tb_G_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Gross_Amount = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.p_Bottom = new System.Windows.Forms.Panel();
            this.P_Up.SuspendLayout();
            this.p_Mid.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Bill)).BeginInit();
            this.p_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_Up
            // 
            this.P_Up.BackColor = System.Drawing.Color.LightCyan;
            this.P_Up.Controls.Add(this.dtp_Date);
            this.P_Up.Controls.Add(this.lbl_Date);
            this.P_Up.Controls.Add(this.btn_N);
            this.P_Up.Controls.Add(this.cmb_Distrubutor);
            this.P_Up.Controls.Add(this.lbl_Distrubutor);
            this.P_Up.Controls.Add(this.tb_No);
            this.P_Up.Controls.Add(this.lbl_No);
            this.P_Up.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_Up.Location = new System.Drawing.Point(0, 0);
            this.P_Up.Name = "P_Up";
            this.P_Up.Size = new System.Drawing.Size(1051, 85);
            this.P_Up.TabIndex = 0;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(879, 21);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(161, 29);
            this.dtp_Date.TabIndex = 17;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.Location = new System.Drawing.Point(824, 24);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(49, 23);
            this.lbl_Date.TabIndex = 16;
            this.lbl_Date.Text = "Date:";
            // 
            // btn_N
            // 
            this.btn_N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_N.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_N.Location = new System.Drawing.Point(671, 21);
            this.btn_N.Name = "btn_N";
            this.btn_N.Size = new System.Drawing.Size(35, 31);
            this.btn_N.TabIndex = 15;
            this.btn_N.Text = "...";
            this.btn_N.UseVisualStyleBackColor = true;
            this.btn_N.Click += new System.EventHandler(this.btn_N_Click_1);
            // 
            // cmb_Distrubutor
            // 
            this.cmb_Distrubutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Distrubutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Distrubutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Distrubutor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmb_Distrubutor.FormattingEnabled = true;
            this.cmb_Distrubutor.Location = new System.Drawing.Point(350, 21);
            this.cmb_Distrubutor.Name = "cmb_Distrubutor";
            this.cmb_Distrubutor.Size = new System.Drawing.Size(310, 31);
            this.cmb_Distrubutor.TabIndex = 2;
            // 
            // lbl_Distrubutor
            // 
            this.lbl_Distrubutor.AutoSize = true;
            this.lbl_Distrubutor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Distrubutor.Location = new System.Drawing.Point(221, 24);
            this.lbl_Distrubutor.Name = "lbl_Distrubutor";
            this.lbl_Distrubutor.Size = new System.Drawing.Size(110, 23);
            this.lbl_Distrubutor.TabIndex = 13;
            this.lbl_Distrubutor.Text = "Distrubutors:";
            // 
            // tb_No
            // 
            this.tb_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_No.Enabled = false;
            this.tb_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_No.Location = new System.Drawing.Point(54, 23);
            this.tb_No.Name = "tb_No";
            this.tb_No.Size = new System.Drawing.Size(91, 29);
            this.tb_No.TabIndex = 1;
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_No.Location = new System.Drawing.Point(12, 24);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(36, 23);
            this.lbl_No.TabIndex = 2;
            this.lbl_No.Text = "No:";
            // 
            // p_Mid
            // 
            this.p_Mid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p_Mid.BackColor = System.Drawing.Color.LightCyan;
            this.p_Mid.Controls.Add(this.tb_P_Total_Amt);
            this.p_Mid.Controls.Add(this.lbl_TotalAmt);
            this.p_Mid.Controls.Add(this.tb_Amount);
            this.p_Mid.Controls.Add(this.lbl_Amount);
            this.p_Mid.Controls.Add(this.tb_SGst);
            this.p_Mid.Controls.Add(this.lbl_Gst);
            this.p_Mid.Controls.Add(this.tb_Rate);
            this.p_Mid.Controls.Add(this.lbl_Rate);
            this.p_Mid.Controls.Add(this.tb_Unit);
            this.p_Mid.Controls.Add(this.lbl_Unit);
            this.p_Mid.Controls.Add(this.dtp_Expiry);
            this.p_Mid.Controls.Add(this.lbl_Expiry);
            this.p_Mid.Controls.Add(this.btn_Material);
            this.p_Mid.Controls.Add(this.cmb_Product);
            this.p_Mid.Controls.Add(this.lbl_Product);
            this.p_Mid.Controls.Add(this.lbl_Sr_No);
            this.p_Mid.Controls.Add(this.tb_Sr_No);
            this.p_Mid.Location = new System.Drawing.Point(0, 91);
            this.p_Mid.Name = "p_Mid";
            this.p_Mid.Size = new System.Drawing.Size(1051, 150);
            this.p_Mid.TabIndex = 1;
            // 
            // tb_P_Total_Amt
            // 
            this.tb_P_Total_Amt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_P_Total_Amt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_P_Total_Amt.Location = new System.Drawing.Point(918, 105);
            this.tb_P_Total_Amt.Name = "tb_P_Total_Amt";
            this.tb_P_Total_Amt.ReadOnly = true;
            this.tb_P_Total_Amt.Size = new System.Drawing.Size(121, 29);
            this.tb_P_Total_Amt.TabIndex = 9;
            this.tb_P_Total_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_P_Total_Amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_P_Total_Amt_KeyPress);
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
            // lbl_Gst
            // 
            this.lbl_Gst.AutoSize = true;
            this.lbl_Gst.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Gst.Location = new System.Drawing.Point(968, 11);
            this.lbl_Gst.Name = "lbl_Gst";
            this.lbl_Gst.Size = new System.Drawing.Size(51, 23);
            this.lbl_Gst.TabIndex = 22;
            this.lbl_Gst.Text = "SGst:";
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
            this.tb_Unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IS_Numberic);
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
            // btn_Material
            // 
            this.btn_Material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Material.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Material.Location = new System.Drawing.Point(418, 35);
            this.btn_Material.Name = "btn_Material";
            this.btn_Material.Size = new System.Drawing.Size(35, 31);
            this.btn_Material.TabIndex = 15;
            this.btn_Material.Text = "...";
            this.btn_Material.UseVisualStyleBackColor = true;
            this.btn_Material.Click += new System.EventHandler(this.btn_Material_Click);
            // 
            // cmb_Product
            // 
            this.cmb_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Product.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmb_Product.FormattingEnabled = true;
            this.cmb_Product.Location = new System.Drawing.Point(141, 35);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_Purchase_Bill);
            this.panel3.Location = new System.Drawing.Point(0, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 188);
            this.panel3.TabIndex = 3;
            // 
            // dgv_Purchase_Bill
            // 
            this.dgv_Purchase_Bill.AllowUserToDeleteRows = false;
            this.dgv_Purchase_Bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Purchase_Bill.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Purchase_Bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Purchase_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Purchase_Bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.product,
            this.expiry,
            this.unit,
            this.rate,
            this.gst,
            this.amount,
            this.totalamt});
            this.dgv_Purchase_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Purchase_Bill.GridColor = System.Drawing.Color.DarkGray;
            this.dgv_Purchase_Bill.Location = new System.Drawing.Point(0, 0);
            this.dgv_Purchase_Bill.Name = "dgv_Purchase_Bill";
            this.dgv_Purchase_Bill.ReadOnly = true;
            this.dgv_Purchase_Bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Purchase_Bill.Size = new System.Drawing.Size(1051, 188);
            this.dgv_Purchase_Bill.TabIndex = 0;
            this.dgv_Purchase_Bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Purchase_Bill_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Sr_No.";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // expiry
            // 
            this.expiry.HeaderText = "Expiry";
            this.expiry.Name = "expiry";
            this.expiry.ReadOnly = true;
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
            this.gst.HeaderText = "Gst";
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
            // tb_Unit2
            // 
            this.tb_Unit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Unit2.Enabled = false;
            this.tb_Unit2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Unit2.Location = new System.Drawing.Point(416, 15);
            this.tb_Unit2.Name = "tb_Unit2";
            this.tb_Unit2.ReadOnly = true;
            this.tb_Unit2.Size = new System.Drawing.Size(121, 29);
            this.tb_Unit2.TabIndex = 10;
            this.tb_Unit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // tb_Total_Amt
            // 
            this.tb_Total_Amt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Total_Amt.Enabled = false;
            this.tb_Total_Amt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Total_Amt.Location = new System.Drawing.Point(918, 56);
            this.tb_Total_Amt.Name = "tb_Total_Amt";
            this.tb_Total_Amt.ReadOnly = true;
            this.tb_Total_Amt.Size = new System.Drawing.Size(121, 29);
            this.tb_Total_Amt.TabIndex = 14;
            this.tb_Total_Amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // tb_G_Amount
            // 
            this.tb_G_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_G_Amount.Enabled = false;
            this.tb_G_Amount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_G_Amount.Location = new System.Drawing.Point(687, 15);
            this.tb_G_Amount.Name = "tb_G_Amount";
            this.tb_G_Amount.ReadOnly = true;
            this.tb_G_Amount.Size = new System.Drawing.Size(121, 29);
            this.tb_G_Amount.TabIndex = 11;
            this.tb_G_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.p_Bottom.TabIndex = 2;
            // 
            // frm_Purchase_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1051, 541);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.p_Bottom);
            this.Controls.Add(this.p_Mid);
            this.Controls.Add(this.P_Up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Purchase_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Bill";
            this.Load += new System.EventHandler(this.frm_Purchase_Bill_Load);
            this.P_Up.ResumeLayout(false);
            this.P_Up.PerformLayout();
            this.p_Mid.ResumeLayout(false);
            this.p_Mid.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Bill)).EndInit();
            this.p_Bottom.ResumeLayout(false);
            this.p_Bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_Up;
        private System.Windows.Forms.TextBox tb_No;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Button btn_N;
        private System.Windows.Forms.ComboBox cmb_Distrubutor;
        private System.Windows.Forms.Label lbl_Distrubutor;
        private System.Windows.Forms.Panel p_Mid;
        private System.Windows.Forms.TextBox tb_SGst;
        private System.Windows.Forms.Label lbl_Gst;
        private System.Windows.Forms.TextBox tb_Rate;
        private System.Windows.Forms.Label lbl_Rate;
        private System.Windows.Forms.TextBox tb_Unit;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.DateTimePicker dtp_Expiry;
        private System.Windows.Forms.Label lbl_Expiry;
        private System.Windows.Forms.Button btn_Material;
        private System.Windows.Forms.ComboBox cmb_Product;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.Label lbl_Sr_No;
        private System.Windows.Forms.TextBox tb_Sr_No;
        private System.Windows.Forms.TextBox tb_P_Total_Amt;
        private System.Windows.Forms.Label lbl_TotalAmt;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_Purchase_Bill;
        private System.Windows.Forms.TextBox tb_Unit2;
        private System.Windows.Forms.Label lbl_Unit2;
        private System.Windows.Forms.TextBox tb_Total_Amt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.TextBox tb_G_Amount;
        private System.Windows.Forms.Label lbl_Gross_Amount;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Panel p_Bottom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamt;

    }
}