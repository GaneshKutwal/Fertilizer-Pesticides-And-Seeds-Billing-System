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
    public partial class frm_Show_Supplier : Form
    {
        Global_Fun GFobj = new Global_Fun();

        public frm_Show_Supplier()
        {
            InitializeComponent();
        }

        #region Load_Form

        private void frm_Show_Supplier_Load(object sender, EventArgs e)
        {
            GFobj.FillDataGridView("Select * from Supplier_Table",dgv_Supplier);
        }

        #endregion

        #region Show


        private void Btn_Show_Click(object sender, EventArgs e)
        {
            GFobj.ConnectDb();

            SqlDataAdapter sda = new SqlDataAdapter("select * from Supplier_Table where Name = '" + tb_S_Name.Text + "'  ", GFobj.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Supplier.DataSource = dt;

            GFobj.DisconnectDb();
        }

        #endregion


    }
}
