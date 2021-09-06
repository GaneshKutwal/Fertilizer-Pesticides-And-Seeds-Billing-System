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
    public partial class Frm_Category : Form
    {
        public Frm_Category()
        {
            InitializeComponent();
        }

        
        Global_Fun GFobj = new Global_Fun();

        #region Load_Form

        private void Frm_Category_Load(object sender, EventArgs e)
        {
            tb_No.Text = GFobj.AutoIncreament("Select Count(No)From Category_Table","Select Max(No) From Category_Table",1).ToString();
        }

        #endregion

        #region Insert_To_Database

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_No.Text != "" && tb_Category.Text != "")
            {
                GFobj.FillTableDB("Insert Into Category_Table Values(" + tb_No.Text + ",'" + tb_Category.Text + "') ");

                MessageBox.Show("Saved Successfully","Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);

                tb_Category.Text = "";
                tb_Category.Focus();

                tb_No.Text = GFobj.AutoIncreament("Select Count(No) From Category_Table","Select Max(No)from Category_Table",1).ToString();

            }
            else
            {
                MessageBox.Show("1st Fill All The Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_No.Focus();
            }
        }

        #endregion


    }
}
