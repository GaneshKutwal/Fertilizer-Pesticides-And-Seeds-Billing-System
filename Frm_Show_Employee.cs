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
    public partial class Frm_Show_Employee : Form
    {
        public Frm_Show_Employee()
        {
            InitializeComponent();
        }

        Global_Fun GFobj = new Global_Fun();

        #region fORM_Load

        private void Frm_Show_Employee_Load(object sender, EventArgs e)
        {
            GFobj.FillDataGridView("Select * from Employee_Table", dgv_Supplier);
        }

        #endregion

        #region Show

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            GFobj.ConnectDb();

            SqlDataAdapter sda = new SqlDataAdapter("select * from Employee_Table where Name = '" + tb_S_Name.Text + "'  ", GFobj.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Supplier.DataSource = dt;

            GFobj.DisconnectDb();
        }
        #endregion
    }
}
