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
    public partial class frm_New_Supplier : Form
    {
        public frm_New_Supplier()
        {
            InitializeComponent();
        }

        Global_Fun GFobj = new Global_Fun();


        #region Char_Numbric_Function

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

        #region  Form_Load

        private void frm_New_Supplier_Load(object sender, EventArgs e)
        {
            tb_S_ID.Text = GFobj.AutoIncreament("Select count(Supplier_Id) from Supplier_Table ","Select Max(Supplier_Id) From Supplier_Table",1001).ToString();

            tb_S_Name.Focus();
        }

        #endregion

        #region  Insert_Data

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if(tb_S_ID.Text !="" && tb_S_Name.Text != "" && tb_S_Address.Text !="" && tb_S_Mobile.Text != "" && tb_S_Email.Text != "" && tb_Aadhar_No.Text != "")
            {
                GFobj.FillTableDB("Insert Into Supplier_Table Values ('" + dtp_S_Date.Text + "'," + tb_S_ID.Text + ",'" + tb_S_Name.Text + "','" + tb_S_Address.Text + "'," + tb_S_Mobile.Text + ",'" + tb_S_Email.Text + "'," + tb_Aadhar_No.Text + ")");

                MessageBox.Show("Record Successfully Added", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

                tb_S_ID.Text = GFobj.AutoIncreament("Select count(Supplier_Id) From Supplier_Table","Select Max(Supplier_Id) From Supplier_Table",1001).ToString();

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
