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
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        #region Click_Button

        private void btn_Click_Here_To_Login_Click(object sender, EventArgs e)
        {
            frm_Login_Form2 obj = new frm_Login_Form2();
            obj.ShowDialog();
            this.Close();
            this.Hide();
        }

        #endregion
    }
}
