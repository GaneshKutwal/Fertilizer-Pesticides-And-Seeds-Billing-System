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
    public partial class Frm_Sell_Stock : Form
    {
        public Frm_Sell_Stock()
        {
            InitializeComponent();
        }

        Global_Fun GFOBJ = new Global_Fun();

        #region Load_Form

        private void Frm_Sell_Stock_Load(object sender, EventArgs e)
        {
            GFOBJ.FillDataGridView("Select * from Customer_Sale_Product_Table", dgv_Sell_Stock);
        }

        #endregion

        #region Show

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            GFOBJ.ConnectDb();

            SqlDataAdapter sda = new SqlDataAdapter("select * from Customer_Total_Sale_Bill_Table where Customer = '" + tb_Customer_Name.Text + "'  ", GFOBJ.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Sell_Stock.DataSource = dt;

            GFOBJ.DisconnectDb();
        }

        #endregion
    }
}
