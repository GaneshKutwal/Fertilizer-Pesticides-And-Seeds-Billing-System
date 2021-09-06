using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agriculture_Service_Center
{
    public partial class MDI_Agriculture_Service_Center : Form
    {
        private int childFormNumber = 0;

        public MDI_Agriculture_Service_Center()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

       

        private void Mdi_New_Product_Click(object sender, EventArgs e)
        {
            frm_Add_Products Aobj = new frm_Add_Products();
            Aobj.Show();
           
        }

        private void sellesBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sale_Bill SBobj = new frm_Sale_Bill();
            SBobj.Show();
        }

        private void Mdi_Update_Product_Click(object sender, EventArgs e)
        {
            Frm_Update_Product UPobj = new Frm_Update_Product();
            UPobj.Show();

        }

        private void showProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Show_Products SPobj = new frm_Show_Products();
            SPobj.Show();

        }

        private void Mdi_New_Customers_Click(object sender, EventArgs e)
        {
           frm_New_Customers NCobj = new frm_New_Customers();
           NCobj.Show();
        }

        private void Mdi_Update_Customer_Details_Click(object sender, EventArgs e)
        {
            frm_Update_Customer UCobj = new  frm_Update_Customer();
            UCobj.Show();
        }

        private void Mdi_Show_Customers_Click(object sender, EventArgs e)
        {
            Frm_Show_Customer SCobj = new Frm_Show_Customer ();
            SCobj.Show();
        }

        private void Mdi_New_Suppliers_Click(object sender, EventArgs e)
        {
            frm_New_Supplier NSobj = new frm_New_Supplier();
            NSobj.Show();
        }

        private void purchaseBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Purchase_Bill PBobj = new frm_Purchase_Bill();
            PBobj.Show();
        }

        private void Mdi_Update_Supplier_Click(object sender, EventArgs e)
        {
            Frm_Update_Supplier USobj = new Frm_Update_Supplier ();
            USobj.Show();
        }

        private void Mdi_Show_Suppliers_Click(object sender, EventArgs e)
        {
            frm_Show_Supplier SSobj = new frm_Show_Supplier();
            SSobj.Show();
        }

        

        private void salesReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sales_Return SRobj = new frm_Sales_Return();
            SRobj.Show();
        }

       
        private void sellStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sell_Stock SSobj = new Frm_Sell_Stock();
            SSobj.Show();
        }

        private void availableStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Available_Stock ASobj = new frm_Available_Stock();
            ASobj.Show();
        }

        private void supplierStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Supplier_Stock SS = new Frm_Supplier_Stock();
            SS.Show();
        }

        private void productStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Purchase_Stock PS = new Frm_Purchase_Stock();
            PS.Show();
        }

        private void sellReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sell_Return_Stock SRS = new Frm_Sell_Return_Stock();
            SRS.Show();

        }

        private void Mdi_Expences_Click_1(object sender, EventArgs e)
        {
            frm_Expences FE = new frm_Expences();
            FE.Show();
        }

        private void Mdi_Calculator_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");

        }

        private void Mdi_Notepad_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Employee AE = new Frm_Add_Employee();
            AE.Show();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Update_Employee UE = new Frm_Update_Employee();
            UE.Show();
        }

        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Show_Employee SE = new Frm_Show_Employee();
            SE.Show();
        }

        private void dateWiseCustomerSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrystalReportForm.frm_Datewise_Customer_Sale_Product SE = new CrystalReportForm.frm_Datewise_Customer_Sale_Product();
            SE.Show();
        }

        private void monthlyCustomerTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrystalReportForm.frm_Monthly_Customer_Total_Sale_Bill SE = new CrystalReportForm.frm_Monthly_Customer_Total_Sale_Bill();
            SE.Show();
        }

        private void monthlyExpencesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrystalReportForm.frm_Monthly_Expences_Details SE = new CrystalReportForm.frm_Monthly_Expences_Details();
            SE.Show();
        }

        private void dateWiseProductDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrystalReportForm.frm_Datewise_Product_Details SE = new CrystalReportForm.frm_Datewise_Product_Details();
            SE.Show();
        }

        private void monthlySupplierPusrchaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrystalReportForm.frm_Monthly_Supplier_Purchase SE = new CrystalReportForm.frm_Monthly_Supplier_Purchase();
            SE.Show();
        }

      


       

       

    }
}
