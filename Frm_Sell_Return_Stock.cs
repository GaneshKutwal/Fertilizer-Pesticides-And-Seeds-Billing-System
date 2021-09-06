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
    public partial class Frm_Sell_Return_Stock : Form
    {
        public Frm_Sell_Return_Stock()
        {
            InitializeComponent();
        }

        Global_Fun GFobj = new Global_Fun();

        #region Load_Form

        private void Frm_Sell_Return_Stock_Load(object sender, EventArgs e)
        {
            GFobj.FillDataGridView("Select * from Sales_Return_Table ", dgv_Sales_Return_Stock);
        }

        #endregion

        #region Show

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            if(tb_C_Name.Text != "")
            {
            GFobj.ConnectDb();

            SqlDataAdapter sda = new SqlDataAdapter("select * from Customer_Sale_Product_Table where Customer = '" + tb_C_Name.Text + "'  ", GFobj.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Sales_Return_Stock.DataSource = dt;

            GFobj.DisconnectDb();
            }
            else
            {
               MessageBox.Show("Please Enter Customer Name !!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
