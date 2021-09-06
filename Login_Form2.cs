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
    public partial class frm_Login_Form2 : Form
    {
        public frm_Login_Form2()
        {
            InitializeComponent();
        }

        Global_Fun GFOBJ = new Global_Fun();


        #region Enter_Event

        private void tb_Username_Enter(object sender, EventArgs e)
        {
            tb_Username.Text = "";
        }

        private void tb_Password_Enter(object sender, EventArgs e)
        {
              tb_Password.Text = "";
        }

        #endregion

        #region Leave_Event

        private void tb_Password_Leave(object sender, EventArgs e)
        {
             if(tb_Password.Text == "")
            {
              tb_Password.Text = "Password";
            }
        }

        private void tb_Username_Leave(object sender, EventArgs e)
        {
            if (tb_Username.Text == "")
            {
                tb_Username.Text = "Username";
            }
        }

        #endregion

        #region X_Click

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region Login_Click

        private void btn_Login_Click(object sender, EventArgs e)
        {
            GFOBJ.ConnectDb();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Login_Table where Username ='" + tb_Username.Text + "' and Password = '" + tb_Password.Text + "'    ",GFOBJ.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login Successfull....!","Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                MDI_Agriculture_Service_Center obj = new MDI_Agriculture_Service_Center();
                               
                obj.Show();
                
  
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password....","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        #endregion

        #region Form_Open

        private void btn_Sign_Up_Click(object sender, EventArgs e)
        {
            Frm_Sign_Up SUobj = new Frm_Sign_Up();
            SUobj.Show();
        }

        private void btn_Forget_Password_Click(object sender, EventArgs e)
        {
            frm_Forget_Password FPobj = new frm_Forget_Password();
            FPobj.Show();
        }

        #endregion


    }
}