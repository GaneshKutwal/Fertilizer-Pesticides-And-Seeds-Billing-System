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
    public partial class frm_Sale_Bill : Form
    {
        public frm_Sale_Bill()
        {
            InitializeComponent();
        }

        Global_Fun GfObj = new Global_Fun();
        int selectedrow;

        #region Material_&_Customer_Form_OPen

        private void btn_Material_Click(object sender, EventArgs e)
        {
            frm_Add_Products APobj = new frm_Add_Products();
            APobj.Show();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            frm_New_Customers NCobj = new frm_New_Customers();
            NCobj.Show();

        }
        #endregion

        #region Form_Load

        private void frm_Sale_Bill_Load(object sender, EventArgs e)
        {
            GfObj.ConnectDb();

            //cmb_Customer_Name.Binding

            SqlCommand Ccmd = new SqlCommand("Select Distinct (Name) From Customer_Table",GfObj.con);

            var Cobj = Ccmd.ExecuteReader();

            while (Cobj.Read())
            {
                cmb_Customer.Items.Add(Cobj.GetString(Cobj.GetOrdinal("Name"))) ;
            }
            Cobj.Dispose();


            //cmb_Product_Name_Binding


            SqlCommand Pcmd = new SqlCommand("Select Distinct(Product_Name) From Available_Stock_Table", GfObj.con);

            var Pobj = Pcmd.ExecuteReader();

           while(Pobj.Read())
            {
                cmb_Product.Items.Add(Pobj.GetString(Pobj.GetOrdinal("Product_Name")));
            }
            Pobj.Dispose();


        }

        #endregion

        #region Sum_From_Datagrid

        private void SumFromDatagrid()
        {

            dgv_Sale_Bill.AllowUserToAddRows = false;
            int SU = 0;
            float SA = 0;

            for (int i = 0; i <= dgv_Sale_Bill.Rows.Count - 1; i++)
            {
                SU = SU + int.Parse(dgv_Sale_Bill.Rows[i].Cells[3].Value.ToString());
            }
            tb_Unit2.Text = SU.ToString();


            for (int i = 0; i <= dgv_Sale_Bill.Rows.Count - 1; i++)
            {
                SA = SA + float.Parse(dgv_Sale_Bill.Rows[i].Cells[7].Value.ToString());
            }
            tb_G_Amount.Text = SA.ToString();

        }

        #endregion

        #region Cmb_Index

        private void cmb_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Customer.Text != "")
            {
                GfObj.ConnectDb();

                SqlCommand cmd = new SqlCommand("select Name, Address, Mobile_No from Customer_Table where Name = '" + cmb_Customer.Text + "' ",GfObj.con);

                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                   tb_Customer.Text = (obj.GetString(obj.GetOrdinal("Name")) + (" , ") + (obj.GetString(obj.GetOrdinal("Address"))));
                   tb_Mobile_No.Text = (obj["Mobile_No"].ToString());
                }
                else
                {
                    MessageBox.Show("Invalid Product Name!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    cmb_Product.Focus();

                }

                GfObj.DisconnectDb();
            }
            else
            {
                MessageBox.Show("Fill Customer Name 1st", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Product.Text != "")
            {
                GfObj.ConnectDb();

                SqlCommand cmd = new SqlCommand("select  Sell_Price , GST from Product_Table where Name = '" + cmb_Product.Text + "' ", GfObj.con);

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
                    MessageBox.Show("Invalid Product Name!!!");
                    cmb_Product.Focus();

                }

               GfObj.DisconnectDb();
            }
            else
            {
                MessageBox.Show("Fill Product Name 1st");
            }
        }
        #endregion

        #region Product_Total

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
                    DataGridViewRow newdatarow = dgv_Sale_Bill.Rows[selectedrow];
                    newdatarow.Cells[1].Value = cmb_Product.SelectedItem;
                    newdatarow.Cells[2].Value = dtp_Expiry.Text;
                    newdatarow.Cells[3].Value = tb_Unit.Text;
                    newdatarow.Cells[4].Value = tb_Rate.Text;
                    newdatarow.Cells[5].Value = tb_SGst.Text;
                    newdatarow.Cells[6].Value = tb_Amount.Text;
                    newdatarow.Cells[7].Value = tb_Total_Amount.Text;

                    cmb_Product.Text = "";
                    tb_Unit.Text = "";
                    tb_Rate.Text = "";
                    tb_SGst.Text = "";
                    tb_Amount.Text = "";
                    tb_Total_Amount.Text = "";

                    int sr = dgv_Sale_Bill.Rows.Count;
                    sr++;
                    tb_Sr_No.Text = sr.ToString();
                    cmb_Product.Focus();
                    SumFromDatagrid();

                }
                else
                {
                dgv_Sale_Bill.Rows.Add(tb_Sr_No.Text, cmb_Product.SelectedItem, dtp_Expiry.Text, tb_Unit.Text, tb_Rate.Text, tb_SGst.Text, tb_Amount.Text, tb_Total_Amount.Text);

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

                SumFromDatagrid();
                }
            }
        }

        #endregion

        #region All_Product_Total

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

        #region Save_Click

        private void Btn_Save_Click(object sender, EventArgs e)
        {


            if(cmb_Customer.Text != "" && dtp_Date.Text != "" && cmb_Pay_Mode.Text != "" && tb_Unit2.Text !="" && tb_G_Amount.Text !="" && tb_Discount.Text!="" && tb_Discount.Text !="" && tb_Total_Amt.Text !="" )
            {
                for (int i = 0; i < dgv_Sale_Bill.Rows.Count; i++)
                {
                    GfObj.ConnectDb();
                    int c;
                    SqlCommand cmd1 = GfObj.con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from Available_Stock_Table  where Product_Name = '" + dgv_Sale_Bill.Rows[i].Cells[1].Value + "' ";
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    c = Convert.ToInt32(dt1.Rows.Count.ToString());
                    

                    GfObj.FillTableDB("Insert Into Customer_Sale_Product_Table(Customer,Product,Expiry,Unit,Rate,Amount,GST,Total_Amount) values ('" + cmb_Customer.Text + "','" + dgv_Sale_Bill.Rows[i].Cells[1].Value + "','" + dgv_Sale_Bill.Rows[i].Cells[2].Value + "'," + dgv_Sale_Bill.Rows[i].Cells[3].Value + "," + dgv_Sale_Bill.Rows[i].Cells[4].Value + "," + dgv_Sale_Bill.Rows[i].Cells[6].Value + "," + dgv_Sale_Bill.Rows[i].Cells[5].Value + "," + dgv_Sale_Bill.Rows[i].Cells[7].Value + ")");

                    GfObj.FillTableDB("Insert Into Customer_Total_Sale_Bill_Table(Customer,Date,Pay_Mode,Gross_Amount,Discount,Total_Amount) values ('" + cmb_Customer.Text + "','" + dtp_Date.Text + "','" + cmb_Pay_Mode.Text + "'," + tb_G_Amount.Text + "," + tb_Discount.Text + "," + tb_Total_Amt.Text + ")");

                    GfObj.Update_Table("Update Available_Stock_Table set Unit = Unit - " + dgv_Sale_Bill.Rows[i].Cells[3].Value + " where Product_Name = '" + dgv_Sale_Bill.Rows[i].Cells[1].Value + "' ");

                 

                }
                MessageBox.Show("Record Successfully Added", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information); 

                dgv_Sale_Bill.Rows.Clear();
                cmb_Customer.Text = "";
                cmb_Pay_Mode.Text = "";
                tb_Customer.Text = "";
                tb_Mobile_No.Text="";
                tb_Sr_No.Text = "1";
                tb_Unit2.Text = "";
                tb_G_Amount.Text = "";
                tb_Discount.Text = "";
                tb_Total_Amt.Text = "";



            }
            else
            {
                MessageBox.Show("1st Fill The All Fields !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        #endregion


        #region datagridtotextbox
        private void dgv_Sale_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = dgv_Sale_Bill.Rows[selectedrow];
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
