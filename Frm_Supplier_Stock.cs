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
    public partial class Frm_Supplier_Stock : Form
    {
        public Frm_Supplier_Stock()
        {
            InitializeComponent();
        }

        Global_Fun GFobj = new Global_Fun();

        #region Load_Form

        private void Frm_Supplier_Stock_Load(object sender, EventArgs e)
        {
            GFobj.FillDataGridView("Select * from Supplier_Puchase_Table", dgv_Supllier_Stock);
        }

        #endregion

        #region Show

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            GFobj.ConnectDb();

            SqlDataAdapter sda = new SqlDataAdapter("select * from Supplier_Puchase_Table where Distributor = '" + tb_S_Name.Text + "'  ", GFobj.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Supllier_Stock.DataSource = dt;

            GFobj.DisconnectDb();
        }

        #endregion
    }
}
