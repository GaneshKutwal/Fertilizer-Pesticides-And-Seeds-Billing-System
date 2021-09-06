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
    public partial class frm_New_Customers : Form
    {
        public frm_New_Customers()
        {
            InitializeComponent();
        }

        Global_Fun GFobj = new Global_Fun();

        #region  Clear_Control

        private void Clear_Controls()
        {
            tb_C_Id.Text        = "";
            tb_C_Name.Text      = "";
            tb_C_Address.Text   = "";
            tb_C_Mobile_No.Text = "";
            tb_C_Email_Id.Text  = "";
        }

        #endregion


        #region   Char_Numbric_Fuction

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

        #endregion

        #region Load_Form


        private void frm_New_Customers_Load(object sender, EventArgs e)
        {
            tb_C_Id.Text = GFobj.AutoIncreament("select count(Customer_Id) from Customer_Table", "Select Max(Customer_Id) From Customer_Table",1001).ToString();

            tb_C_Name.Focus();
        }

        #endregion

        #region Insert_To_Database

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if(tb_C_Id.Text != "" && tb_C_Name.Text != "" && tb_C_Address.Text != "" && tb_C_Mobile_No.Text != "" && tb_C_Email_Id.Text != "")
            {
                GFobj.FillTableDB("Insert   Into Customer_Table values('" + dtp_C_Date.Text + "'," + tb_C_Id.Text + ",'" + tb_C_Name.Text + "','" + tb_C_Address.Text + "','" + tb_C_Mobile_No.Text + "','" + tb_C_Email_Id.Text + "')");
                MessageBox.Show("Record Successfully Added", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

                tb_C_Id.Text = GFobj.AutoIncreament("select count(Customer_Id) from Customer_Table", "Select Max(Customer_Id) From Customer_Table", 1001).ToString();

                tb_C_Name.Focus();
            }

            else
            {
                MessageBox.Show("1st Fill The All Fields !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tb_C_Name.Focus();
            }
        }

        #endregion


    }
}
