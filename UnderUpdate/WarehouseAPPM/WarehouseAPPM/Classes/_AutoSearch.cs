using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAPPM.Classes
{
  public  class _AutoSearch
    {
        public   void AutoSearchTextbox(TextBox textBox, string schema,string table)
        {
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            //getData(DataCollection, schema,table);

            textBox.AutoCompleteCustomSource = DataCollection;
        }

        ////private void getData(AutoCompleteStringCollection dataCollection, string schema, string table)
        ////{

        ////    SqlDataAdapter adapter = new SqlDataAdapter();
        ////    DataSet ds = new DataSet();
        ////    //string sql = "SELECT DISTINCT [fname] FROM [employee]";

        ////    RetriveData.executeNonquery("_AutoCompleteSearch", new _Parameter("@schema", SqlDbType.NVarChar, schema),
        ////        new _Parameter("@table", SqlDbType.NVarChar, table));

            
        ////    try
        ////    {
        ////        DBConnect.OpenConnection();

        ////        DBConnect.cmd = new SqlCommand();
        ////        adapter.SelectCommand = DBConnect.cmd;
        ////        adapter.Fill(ds);
        ////        adapter.Dispose();
        ////        DBConnect.cmd.Dispose();
        ////        DBConnect.OpenConnection();
        ////        foreach (DataRow row in ds.Tables[0].Rows)
        ////        {
        ////            dataCollection.Add(row[0].ToString());
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {

        ////        MessageBox.Show("Can not open connection ! " + ex.Message.ToString());
        ////    }
        ////}
        //private void getData(AutoCompleteStringCollection dataCollection, string schema, string table)
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataSet ds = new DataSet();
        //    string sql = "SELECT DISTINCT "+ schema + " FROM "+ table+"";




        //    DBConnect dBConnect = new DBConnect();
        //    try
        //    {
        //        //dBConnect.OpenConnection();
        //        dBConnect.cmd = new SqlCommand(sql, dBConnect.conn);
        //        adapter.SelectCommand = dBConnect.cmd;
        //        adapter.Fill(ds);
        //        adapter.Dispose();
        //        dBConnect.cmd.Dispose();
        //        //dBConnect.OpenConnection();
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            dataCollection.Add(row[0].ToString());
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show( ex.Message.ToString());
        //    }
        //}



    }
}
 

        
        
 
 
 

