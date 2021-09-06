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
    public partial class Frm_Show_Customer : Form
    {
        Global_Fun GFobj = new Global_Fun();

        public Frm_Show_Customer()
        {
            InitializeComponent();
        }

        #region ISchar_Fun

        private void Ischar(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Load_Form

        private void Frm_Show_Customer_Load(object sender, EventArgs e)
        {
            GFobj.FillDataGridView("Select * from Customer_Table",dgv_Customer);
        }
        #endregion

        #region Show

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            GFobj.ConnectDb();

            SqlDataAdapter sda = new SqlDataAdapter("select * from Customer_Table where Name = '" + tb_C_Name.Text + "'  ",GFobj.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Customer.DataSource = dt;

            GFobj.DisconnectDb();
        }
        #endregion


    }
}
