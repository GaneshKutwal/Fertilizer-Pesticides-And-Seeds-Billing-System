using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Agriculture_Service_Center
{
    class Global_Fun
    {
        #region DBConnection
        string connection = (@"Data Source=.\SQLEXPRESS;Initial Catalog=Agriculture_Service_Center_DB;Integrated Security=True");

        public SqlConnection con;
        public void ConnectDb()

        { 
           con = new SqlConnection(connection);

           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }

        }

        public void DisconnectDb()
        {
            con = new SqlConnection();

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        #endregion

        #region  Add_Value_In_DB

        public void FillTableDB(string Get_Query)
        {
          ConnectDb();

            SqlDataAdapter Sda = new SqlDataAdapter(Get_Query,con);

            DataTable dt = new DataTable();

            Sda.Fill(dt);

            Sda.Dispose();
            dt.Dispose();
        }
        #endregion

        #region AutoIncreament

        public int AutoIncreament(string Get_Current_ID1,string Get_Current_ID2,int StartNo)
        {
            int cnt = 0;

            ConnectDb();

            SqlCommand cmd = new SqlCommand(Get_Current_ID1, con);

            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            cnt += 1;

            cmd.Dispose();

            if (cnt > 0)
            {
                cmd.CommandText = Get_Current_ID2;
                cmd.Connection = con;

                cnt = Convert.ToInt32(cmd.ExecuteScalar());

                cnt += 1;

                cmd.Dispose();

                DisconnectDb();

            }
            else
            {
                cnt = +StartNo;
            }


            return cnt;
        }
        #endregion 

        #region  Update_Table

        public void Update_Table(string Get_U_Query)
        {
            ConnectDb();

            SqlDataAdapter Usda = new SqlDataAdapter(Get_U_Query,con);

            DataTable Udt = new DataTable();

            Usda.Fill(Udt);

            Usda.Dispose();
            Udt.Dispose();
        }

        #endregion

        #region  FillDataGridView

        public void FillDataGridView(String Query, DataGridView dgv)
        {
            ConnectDb();

            SqlDataAdapter sda = new SqlDataAdapter(Query,con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv.DataSource = dt;

            DisconnectDb();

        }

        #endregion


        #region DB_Name_Contain

        public string DB_Name_Contain(string CmdString, string ColumnValue)
        {
            string NameString = "";
            ConnectDb();

            SqlCommand cmd = new SqlCommand(CmdString, con);

            var Obj = cmd.ExecuteReader();
            if (Obj.Read())
            {
                NameString = Obj.GetString(Obj.GetOrdinal(ColumnValue));
            }

            cmd.Dispose();
            DisconnectDb();

            return NameString;
        }
        #endregion






    }
}
