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
    public partial class frm_Expences : Form
    {
        public frm_Expences()
        {
            InitializeComponent();
        }

        Global_Fun GFobj = new Global_Fun();

        #region Clear_Controls

        private void Clear_Controls()
        {
            tb_Expence.Text = "";
            tb_Amount.Text = "";
            tb_Name.Text = "";
            tb_Note.Text = "";
         
        }

        #endregion

        #region Numberic_Char_Function

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

        #region Insert_Data

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if(tb_Expence.Text != "" && tb_Amount.Text != "" && tb_Name.Text != "")
            {
                GFobj.FillTableDB("Insert into Expences_Table values ('" + dtp_Date.Text + "','" + tb_Expence.Text + "'," + tb_Amount.Text + ",'" + tb_Name.Text + "','" + tb_Note.Text + "')");

                MessageBox.Show("Saved Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

                tb_Expence.Focus();


            }
            else
            {
                MessageBox.Show("1st Fill All The Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
