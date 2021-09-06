namespace Agriculture_Service_Center
{
    partial class MDI_Agriculture_Service_Center
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Agriculture_Service_Center));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MDI_Employee = new System.Windows.Forms.MenuStrip();
            this.Mdi_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdi_New_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdi_Update_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.showProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdi_Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdi_New_Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdi_Update_Customer_Details = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdi_Show_Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdi_New_Suppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdi_Update_Supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdi_Show_Suppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.purchaseBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellesBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReturnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdi_Expences = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdi_Calculator = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdi_Notepad = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateWiseCustomerSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyCustomerTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyExpencesDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateWiseProductDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlySupplierPusrchaseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MDI_Employee.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MDI_Employee
            // 
            this.MDI_Employee.BackColor = System.Drawing.Color.PaleGreen;
            this.MDI_Employee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mdi_Product,
            this.Mdi_Customers,
            this.suppliersToolStripMenuItem,
            this.eToolStripMenuItem});
            this.MDI_Employee.Location = new System.Drawing.Point(0, 24);
            this.MDI_Employee.Name = "MDI_Employee";
            this.MDI_Employee.Size = new System.Drawing.Size(1350, 24);
            this.MDI_Employee.TabIndex = 1;
            this.MDI_Employee.Text = "Product";
            // 
            // Mdi_Product
            // 
            this.Mdi_Product.BackColor = System.Drawing.Color.PaleGreen;
            this.Mdi_Product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mdi_New_Product,
            this.Mdi_Update_Product,
            this.showProductsToolStripMenuItem});
            this.Mdi_Product.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mdi_Product.Name = "Mdi_Product";
            this.Mdi_Product.Size = new System.Drawing.Size(115, 20);
            this.Mdi_Product.Text = "Product Master";
            // 
            // Mdi_New_Product
            // 
            this.Mdi_New_Product.BackColor = System.Drawing.Color.SpringGreen;
            this.Mdi_New_Product.Name = "Mdi_New_Product";
            this.Mdi_New_Product.Size = new System.Drawing.Size(174, 22);
            this.Mdi_New_Product.Text = "Add Product";
            this.Mdi_New_Product.Click += new System.EventHandler(this.Mdi_New_Product_Click);
            // 
            // Mdi_Update_Product
            // 
            this.Mdi_Update_Product.BackColor = System.Drawing.Color.SpringGreen;
            this.Mdi_Update_Product.Name = "Mdi_Update_Product";
            this.Mdi_Update_Product.Size = new System.Drawing.Size(174, 22);
            this.Mdi_Update_Product.Text = "Update Product";
            this.Mdi_Update_Product.Click += new System.EventHandler(this.Mdi_Update_Product_Click);
            // 
            // showProductsToolStripMenuItem
            // 
            this.showProductsToolStripMenuItem.BackColor = System.Drawing.Color.SpringGreen;
            this.showProductsToolStripMenuItem.Name = "showProductsToolStripMenuItem";
            this.showProductsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.showProductsToolStripMenuItem.Text = "Show Products";
            this.showProductsToolStripMenuItem.Click += new System.EventHandler(this.showProductsToolStripMenuItem_Click);
            // 
            // Mdi_Customers
            // 
            this.Mdi_Customers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mdi_New_Customers,
            this.Mdi_Update_Customer_Details,
            this.Mdi_Show_Customers});
            this.Mdi_Customers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Mdi_Customers.Name = "Mdi_Customers";
            this.Mdi_Customers.Size = new System.Drawing.Size(132, 20);
            this.Mdi_Customers.Text = "Customers Master";
            // 
            // Mdi_New_Customers
            // 
            this.Mdi_New_Customers.BackColor = System.Drawing.Color.SpringGreen;
            this.Mdi_New_Customers.Name = "Mdi_New_Customers";
            this.Mdi_New_Customers.Size = new System.Drawing.Size(189, 22);
            this.Mdi_New_Customers.Text = "New Customers";
            this.Mdi_New_Customers.Click += new System.EventHandler(this.Mdi_New_Customers_Click);
            // 
            // Mdi_Update_Customer_Details
            // 
            this.Mdi_Update_Customer_Details.BackColor = System.Drawing.Color.SpringGreen;
            this.Mdi_Update_Customer_Details.Name = "Mdi_Update_Customer_Details";
            this.Mdi_Update_Customer_Details.Size = new System.Drawing.Size(189, 22);
            this.Mdi_Update_Customer_Details.Text = "Update Customer ";
            this.Mdi_Update_Customer_Details.Click += new System.EventHandler(this.Mdi_Update_Customer_Details_Click);
            // 
            // Mdi_Show_Customers
            // 
            this.Mdi_Show_Customers.BackColor = System.Drawing.Color.SpringGreen;
            this.Mdi_Show_Customers.Name = "Mdi_Show_Customers";
            this.Mdi_Show_Customers.Size = new System.Drawing.Size(189, 22);
            this.Mdi_Show_Customers.Text = "Show Customers";
            this.Mdi_Show_Customers.Click += new System.EventHandler(this.Mdi_Show_Customers_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mdi_New_Suppliers,
            this.Mdi_Update_Supplier,
            this.Mdi_Show_Suppliers});
            this.suppliersToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.suppliersToolStripMenuItem.Text = "Suppliers Master";
            // 
            // Mdi_New_Suppliers
            // 
            this.Mdi_New_Suppliers.BackColor = System.Drawing.Color.SpringGreen;
            this.Mdi_New_Suppliers.Name = "Mdi_New_Suppliers";
            this.Mdi_New_Suppliers.Size = new System.Drawing.Size(179, 22);
            this.Mdi_New_Suppliers.Text = "New Suppliers";
            this.Mdi_New_Suppliers.Click += new System.EventHandler(this.Mdi_New_Suppliers_Click);
            // 
            // Mdi_Update_Supplier
            // 
            this.Mdi_Update_Supplier.BackColor = System.Drawing.Color.SpringGreen;
            this.Mdi_Update_Supplier.Name = "Mdi_Update_Supplier";
            this.Mdi_Update_Supplier.Size = new System.Drawing.Size(179, 22);
            this.Mdi_Update_Supplier.Text = "Update Supplier";
            this.Mdi_Update_Supplier.Click += new System.EventHandler(this.Mdi_Update_Supplier_Click);
            // 
            // Mdi_Show_Suppliers
            // 
            this.Mdi_Show_Suppliers.BackColor = System.Drawing.Color.SpringGreen;
            this.Mdi_Show_Suppliers.Name = "Mdi_Show_Suppliers";
            this.Mdi_Show_Suppliers.Size = new System.Drawing.Size(179, 22);
            this.Mdi_Show_Suppliers.Text = "Show Suppliers";
            this.Mdi_Show_Suppliers.Click += new System.EventHandler(this.Mdi_Show_Suppliers_Click);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.updateEmployeeToolStripMenuItem,
            this.viewEmployeeToolStripMenuItem});
            this.eToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.eToolStripMenuItem.Text = "Employee Master";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.SpringGreen;
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.SpringGreen;
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.updateEmployeeToolStripMenuItem.Text = "Update Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // viewEmployeeToolStripMenuItem
            // 
            this.viewEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.SpringGreen;
            this.viewEmployeeToolStripMenuItem.Name = "viewEmployeeToolStripMenuItem";
            this.viewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.viewEmployeeToolStripMenuItem.Text = "View Employee";
            this.viewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseBillToolStripMenuItem,
            this.sellesBillToolStripMenuItem,
            this.salesReturnsToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.Mdi_Expences,
            this.Mdi_Calculator,
            this.Mdi_Notepad,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // purchaseBillToolStripMenuItem
            // 
            this.purchaseBillToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.purchaseBillToolStripMenuItem.Name = "purchaseBillToolStripMenuItem";
            this.purchaseBillToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.purchaseBillToolStripMenuItem.Text = "Purchase Bill";
            this.purchaseBillToolStripMenuItem.Click += new System.EventHandler(this.purchaseBillToolStripMenuItem_Click);
            // 
            // sellesBillToolStripMenuItem
            // 
            this.sellesBillToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.sellesBillToolStripMenuItem.Name = "sellesBillToolStripMenuItem";
            this.sellesBillToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.sellesBillToolStripMenuItem.Text = "Selles Bill";
            this.sellesBillToolStripMenuItem.Click += new System.EventHandler(this.sellesBillToolStripMenuItem_Click);
            // 
            // salesReturnsToolStripMenuItem
            // 
            this.salesReturnsToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.salesReturnsToolStripMenuItem.Name = "salesReturnsToolStripMenuItem";
            this.salesReturnsToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.salesReturnsToolStripMenuItem.Text = "Sales Returns";
            this.salesReturnsToolStripMenuItem.Click += new System.EventHandler(this.salesReturnsToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseStockToolStripMenuItem,
            this.sellStockToolStripMenuItem,
            this.availableStockToolStripMenuItem});
            this.stockToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.stockToolStripMenuItem.Text = "Stock Master";
            // 
            // purchaseStockToolStripMenuItem
            // 
            this.purchaseStockToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.purchaseStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierStockToolStripMenuItem,
            this.productStockToolStripMenuItem,
            this.sellReturnToolStripMenuItem});
            this.purchaseStockToolStripMenuItem.Name = "purchaseStockToolStripMenuItem";
            this.purchaseStockToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.purchaseStockToolStripMenuItem.Text = "Purchase Stock";
            // 
            // supplierStockToolStripMenuItem
            // 
            this.supplierStockToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.supplierStockToolStripMenuItem.Name = "supplierStockToolStripMenuItem";
            this.supplierStockToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.supplierStockToolStripMenuItem.Text = "Supplier Stock";
            this.supplierStockToolStripMenuItem.Click += new System.EventHandler(this.supplierStockToolStripMenuItem_Click);
            // 
            // productStockToolStripMenuItem
            // 
            this.productStockToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.productStockToolStripMenuItem.Name = "productStockToolStripMenuItem";
            this.productStockToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.productStockToolStripMenuItem.Text = "Product Stock";
            this.productStockToolStripMenuItem.Click += new System.EventHandler(this.productStockToolStripMenuItem_Click);
            // 
            // sellReturnToolStripMenuItem
            // 
            this.sellReturnToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.sellReturnToolStripMenuItem.Name = "sellReturnToolStripMenuItem";
            this.sellReturnToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.sellReturnToolStripMenuItem.Text = "Sell Return";
            this.sellReturnToolStripMenuItem.Click += new System.EventHandler(this.sellReturnToolStripMenuItem_Click);
            // 
            // sellStockToolStripMenuItem
            // 
            this.sellStockToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.sellStockToolStripMenuItem.Name = "sellStockToolStripMenuItem";
            this.sellStockToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sellStockToolStripMenuItem.Text = "Sell Stock";
            this.sellStockToolStripMenuItem.Click += new System.EventHandler(this.sellStockToolStripMenuItem_Click);
            // 
            // availableStockToolStripMenuItem
            // 
            this.availableStockToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.availableStockToolStripMenuItem.Name = "availableStockToolStripMenuItem";
            this.availableStockToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.availableStockToolStripMenuItem.Text = "Available Stock";
            this.availableStockToolStripMenuItem.Click += new System.EventHandler(this.availableStockToolStripMenuItem_Click);
            // 
            // Mdi_Expences
            // 
            this.Mdi_Expences.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Mdi_Expences.Name = "Mdi_Expences";
            this.Mdi_Expences.Size = new System.Drawing.Size(81, 20);
            this.Mdi_Expences.Text = "Expences";
            this.Mdi_Expences.Click += new System.EventHandler(this.Mdi_Expences_Click_1);
            // 
            // Mdi_Calculator
            // 
            this.Mdi_Calculator.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Mdi_Calculator.Name = "Mdi_Calculator";
            this.Mdi_Calculator.Size = new System.Drawing.Size(85, 20);
            this.Mdi_Calculator.Text = "Calculator";
            this.Mdi_Calculator.Click += new System.EventHandler(this.Mdi_Calculator_Click_1);
            // 
            // Mdi_Notepad
            // 
            this.Mdi_Notepad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Mdi_Notepad.Name = "Mdi_Notepad";
            this.Mdi_Notepad.Size = new System.Drawing.Size(73, 20);
            this.Mdi_Notepad.Text = "Notepad";
            this.Mdi_Notepad.Click += new System.EventHandler(this.Mdi_Notepad_Click_1);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateWiseCustomerSaleToolStripMenuItem,
            this.monthlyCustomerTotalToolStripMenuItem,
            this.monthlyExpencesDetailsToolStripMenuItem,
            this.dateWiseProductDetailsToolStripMenuItem,
            this.monthlySupplierPusrchaseDetailsToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1350, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dateWiseCustomerSaleToolStripMenuItem
            // 
            this.dateWiseCustomerSaleToolStripMenuItem.Name = "dateWiseCustomerSaleToolStripMenuItem";
            this.dateWiseCustomerSaleToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
            this.dateWiseCustomerSaleToolStripMenuItem.Text = "Date Wise Customer Sale Produc Detailst";
            this.dateWiseCustomerSaleToolStripMenuItem.Click += new System.EventHandler(this.dateWiseCustomerSaleToolStripMenuItem_Click);
            // 
            // monthlyCustomerTotalToolStripMenuItem
            // 
            this.monthlyCustomerTotalToolStripMenuItem.Name = "monthlyCustomerTotalToolStripMenuItem";
            this.monthlyCustomerTotalToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
            this.monthlyCustomerTotalToolStripMenuItem.Text = "Monthly Customer Total Sale Bill Details";
            this.monthlyCustomerTotalToolStripMenuItem.Click += new System.EventHandler(this.monthlyCustomerTotalToolStripMenuItem_Click);
            // 
            // monthlyExpencesDetailsToolStripMenuItem
            // 
            this.monthlyExpencesDetailsToolStripMenuItem.Name = "monthlyExpencesDetailsToolStripMenuItem";
            this.monthlyExpencesDetailsToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
            this.monthlyExpencesDetailsToolStripMenuItem.Text = "Monthly Expences Details";
            this.monthlyExpencesDetailsToolStripMenuItem.Click += new System.EventHandler(this.monthlyExpencesDetailsToolStripMenuItem_Click);
            // 
            // dateWiseProductDetailsToolStripMenuItem
            // 
            this.dateWiseProductDetailsToolStripMenuItem.Name = "dateWiseProductDetailsToolStripMenuItem";
            this.dateWiseProductDetailsToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
            this.dateWiseProductDetailsToolStripMenuItem.Text = "Date Wise Product Details";
            this.dateWiseProductDetailsToolStripMenuItem.Click += new System.EventHandler(this.dateWiseProductDetailsToolStripMenuItem_Click);
            // 
            // monthlySupplierPusrchaseDetailsToolStripMenuItem
            // 
            this.monthlySupplierPusrchaseDetailsToolStripMenuItem.Name = "monthlySupplierPusrchaseDetailsToolStripMenuItem";
            this.monthlySupplierPusrchaseDetailsToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
            this.monthlySupplierPusrchaseDetailsToolStripMenuItem.Text = "Monthly Supplier Pusrchase Details";
            this.monthlySupplierPusrchaseDetailsToolStripMenuItem.Click += new System.EventHandler(this.monthlySupplierPusrchaseDetailsToolStripMenuItem_Click);
            // 
            // MDI_Agriculture_Service_Center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MDI_Employee);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MDI_Employee;
            this.MaximizeBox = false;
            this.Name = "MDI_Agriculture_Service_Center";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agriculture Service Center";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MDI_Employee.ResumeLayout(false);
            this.MDI_Employee.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip MDI_Employee;
        private System.Windows.Forms.ToolStripMenuItem Mdi_Product;
        private System.Windows.Forms.ToolStripMenuItem Mdi_New_Product;
        private System.Windows.Forms.ToolStripMenuItem Mdi_Update_Product;
        private System.Windows.Forms.ToolStripMenuItem showProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mdi_Customers;
        private System.Windows.Forms.ToolStripMenuItem Mdi_New_Customers;
        private System.Windows.Forms.ToolStripMenuItem Mdi_Update_Customer_Details;
        private System.Windows.Forms.ToolStripMenuItem Mdi_Show_Customers;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mdi_New_Suppliers;
        private System.Windows.Forms.ToolStripMenuItem Mdi_Update_Supplier;
        private System.Windows.Forms.ToolStripMenuItem Mdi_Show_Suppliers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem purchaseBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellesBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReturnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellStockToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem availableStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mdi_Expences;
        private System.Windows.Forms.ToolStripMenuItem Mdi_Calculator;
        private System.Windows.Forms.ToolStripMenuItem Mdi_Notepad;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateWiseCustomerSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyCustomerTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyExpencesDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateWiseProductDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlySupplierPusrchaseDetailsToolStripMenuItem;
    }
}



