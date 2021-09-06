using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agriculture_Service_Center
{
    public partial class Frm_Add_Employee : Form
    {
        public Frm_Add_Employee()
        {
            InitializeComponent();
        }
        Global_Fun GFobj = new Global_Fun();


        #region Form_Load
        private void Frm_Add_Employee_Load(object sender, EventArgs e)
        {
            tb_S_ID.Text = GFobj.AutoIncreament("Select count(Employee_Id) from Employee_Table ", "Select Max(Employee_Id) From Employee_Table", 1001).ToString();

            tb_S_Name.Focus();
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

        #region  Clear_Control

        private void Clear_Controls()
        {
            tb_S_ID.Text = "";
            tb_S_Name.Text = "";
            tb_S_Address.Text = "";
            tb_S_Mobile.Text = "";
            tb_S_Email.Text = "";
            tb_Aadhar_No.Text = "";
        }

        #endregion

        #region Insert TO Database

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_S_ID.Text != "" && tb_S_Name.Text != "" && tb_S_Address.Text != "" && tb_S_Mobile.Text != "" && tb_S_Email.Text != "" && tb_Aadhar_No.Text != "")
            {
                GFobj.FillTableDB("Insert Into Employee_Table Values ('" + dtp_S_Date.Text + "'," + tb_S_ID.Text + ",'" + tb_S_Name.Text + "','" + tb_S_Address.Text + "'," + tb_S_Mobile.Text + ",'" + tb_S_Email.Text + "'," + tb_Aadhar_No.Text + ")");

                MessageBox.Show("Record Successfully Added", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

                tb_S_ID.Text = GFobj.AutoIncreament("Select count(Employee_Id) From Employee_Table", "Select Max(Employee_Id) From Employee_Table", 1001).ToString();

                tb_S_Name.Focus();
            }
            else
            {
                MessageBox.Show("1st Fill The All Fields !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

       
    }
}
