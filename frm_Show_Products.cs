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
    public partial class frm_Show_Products : Form
    {
        Global_Fun GFobj = new Global_Fun();

        public frm_Show_Products()
        {
            InitializeComponent();
        }

        #region Form_Load

        private void frm_Show_Products_Load(object sender, EventArgs e)
        {
            GFobj.FillDataGridView("Select * from Product_Table  ", dgv_Product);

            GFobj.ConnectDb();



            //cmb_Product_Name_Binding

            SqlCommand Pcmd = new SqlCommand("Select Distinct(Name) From Product_Table", GFobj.con);

            var Pobj = Pcmd.ExecuteReader();

            while (Pobj.Read())
            {
                cmb_P_Name.Items.Add(Pobj.GetString(Pobj.GetOrdinal("Name")));
            }
            Pobj.Dispose();



            //cmb_Customer_Name_Binding

            SqlCommand Ccmd = new SqlCommand("Select Distinct(Category) From Category_Table",GFobj.con);

            var Cobj = Ccmd.ExecuteReader();

            while (Cobj.Read())
            {
                cmb_P_Category.Items.Add(Cobj.GetString(Cobj.GetOrdinal("Category")));
            }
            Cobj.Dispose();

          


        }

        #endregion

        #region Show

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            if(cmb_P_Category.Text != "" && cmb_P_Name.Text != "")
            {
                GFobj.ConnectDb();

                SqlDataAdapter sda = new SqlDataAdapter("Select * From Product_Table Where Category = '" + cmb_P_Category.Text + "' And  Name = '" + cmb_P_Name.Text + "' ", GFobj.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_Product.DataSource = dt;

                GFobj.DisconnectDb();
            }
            else if (cmb_P_Category.Text != "" && cmb_P_Name.Text =="")
            {
                GFobj.ConnectDb();

                SqlDataAdapter sda = new SqlDataAdapter("select * from Product_Table where Category = '" + cmb_P_Category.Text + "'  ", GFobj.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_Product.DataSource = dt;

                GFobj.DisconnectDb();
            
            }
            else if (cmb_P_Category.Text == "" && cmb_P_Name.Text != "")
            {
                GFobj.ConnectDb();

                SqlDataAdapter sda = new SqlDataAdapter("select * from Product_Table where Name = '" + cmb_P_Name.Text + "'  ", GFobj.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_Product.DataSource = dt;

                GFobj.DisconnectDb();
            
            }
            else if (cmb_P_Category.Text == "" && cmb_P_Name.Text == "")
            {
                MessageBox.Show("please Enter Valid Information");
            }
            else
            {
                MessageBox.Show("Information Not Found");
                cmb_P_Category.Text = "";
                cmb_P_Name.Text = "";
                cmb_P_Category.Focus();
            }

        }
        #endregion


    }
}
