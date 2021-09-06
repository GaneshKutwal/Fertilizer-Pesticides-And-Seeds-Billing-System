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
    public partial class Frm_Update_Employee : Form
    {
        public Frm_Update_Employee()
        {
            InitializeComponent();
        }

        Global_Fun GFobj = new Global_Fun();

        #region Control_Clear_Enabled_Disabled

        private void Clear_Controls()
        {
            tb_S_ID.Text = "";
            tb_S_Name.Text = "";
            tb_S_Address.Text = "";
            tb_S_Mobile.Text = "";
            tb_S_Email.Text = "";
            tb_Aadhar_No.Text = "";
        }

        private void Control_Enabled()
        {
            tb_S_Name.Enabled = true;
            tb_S_Address.Enabled = true;
            tb_S_Mobile.Enabled = true;
            tb_S_Email.Enabled = true;
            tb_Aadhar_No.Enabled = true;
        }



        private void Control_Disabled()
        {
            tb_S_Name.Enabled = false;
            tb_S_Address.Enabled = false;
            tb_S_Mobile.Enabled = false;
            tb_S_Email.Enabled = false;
            tb_Aadhar_No.Enabled = false;
        }

        #endregion

        #region CHAR_NUMBERIC_FUNCTION

        private void ISCHAR(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void ISNUMBERIC(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Form_Load

        private void Frm_Update_Employee_Load(object sender, EventArgs e)
        {
            Control_Disabled();
        }

        #endregion

        #region Search_Fun

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_S_ID.Text != "")
            {
                GFobj.ConnectDb();

                SqlCommand cmd = new SqlCommand("Select * from  Employee_Table where Employee_Id = " + tb_S_ID.Text + " ", GFobj.con);
                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    dtp_S_Date.Text = (obj["Date"].ToString());
                    tb_S_Name.Text = (obj.GetString(obj.GetOrdinal("Name")));
                    tb_S_Address.Text = (obj.GetString(obj.GetOrdinal("Address")));
                    tb_S_Mobile.Text = (obj["Mobile_No"].ToString());
                    tb_S_Email.Text = (obj.GetString(obj.GetOrdinal("Email_Id")));
                    tb_Aadhar_No.Text = (obj["Aadhar_No"].ToString());


                    tb_S_ID.Enabled = false;
                    Control_Enabled();

                    GFobj.DisconnectDb();
                }

                else
                {
                    MessageBox.Show("Please Enter A Supplier Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_S_ID.Text = "";
                    tb_S_ID.Focus();
                }
            }
            else
            {
                MessageBox.Show("1st Fill All The Field");
                tb_S_ID.Focus();
            }
        }
        #endregion

        #region Update_Click

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (dtp_S_Date.Text != "" && tb_S_ID.Text != "" && tb_S_Name.Text != "" && tb_S_Address.Text != "" && tb_S_Mobile.Text != "" && tb_S_Email.Text != "" && tb_Aadhar_No.Text != "")
            {
                GFobj.Update_Table("Update Employee_Table set Date = '" + dtp_S_Date.Text + "', Name = '" + tb_S_Name.Text + "', Address = '" + tb_S_Address.Text + "', Mobile_No = " + tb_S_Mobile.Text + ",Email_Id = '" + tb_S_Email.Text + "',Aadhar_No = " + tb_Aadhar_No.Text + " where Employee_Id = " + tb_S_ID.Text + " ");
                MessageBox.Show("Record Updated Successfully ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Control_Disabled();
                tb_S_ID.Enabled = true;
                tb_S_ID.Text = "";
                tb_S_ID.Focus();


            }
            else
            {
                MessageBox.Show("1st Fill The All Fields !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion

       



    }
}
