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
    public partial class frm_Purchase_Bill : Form
    {
        public frm_Purchase_Bill()
        {
            InitializeComponent();
        }
       

        Global_Fun GFOBJ = new Global_Fun();

        int selectedrow;

        #region Numbric_Function

        private void Isnumberic(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Isnumbric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

        }

        #endregion

        #region Form_Open

        private void btn_N_Click(object sender, EventArgs e)
        {
            frm_New_Supplier NSobj = new frm_New_Supplier();
            NSobj.Show();
        }

        private void btn_N_Click_1(object sender, EventArgs e)
        {
            frm_New_Supplier NSobj = new frm_New_Supplier();
            NSobj.Show();
        }

        private void btn_Material_Click(object sender, EventArgs e)
        {
            frm_Add_Products APobj = new frm_Add_Products();
            APobj.Show();

        }

        #endregion

        #region Form_Load

        private void frm_Purchase_Bill_Load(object sender, EventArgs e)
        {
            GFOBJ.ConnectDb();

           
            //cmb_Supplier_Name_Binding

            SqlCommand Scmd = new SqlCommand("select Distinct(Name) From Supplier_Table", GFOBJ.con);

            var Sobj = Scmd.ExecuteReader();

            while (Sobj.Read())
            {
                cmb_Distrubutor.Items.Add(Sobj.GetString(Sobj.GetOrdinal("Name")));
            }

            Sobj.Dispose();

            //cmb_Product_Name_Binding

            SqlCommand Pcmd = new SqlCommand("Select Distinct(Name) From Product_Table",GFOBJ.con);

            var Pobj = Pcmd.ExecuteReader();

            while (Pobj.Read())
            {
                cmb_Product.Items.Add(Pobj.GetString(Pobj.GetOrdinal("Name")));
            }
            Pobj.Dispose();

            GFOBJ.DisconnectDb();

            dgv_Purchase_Bill.AutoGenerateColumns = false;
        }

        #endregion

        #region SumFromDatagrid

        private void SumFromDatagrid()
        {
            dgv_Purchase_Bill.AllowUserToAddRows = false;
            int sum = 0 ;
            float SA = 0;
          
            for (int i = 0; i <= dgv_Purchase_Bill.Rows.Count - 1; i++)
            {
                sum = sum + int.Parse(dgv_Purchase_Bill.Rows[i].Cells[3].Value.ToString());
            }
            tb_Unit2.Text = sum.ToString();


            for (int i = 0; i <= dgv_Purchase_Bill.Rows.Count - 1; i++)
            {
                SA =SA + float.Parse(dgv_Purchase_Bill.Rows[i].Cells[7].Value.ToString());
            }
            tb_G_Amount.Text = SA.ToString();


        }

        #endregion



        #region Selected_Index_Changed
        private void cmb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Product.Text != "")
            {
                GFOBJ.ConnectDb();

                SqlCommand cmd = new SqlCommand("select Purchase_Price , GST from Product_Table where Name = '" + cmb_Product.Text + "' ",GFOBJ.con);

                var obj = cmd.ExecuteReader();

                if(obj.Read())
                {
                    tb_Rate.Text = (obj["Purchase_Price"].ToString()) ;
                    tb_SGst.Text = (obj["GST"].ToString());

                    tb_Unit.Text = "";
                    tb_Amount.Text = "";
                    tb_P_Total_Amt.Text = "";

                }
                else
                {
                    MessageBox.Show("Invalid Product Name!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_Product.Focus();

                }

                GFOBJ.DisconnectDb();
            }
            else
            {
                MessageBox.Show("Fill Product Name 1st", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region IS_Numberic

        private void IS_Numberic(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

          
        }
        #endregion

        #region Product_Total_Amt

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

                tb_P_Total_Amt.Text = TAmt.ToString();
               
            
            }
        }
        #endregion

        #region Insert_To_DataGridView


        private void tb_P_Total_Amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int no = Convert.ToInt32(tb_Sr_No.Text);
                

                if(no == selectedrow)

                
                {
                    selectedrow--;
                    DataGridViewRow newdatarow = dgv_Purchase_Bill.Rows[selectedrow];
                    newdatarow.Cells[1].Value = cmb_Product.SelectedItem;
                    newdatarow.Cells[2].Value = dtp_Expiry.Text;
                    newdatarow.Cells[3].Value = tb_Unit.Text;
                    newdatarow.Cells[4].Value = tb_Rate.Text;
                    newdatarow.Cells[5].Value = tb_SGst.Text;
                    newdatarow.Cells[6].Value = tb_Amount.Text;
                    newdatarow.Cells[7].Value = tb_P_Total_Amt.Text;

                    cmb_Product.Text = "";
                    tb_Unit.Text = "";
                    tb_Rate.Text = "";
                    tb_SGst.Text = "";
                    tb_Amount.Text = "";
                    tb_P_Total_Amt.Text = "";


                    int Sr = dgv_Purchase_Bill.Rows.Count;
                    Sr++;
                    tb_Sr_No.Text = Sr.ToString();
                    cmb_Product.Focus();
                    SumFromDatagrid();
                   
                }
                else
                {
                    dgv_Purchase_Bill.Rows.Add(tb_Sr_No.Text, cmb_Product.SelectedItem, dtp_Expiry.Text, tb_Unit.Text, tb_Rate.Text, tb_SGst.Text, tb_Amount.Text, tb_P_Total_Amt.Text);

                    cmb_Product.Text = "";
                    tb_Unit.Text = "";
                    tb_Rate.Text = "";
                    tb_SGst.Text = "";
                    tb_Amount.Text = "";
                    tb_P_Total_Amt.Text = "";


                    int Sn = Convert.ToInt32(tb_Sr_No.Text);
                    Sn = 1 + Sn;
                    tb_Sr_No.Text = Sn.ToString();
                    cmb_Product.Focus();

                    SumFromDatagrid();
                }

               
                
            }
        }
        #endregion

        #region Total_Amt

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

        #region Insert_To_Database

        private void Btn_Save_Click(object sender, EventArgs e)
        {


            if(cmb_Distrubutor.Text !="" && tb_Unit2.Text != "" && tb_G_Amount.Text != "" && tb_Discount.Text != "" && tb_Total_Amt.Text != "")
            {
               
                
               
                for (int i = 0; i < dgv_Purchase_Bill.Rows.Count; i++ )
                {
                    GFOBJ.ConnectDb();

                    int c;
                    SqlCommand cmd1 = GFOBJ.con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from Available_Stock_Table  where Product_Name = '" + dgv_Purchase_Bill.Rows[i].Cells[1].Value + "' ";
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    c = Convert.ToInt32(dt1.Rows.Count.ToString());
                    

                    if (c == 1)
                  {
                      GFOBJ.FillTableDB("Insert Into Purchase_Stock_Table(Product,Expiry,Unit,Rate,GST,Amount,Total_Amount) values ('" + dgv_Purchase_Bill.Rows[i].Cells[1].Value + "','" + dgv_Purchase_Bill.Rows[i].Cells[2].Value + "'," + dgv_Purchase_Bill.Rows[i].Cells[3].Value + "," + dgv_Purchase_Bill.Rows[i].Cells[4].Value + "," + dgv_Purchase_Bill.Rows[i].Cells[5].Value + "," + dgv_Purchase_Bill.Rows[i].Cells[6].Value + "," + dgv_Purchase_Bill.Rows[i].Cells[7].Value + ")");

                      GFOBJ.Update_Table("Update Available_Stock_Table set Unit = Unit + " + dgv_Purchase_Bill.Rows[i].Cells[3].Value + " where Product_Name = '" + dgv_Purchase_Bill.Rows[i].Cells[1].Value + "' ");

                      GFOBJ.FillTableDB("Insert   Into Supplier_Puchase_Table(Distributor,Date,Unit,Gross_Amount,Discount,Total_Amount) values('" + cmb_Distrubutor.Text + "','" + dtp_Date.Text + "'," + tb_Unit2.Text + "," + tb_G_Amount.Text + "," + tb_Discount.Text + "," + tb_Total_Amt.Text + ")");
                      
                      GFOBJ.DisconnectDb();

                  }
                  else 
                  {
                      GFOBJ.FillTableDB("Insert Into Purchase_Stock_Table(Product,Expiry,Unit,Rate,GST,Amount,Total_Amount) values ('" + dgv_Purchase_Bill.Rows[i].Cells[1].Value + "','" + dgv_Purchase_Bill.Rows[i].Cells[2].Value + "'," + dgv_Purchase_Bill.Rows[i].Cells[3].Value + "," + dgv_Purchase_Bill.Rows[i].Cells[4].Value + "," + dgv_Purchase_Bill.Rows[i].Cells[5].Value + "," + dgv_Purchase_Bill.Rows[i].Cells[6].Value + "," + dgv_Purchase_Bill.Rows[i].Cells[7].Value + ")");

                      GFOBJ.FillTableDB("Insert Into Available_Stock_Table (Product_Name,Unit) values ('" + dgv_Purchase_Bill.Rows[i].Cells[1].Value + "'," + dgv_Purchase_Bill.Rows[i].Cells[3].Value + ")");

                      GFOBJ.FillTableDB("Insert   Into Supplier_Puchase_Table(Distributor,Date,Unit,Gross_Amount,Discount,Total_Amount) values('" + cmb_Distrubutor.Text + "','" + dtp_Date.Text + "'," + tb_Unit2.Text + "," + tb_G_Amount.Text + "," + tb_Discount.Text + "," + tb_Total_Amt.Text + ")");

                      GFOBJ.DisconnectDb();
                  }
                    

                }

                MessageBox.Show("Record Successfully Added", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgv_Purchase_Bill.Rows.Clear();
                cmb_Distrubutor.Text = "";
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

            GFOBJ.DisconnectDb();
        }


        #endregion

        #region datagridtotextbox

        private void dgv_Purchase_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = dgv_Purchase_Bill.Rows[selectedrow];
            tb_Sr_No.Text = row.Cells[0].Value.ToString();
            cmb_Product.Text = row.Cells[1].Value.ToString();
            dtp_Expiry.Text = row.Cells[2].Value.ToString();
            // tb_Unit.Text = row.Cells[3].Value.ToString();
            tb_Rate.Text = row.Cells[4].Value.ToString();
            tb_SGst.Text = row.Cells[5].Value.ToString(); 
            tb_Amount.Text = row.Cells[6].Value.ToString();
            tb_P_Total_Amt.Text = row.Cells[7].Value.ToString();
            selectedrow++;



        }
        #endregion


    }
}
