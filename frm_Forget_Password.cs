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
    public partial class frm_Forget_Password : Form
    {
        Global_Fun GFOBJ = new Global_Fun();

        public frm_Forget_Password()
        {
            InitializeComponent();


        }

        #region ClearControls

        private void clearcontrol()
        {
            tb_Username.Text = "Username";
            tb_New_Password.Text = "Password";
            tb_Confirm_Password.Text = "Password";
            tb_Admin_Key.Text = "Admin Key";

        }

        #endregion

        #region X_Button

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region Enter_Click

        private void tb_Username_Enter(object sender, EventArgs e)
        {
            tb_Username.Text = "";
        }

        private void tb_New_Password_Enter(object sender, EventArgs e)
        {
            tb_New_Password.Text = "";
        }

        private void tb_Confirm_Password_Enter(object sender, EventArgs e)
        {
            tb_Confirm_Password.Text = "";
        }

        private void tb_Admin_Key_Enter(object sender, EventArgs e)
        {
            tb_Admin_Key.Text = "";
        }

        #endregion

        #region Leave

        private void tb_Username_Leave(object sender, EventArgs e)
        {
            if (tb_Username.Text == "")
            {
                tb_Username.Text = "Username";   
            }
        }

        private void tb_Confirm_Password_Leave(object sender, EventArgs e)
        {
            if (tb_Confirm_Password.Text == "")
            {
                tb_Confirm_Password.Text = "Password";
            }
        }

        private void tb_Admin_Key_Leave(object sender, EventArgs e)
        {
            if ( tb_Admin_Key.Text == "")
            {
                tb_Admin_Key.Text = "Admin Key";
            }
        }

        private void tb_New_Password_Leave(object sender, EventArgs e)
        {
            if (tb_New_Password.Text == "")
            {
                tb_New_Password.Text = "Admin Key";
            }
        }

        #endregion

        #region Submit_Click

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            if (tb_Username.Text != "" && tb_Admin_Key.Text != "" && tb_New_Password.Text != "" && tb_Confirm_Password.Text != "")
            {
                GFOBJ.ConnectDb();
                SqlDataAdapter sda = new SqlDataAdapter(" Select Username From Login_Table where  Username = '" + tb_Username.Text + "' ", GFOBJ.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    if (tb_New_Password.Text == tb_Confirm_Password.Text)
                    {
                        string AdminKey = "";
                         AdminKey = Convert.ToString(GFOBJ.DB_Name_Contain("SELECT * FROM Login_Table WHERE Username = '" + tb_Username.Text + "' ","Admin_Key"));

                         if (AdminKey == tb_Admin_Key.Text)
                         {
                             GFOBJ.FillTableDB("UPDATE Login_Table SET Password = '" + tb_Confirm_Password.Text + "' WHERE Username = '" + tb_Username.Text + "' AND Admin_Key = '" + tb_Admin_Key.Text + "'");

                             MessageBox.Show("Password Change Successfully....!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                             clearcontrol();

                             tb_Username.Focus();
                         }
                         else
                         {
                             MessageBox.Show("Invalid Admin Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                    }
                    else
                    {
                        MessageBox.Show("Password Does Not Matched !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Can't Find Username!!! ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("1st Fill All Fiels....!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        #endregion



    }
}
