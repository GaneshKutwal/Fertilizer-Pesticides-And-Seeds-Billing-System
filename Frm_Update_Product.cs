using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Agriculture_Service_Center
{
    public partial class Frm_Update_Product : Form
    {
        public Frm_Update_Product()
        {
            InitializeComponent();
        }

        Global_Fun GFobj = new Global_Fun();

        #region Control_Clear_Disabled_Enabled

        private void Clear_Controls()
        {
            tb_P_id.Text = "";
            tb_P_Name.Text = "";
            cmb_P_Category.Text = "";
            cmb_P_Supplier_Name.Text = "";
            tb_P_Purchase_Price.Text = "";
            tb_Gst.Text = "";
            tb_P_Sales_Price.Text = "";
        }

        
        private void Control_Disabled()
        {
            tb_P_Name.Enabled = false;
            cmb_P_Category.Enabled = false;
            cmb_P_Supplier_Name.Enabled = false;
            tb_P_Purchase_Price.Enabled = false;
            tb_Gst.Enabled = false;
            tb_P_Sales_Price.Enabled = false;
        }

        private void Control_Enabled()
        {
            tb_P_Name.Enabled = true;
            cmb_P_Category.Enabled = true;
            cmb_P_Supplier_Name.Enabled = true;
            tb_P_Purchase_Price.Enabled = true;
            tb_Gst.Enabled = true;
            tb_P_Sales_Price.Enabled = true;
        }

        #endregion

        #region  Char_Numberic_Function

        private void IsNumberic(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void ISchar(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        #endregion  

        #region Form_Load

        private void Frm_Update_Product_Load(object sender, EventArgs e)
        {
            Control_Disabled();

            //cmb_Category_Binding

            GFobj.ConnectDb();

            SqlCommand cmd = new SqlCommand("select Distinct(Category) From Category_Table ", GFobj.con);

            var obj = cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_P_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category")));
            }

            obj.Dispose();

            //cmb_Supplier_Name_Binding

            SqlCommand Scmd = new SqlCommand("select Distinct(Name) From Supplier_Table", GFobj.con);

            var Sobj = Scmd.ExecuteReader();

            while (Sobj.Read())
            {
                cmb_P_Supplier_Name.Items.Add(Sobj.GetString(Sobj.GetOrdinal("Name")));
            }

            Sobj.Dispose();


        }

        #endregion

        #region  Category_Form_Open

        private void btn_N_Click(object sender, EventArgs e)
        {
            Frm_Category obj = new Frm_Category();
            obj.Show();
        }

        #endregion

        #region  Update_Function

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if(tb_P_Name.Text != "" && cmb_P_Category.Text != "" && cmb_P_Supplier_Name.Text != "" && tb_P_Purchase_Price.Text != "" && tb_P_Sales_Price.Text != "" )
            {
                GFobj.Update_Table("Update Product_Table set Date = '" + dtp_P_Date.Text + "', Name = '" + tb_P_Name.Text + "', Category = '" + cmb_P_Category.Text + "', Supplier_Name = '" + cmb_P_Supplier_Name.Text + "', Purchase_Price = " + tb_P_Purchase_Price.Text + ", Sell_Price = " + tb_P_Sales_Price.Text + " where Product_Id = " + tb_P_id.Text + " ");

                MessageBox.Show("Record Updated Successfully ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_P_id.Enabled = true;
                tb_P_id.Text = "";
                tb_P_id.Focus();
                Clear_Controls();
                Control_Disabled();



            }
            else
            {
                MessageBox.Show("1st Fill The All Fields !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_P_id.Text = "";
                tb_P_id.Focus();
            }
        }

        #endregion

        #region Search_Function

        private void btn_Search_Click(object sender, EventArgs e)
        {
          
            if (tb_P_id.Text != "")
            {
                GFobj.ConnectDb();

                SqlCommand cmd = new SqlCommand("Select * from Product_Table Where Product_Id = " + tb_P_id.Text + " ",GFobj.con);
                var obj = cmd.ExecuteReader();

                if(obj.Read())
                {
                    dtp_P_Date.Text = (obj["Date"].ToString());
                    tb_P_Name.Text =  (obj.GetString(obj.GetOrdinal("Name")));
                    cmb_P_Category.Text = (obj.GetString(obj.GetOrdinal("Category")));
                    cmb_P_Supplier_Name.Text = (obj.GetString(obj.GetOrdinal("Supplier_Name")));
                    tb_P_Purchase_Price.Text = (obj["Purchase_Price"].ToString());
                    tb_Gst.Text = (obj["GST"].ToString());
                    tb_P_Sales_Price.Text = (obj["Sell_Price"].ToString());
                   

                    tb_P_id.Enabled = false;
                    Control_Enabled();

                    GFobj.DisconnectDb();
                    
                }
                else
                {
                    MessageBox.Show("Information Not Found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    tb_P_id.Text = "";
                    tb_P_id.Focus();    
                }
               



            }
            else
            {
                MessageBox.Show("Please Enter A Product Id");
                tb_P_id.Text = "";
                tb_P_id.Focus();
            }
        }

        #endregion

       

    }
}
