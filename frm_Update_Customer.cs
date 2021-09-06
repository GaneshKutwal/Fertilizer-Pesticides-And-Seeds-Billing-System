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
    public partial class frm_Update_Customer : Form
    {
        public frm_Update_Customer()
        {
            InitializeComponent();
        }

        Global_Fun GFobj = new Global_Fun();

        #region Control_Clear_Enabled_Disabled

        private void Clear_Function()
        {
            tb_C_Id.Text = "";
            tb_C_Name.Text = "";
            tb_C_Address.Text = "";
            tb_C_Mobile_No.Text = "";
            tb_C_Email_Id.Text = "";
        }

        private void Control_Enabled()
        {
            tb_C_Name.Enabled = true;
            tb_C_Address.Enabled = true;
            tb_C_Email_Id.Enabled = true;
            tb_C_Mobile_No.Enabled = true;
        }

        private void Control_Disabled()
        {
            tb_C_Name.Enabled = false;
            tb_C_Address.Enabled = false;
            tb_C_Mobile_No.Enabled = false;
            tb_C_Email_Id.Enabled = false;
        }

        #endregion

        #region  Numberic_Char_Function

        private void Isnumberic(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Ischar(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void Is_Numberic(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

        }

        private void IS_Char(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Form_Load

        private void frm_Update_Customer_Load(object sender, EventArgs e)
        {
            Control_Disabled();
        }

        #endregion

        #region  Search_Function

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_C_Id.Text != "")
            {
                GFobj.ConnectDb();

                GFobj.ConnectDb();

                SqlCommand cmd = new SqlCommand("Select * from  Customer_Table where Customer_Id = " + tb_C_Id.Text + " ", GFobj.con);
                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    dtp_C_Date.Text = (obj["Date"].ToString());
                    tb_C_Name.Text = (obj.GetString(obj.GetOrdinal("Name")));
                    tb_C_Address.Text = (obj.GetString(obj.GetOrdinal("Address")));
                    tb_C_Mobile_No.Text = (obj["Mobile_No"].ToString());
                    tb_C_Email_Id.Text = (obj.GetString(obj.GetOrdinal("Email_Id")));


                    tb_C_Id.Enabled = false;
                    Control_Enabled();

                    GFobj.DisconnectDb();
                }

                else
                {
                    MessageBox.Show("Please Enter A Customer Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_C_Id.Text = "";
                    tb_C_Id.Focus();
                }
            }
            else
            {
                MessageBox.Show("1st Fill All The Field");
                tb_C_Id.Focus();
            }
        }

        #endregion

        #region Update_Function

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_C_Id.Text != "" && tb_C_Name.Text != "" && tb_C_Address.Text != "" && tb_C_Mobile_No.Text != "" && tb_C_Email_Id.Text != "")
            {
                GFobj.Update_Table(" Update Customer_Table set date = '" + dtp_C_Date.Text + "', Name = '" + tb_C_Name.Text + "', Address = '" + tb_C_Address.Text + "', Mobile_No = " + tb_C_Mobile_No.Text + ", Email_Id = '" + tb_C_Email_Id.Text + "' where Customer_Id = " + tb_C_Id.Text + " ");
                MessageBox.Show("Record Updated Successfully ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Function();
                Control_Disabled();
                tb_C_Id.Enabled = true;
                tb_C_Id.Text = "";
                tb_C_Id.Focus();
 
            }
            else
            {
                MessageBox.Show("1st Fill The All Fields !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }

        #endregion

       
    }
}
