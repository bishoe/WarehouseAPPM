using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 using WarehouseAPPM.Screen;

namespace WarehouseAPPM.Classes
{
    public class _AutocompleteCombox
    {
        FRM_Customers customers = new FRM_Customers();
        //Customers customers = new Customers();
        //AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Warehouse;User ID=sa;password=123456");
        //string sql = "SELECT WarehouseCustomers.* FROM  WarehouseCustomers";

        //SqlDataAdapter da;
        //    public void AutoFillCMBCustomers(AutoCompleteStringCollection dataCollection)
        //    {

        //        string connetionString = null;
        //        SqlConnection connection;
        //        SqlCommand command;
        //        SqlDataAdapter adapter = new SqlDataAdapter();
        //        DataSet ds = new DataSet();
        //        connetionString = "Data Source=.;Initial Catalog=Warehouse;User ID=sa;password=123456";
        //        string sql = "SELECT WarehouseCustomers.* FROM  WarehouseCustomers";
        //        connection = new SqlConnection(connetionString);
        //        try
        //        {
        //            connection.Open();
        //            command = new SqlCommand(sql, connection);
        //            adapter.SelectCommand = command;
        //            adapter.Fill(ds);
        //            adapter.Dispose();
        //            command.Dispose();
        //            connection.Close();
        //            foreach (DataRow row in ds.Tables[0].Rows)
        //            {
        //                dataCollection.Add(row[0].ToString());
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Can not open connection ! ");
        //        }
        //    }
        //}



        //        public void getData(AutoCompleteStringCollection dataCollection)
        //    {
        //        string connetionString = null;
        //        SqlConnection connection;
        //        SqlCommand command;
        //        SqlDataAdapter adapter = new SqlDataAdapter();
        //        DataSet ds = new DataSet();
        //        connetionString = "Data Source=.;Initial Catalog=Warehouse;User ID=sa;password=123456";
        //        string sql = "SELECT WarehouseCustomers.* FROM  WarehouseCustomers";

        //        connection = new SqlConnection(connetionString);
        //        try
        //        {
        //            connection.Open();
        //            command = new SqlCommand(sql, connection);
        //            adapter.SelectCommand = command;
        //            adapter.Fill(ds);
        //            adapter.Dispose();
        //            command.Dispose();
        //            connection.Close();
        //            foreach (DataRow row in ds.Tables[0].Rows)
        //            {
        //                dataCollection.Add(row[0].ToString());
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Can not open connection ! ");
        //        }
        //    }
        //}

        #region SearchData
        //public static void SearchCustomer(string SP,int CustomersID,string CName ,int Phone,string Address,DateTime WDate,string Notes)
        public static void SearchCustomer(string SP, int CustomersID, string CName)

        {

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = DBConnect.conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SP;
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@CustomersID", CustomersID);

            cmd.Parameters.AddRange(p);
            DBConnect.conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            if (reader.HasRows)
            {
                CustomersID = Convert.ToInt32(reader[0].ToString());
                //customers.textBox2.Text = reader[1].ToString();
                //Phone =Convert.ToInt32( reader[2].ToString());
                //Address = reader[3].ToString();
                //WDate =Convert.ToDateTime( reader[4].ToString());
                //Notes = reader[5].ToString();



            }
            else
            {
                //Error err = new Error();
                //err.Show();

            }
            cmd.Dispose();
            reader.Close();

            DBConnect.conn.Close();

        }
        #endregion

    }
}
