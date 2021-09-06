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
    public partial class Frm_Purchase_Stock : Form
    {
        public Frm_Purchase_Stock()
        {
            InitializeComponent();
        }

        Global_Fun GFOBJ = new Global_Fun();

        #region Load_Form

        private void Frm_Purchase_Stock_Load(object sender, EventArgs e)
        {
            GFOBJ.FillDataGridView("Select * from Purchase_Stock_Table",dgv_Purchase_Stock );
        }

        #endregion

        #region Show

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            if(tb_Product_Name.Text !="")
            {

            GFOBJ.ConnectDb();

            SqlDataAdapter sda = new SqlDataAdapter("select * from Purchase_Stock_Table where Product = '" + tb_Product_Name.Text + "'  ", GFOBJ.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Purchase_Stock.DataSource = dt;

            GFOBJ.DisconnectDb();
            }
            else
            {
                MessageBox.Show("Please Enter Product Name !!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            }
        }

        #endregion


    }
}
