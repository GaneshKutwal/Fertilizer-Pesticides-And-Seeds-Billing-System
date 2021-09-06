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
    public partial class frm_Sales_Return : Form
    {
        public frm_Sales_Return()
        {
            InitializeComponent();
        }

      
        Global_Fun GFobj = new Global_Fun();
        int selectedrow;

        #region Customer_&_Material_Form

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            frm_New_Customers NCobj = new frm_New_Customers();
            NCobj.Show();
        }

        private void btn_Material_Click(object sender, EventArgs e)
        {
            frm_Add_Products APobj = new frm_Add_Products();
            APobj.Show();
        }

        #endregion

        #region Form_Load

        private void frm_Sales_Return_Load(object sender, EventArgs e)
        {
            GFobj.ConnectDb();


            //cmb_Customer_Name.Binding

            SqlCommand Ccmd = new SqlCommand("Select Distinct(Name) From Customer_Table", GFobj.con);

            var Cobj = Ccmd.ExecuteReader();

            while (Cobj.Read())
            {
                cmb_Customer.Items.Add(Cobj.GetString(Cobj.GetOrdinal("Name")));
            }
            Cobj.Dispose();

            //cmb_Product_Name_Binding

            SqlCommand Pcmd = new SqlCommand("Select Distinct(Name) From Product_Table", GFobj.con);

            var Pobj = Pcmd.ExecuteReader();

            while (Pobj.Read())
            {
                cmb_Product.Items.Add(Pobj.GetString(Pobj.GetOrdinal("Name")));
            }
            Pobj.Dispose();

        }
        #endregion

        #region Sum_From_Grid

        private void SumfromDataGrid()
        {
            dgv_Sale_Return_Bill.AllowUserToAddRows = false;
            int sum = 0;
            float SA = 0;

            for (int i = 0; i <= dgv_Sale_Return_Bill.Rows.Count - 1; i++)
            {
                sum = sum + int.Parse(dgv_Sale_Return_Bill.Rows[i].Cells[3].Value.ToString());
            }
            tb_Unit2.Text = sum.ToString();


            for (int i = 0; i <= dgv_Sale_Return_Bill.Rows.Count - 1; i++)
            {
                SA = SA + float.Parse(dgv_Sale_Return_Bill.Rows[i].Cells[7].Value.ToString());
            }
            tb_G_Amount.Text = SA.ToString();

        }

        #endregion

        #region Product_Details

        private void cmb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Product.Text != "")
            {
                GFobj.ConnectDb();

                SqlCommand cmd = new SqlCommand("select  Sell_Price , GST from Product_Table where Name = '" + cmb_Product.Text + "' ", GFobj.con);

                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Rate.Text = (obj["Sell_Price"].ToString());
                    tb_SGst.Text = (obj["GST"].ToString());

                    tb_Unit.Text = "";
                    tb_Amount.Text = "";
                    tb_Total_Amount.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid Product Name!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    cmb_Product.Focus();

                }

                GFobj.DisconnectDb();
            }
            else
            {
                MessageBox.Show("Fill Product Name 1st","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Total_Amt

        private void tb_Unit_TextChanged(object sender, EventArgs e)
        {
            if (tb_Unit.Text.Length == 0)
            {
                return;
            }
            else
            {
                double UNIT = Convert.ToDouble(tb_Unit.Text);
                double RATE = Convert.ToDouble(tb_Rate.Text);
                double GST = Convert.ToDouble(tb_SGst.Text);

                double Amt = RATE * UNIT;

                tb_Amount.Text = Amt.ToString();

                double TAmt = Amt + (Amt * (GST / 100));

                tb_Total_Amount.Text = TAmt.ToString();


            }
        }

        #endregion

        #region Add_To_Data_Grid

        private void tb_Total_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int no = Convert.ToInt32(tb_Sr_No.Text);

                if(no == selectedrow)
                {
                    selectedrow--;
                    DataGridViewRow newdatarows = dgv_Sale_Return_Bill.Rows[selectedrow];
                    newdatarows.Cells[1].Value = cmb_Product.SelectedItem;
                    newdatarows.Cells[2].Value = dtp_Expiry.Text;
                    newdatarows.Cells[3].Value = tb_Unit.Text;
                    newdatarows.Cells[4].Value = tb_Rate.Text;
                    newdatarows.Cells[5].Value = tb_SGst.Text ;
                    newdatarows.Cells[6].Value = tb_Amount.Text;
                    newdatarows.Cells[7].Value = tb_Total_Amount.Text;

                    cmb_Product.Text = "";
                    tb_Unit.Text = "";
                    tb_Rate.Text = "";
                    tb_SGst.Text = "";
                    tb_Amount.Text = "";
                    tb_Total_Amount.Text = "";

                    int sr = dgv_Sale_Return_Bill.Rows.Count;
                    sr++;
                    tb_Sr_No.Text = sr.ToString();
                    cmb_Product.Focus();
                    SumfromDataGrid();

                
                }
                else
                {
                      dgv_Sale_Return_Bill.Rows.Add(tb_Sr_No.Text, cmb_Product.SelectedItem, dtp_Expiry.Text, tb_Unit.Text, tb_Rate.Text, tb_SGst.Text, tb_Amount.Text, tb_Total_Amount.Text);

                      cmb_Product.Text = "";
                      tb_Unit.Text = "";
                      tb_Rate.Text = "";
                      tb_SGst.Text = "";
                      tb_Amount.Text = "";
                      tb_Total_Amount.Text = "";

                      int Sn = Convert.ToInt32(tb_Sr_No.Text);
                      Sn = Sn + 1;
                      tb_Sr_No.Text = Sn.ToString();
                      cmb_Product.Focus();

                      SumfromDataGrid();
                } 
            }
        }

        #endregion

        #region Customer_Details

        private void cmb_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Customer.Text != "")
            {
                GFobj.ConnectDb();

                SqlCommand cmd = new SqlCommand("select Name, Address, Mobile_No from Customer_Table where Name = '" + cmb_Customer.Text + "' ", GFobj.con);

                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Name.Text = (obj.GetString(obj.GetOrdinal("Name")) + (" , ") + (obj.GetString(obj.GetOrdinal("Address"))));
                    tb_Mobile_No.Text = (obj["Mobile_No"].ToString());
                }
                else
                {
                    MessageBox.Show("Invalid Product Name!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    cmb_Product.Focus();

                }

                GFobj.DisconnectDb();
            }
            else
            {
                MessageBox.Show("Fill Customer Name 1st");
            }
        }
        #endregion

        #region Disount_Amt

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            if (tb_Discount.Text.Length == 0)
            {
                return;
            }
            else
            {
                double TA;
                double DP = Convert.ToDouble(tb_Discount.Text);
                double GA = Convert.ToDouble(tb_G_Amount.Text);
                TA = GA - (GA * DP / 100);
                tb_Total_Amt.Text = TA.ToString();

            }
        }
        #endregion

        #region     Save_Click

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if(cmb_Customer.Text != "" && cmb_Pay_Mode.Text != "" && dtp_Date.Text !="" && tb_Unit2.Text !="" && tb_G_Amount.Text!= "" && tb_Discount.Text != "" && tb_Total_Amt.Text !="")
            {
                

                for (int i = 0; i < dgv_Sale_Return_Bill.Rows.Count;i++ )
                {
                    GFobj.ConnectDb();

                    int c;
                    SqlCommand cmd1 = GFobj.con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "Select * from Available_Stock_Table where Product_Name = '" + dgv_Sale_Return_Bill.Rows[i].Cells[1].Value + "' ";
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                    sda1.Fill(dt1);
                    c = Convert.ToInt32(dt1.Rows.Count.ToString());

                    if (c == 1)
                    {
                        GFobj.FillTableDB(" Insert Into Sales_Return_Table (Customer,Date,Product,Unit,Rate,Amount,GST,Total_Amount) values('" + cmb_Customer.Text + "','" + dtp_Date.Text + "','" + dgv_Sale_Return_Bill.Rows[i].Cells[1].Value + "'," + dgv_Sale_Return_Bill.Rows[i].Cells[3].Value + "," + dgv_Sale_Return_Bill.Rows[i].Cells[4].Value + "," + dgv_Sale_Return_Bill.Rows[i].Cells[6].Value + "," + dgv_Sale_Return_Bill.Rows[i].Cells[5].Value + "," + dgv_Sale_Return_Bill.Rows[i].Cells[7].Value + ")");
                        GFobj.Update_Table("Update Available_Stock_Table set Unit = Unit - " + dgv_Sale_Return_Bill.Rows[i].Cells[3].Value + " where Product_Name = '" + dgv_Sale_Return_Bill.Rows[i].Cells[1].Value + "' ");

                    }
                    else
                    {

                    } 

                }


                MessageBox.Show("Record Successfully Added", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                cmb_Customer.Text = "";
                cmb_Pay_Mode.Text = "";
                tb_Name.Text ="";
                tb_Mobile_No.Text = "";
                tb_Unit2.Text = "";
                tb_G_Amount.Text = "";
                tb_Discount.Text = "";
                tb_Total_Amt.Text ="";
                dgv_Sale_Return_Bill.Rows.Clear();
                tb_Sr_No.Text = "1";


            }
            else
            {
                MessageBox.Show("1st Fill The All Fields !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }
        #endregion


        #region Datagridtotextbox
        private void dgv_Sale_Return_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = dgv_Sale_Return_Bill.Rows[selectedrow];
            tb_Sr_No.Text = row.Cells[0].Value.ToString();
            cmb_Product.Text = row.Cells[1].Value.ToString();
            dtp_Expiry.Text = row.Cells[2].Value.ToString();
            //tb_Unit.Text = row.Cells[3].Value.ToString();
            tb_Rate.Text = row.Cells[4].Value.ToString();
            tb_SGst.Text = row.Cells[5].Value.ToString();
            tb_Amount.Text = row.Cells[6].Value.ToString();
            tb_Total_Amount.Text = row.Cells[7].Value.ToString();
            selectedrow++;

        }
        #endregion


    }
}
