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
    public partial class Frm_Sign_Up : Form
    {
        public Frm_Sign_Up()
        {
            InitializeComponent();
        }
        Global_Fun GFOBJ = new Global_Fun();

        #region ClearControl

        private void clearcontrol()
       {
           tb_Username.Text = "Username";
           tb_Password.Text = "Password";
           tb_Confirm_Password.Text = "Password";
           tb_Admin_Key.Text = "Admin Key";

       }
        #endregion

        

        #region X_Click

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region Enter_Event

        private void tb_Username_Enter(object sender, EventArgs e)
        {
            tb_Username.Text = "";
            
        }

        private void tb_Password_Enter(object sender, EventArgs e)
        {
           
                tb_Password.Text = "";
            
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

        #region Leave_Event

        private void tb_Username_Leave(object sender, EventArgs e)
        {
            if (tb_Username.Text == "")
            {
                tb_Username.Text = "Username";
            }
        }

        private void tb_Password_Leave(object sender, EventArgs e)
        {
            if (tb_Password.Text == "")
            {
               tb_Password.Text = "Password";
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
            if (tb_Admin_Key.Text == "")
            {
                tb_Admin_Key.Text = "Admin Key";
            }
        }

        #endregion

        #region Sign_Up

        private void btn_Sign_Up_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text != "" && tb_Password.Text != "" && tb_Confirm_Password.Text != "" && tb_Admin_Key.Text != "")
            {
                GFOBJ.ConnectDb();
                SqlDataAdapter sda = new SqlDataAdapter(" Select Username From Login_Table where  Username = '" + tb_Username.Text + "' ",GFOBJ.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count >=1)
                {
                    MessageBox.Show("Username Already Taken !!! ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    if( tb_Password.Text == tb_Confirm_Password.Text)
                    {
                        string AdminKey = "";
                         AdminKey = Convert.ToString(GFOBJ.DB_Name_Contain("SELECT * FROM Login_Table WHERE ID = 1 ","Admin_Key"));
                       
                        if(AdminKey == tb_Admin_Key.Text)
                        {

                            string userkey = "";
                            string currentyear = DateTime.Now.Year.ToString();
                            userkey = tb_Username.Text + "_" + currentyear;

                            GFOBJ.FillTableDB("Insert into Login_Table Values ('" + tb_Username.Text + "','" + tb_Password.Text + "','" + userkey + "')");
                            MessageBox.Show("Add User Successfully....!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearcontrol();

                            userkey = "";

                        }
                        else
                        {
                            MessageBox.Show("Invalid Admin Key","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Does Not Matched","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("1st Fill All Fields....!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


    }
}
