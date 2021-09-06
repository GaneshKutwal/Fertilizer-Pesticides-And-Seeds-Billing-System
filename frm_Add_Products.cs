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
    public partial class frm_Add_Products : Form
    {
        public frm_Add_Products()
        {
            InitializeComponent();
        }

        Global_Fun GFobj = new Global_Fun();

        #region Form_Load

        private void frm_Add_Products_Load(object sender, EventArgs e)
        {
            tb_P_ID.Text = GFobj.AutoIncreament("select count(Product_Id) from product_Table", "Select Max(Product_Id) From Product_Table", 1001).ToString();

            tb_P_Name.Focus();

            //cmb_Category_Binding

            GFobj.ConnectDb();

            SqlCommand cmd = new SqlCommand("select Distinct(Category) From Category_Table ",GFobj.con);
            
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

        #region  Clear_Controls

        private void Clear_controls()
        {
            tb_P_ID.Text = "";
            tb_P_Name.Text = "";
            cmb_P_Category.Text = "";
            cmb_P_Supplier_Name.Text = "";
            tb_P_Purchase_Price.Text = "";
            tb_Gst.Text = "";
            tb_P_Sale_Price.Text = "";
        }
        #endregion


        #region   Char_Numberic_Function



        private void IS_NUMBERIC(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void IsNumberic(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void ISCHAR(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Category_Form

        private void btn_N_Click(object sender, EventArgs e)
        {
            Frm_Category Cobj = new Frm_Category();
            Cobj.Show();
        }

        #endregion

        #region Insert_Data

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if( tb_P_ID.Text != "" && tb_P_Name.Text !="" && tb_P_Purchase_Price.Text !="" && tb_P_Sale_Price.Text != "" && cmb_P_Category.Text != "" && cmb_P_Supplier_Name.Text != "" && tb_Gst.Text != "" )
            {
                GFobj.FillTableDB("Insert into Product_Table Values ('" + dtp_Date.Text + "'," + tb_P_ID.Text + ",'" + tb_P_Name.Text + "','" + cmb_P_Category.Text + "','" + cmb_P_Supplier_Name.Text + "'," + tb_P_Purchase_Price.Text + "," + tb_Gst.Text + "," + tb_P_Sale_Price.Text + ")");
                MessageBox.Show("Record Successfully Added","Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Clear_controls();


                tb_P_ID.Text = GFobj.AutoIncreament("select count(Product_Id) from Product_Table ","Select Max(Product_Id) From Product_Table",1001).ToString();
            }
            else
            {
                MessageBox.Show("1st Fill The All Fields !!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
        }

        #endregion

    }
}
