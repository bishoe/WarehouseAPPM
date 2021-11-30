using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WarehouseAPPM.ds;

namespace WarehouseAPPM.Classes
{
    static class FunReports
    {
        public static DataSet1 FunReportWITHTEXTBOX(string SpName, string ParamName,int ParamValue, string DataTableName )
        {
            using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
            {

            
            using (SqlCommand cmd = new SqlCommand())
            {


                cmd.CommandText = SpName;

                SqlDataAdapter DataAdapter = new SqlDataAdapter();
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(ParamName ,ParamValue);

                DataAdapter.SelectCommand = cmd;
                using (DataSet1 DataSet = new DataSet1())
                {
                    //nameDATATABLE in dataset
                    DataAdapter.Fill(DataSet, DataTableName);
                    return DataSet;
                }
            }
        }
    }
        /// <summary>
        /// Get Data From Stored Procuder
        /// </summary>
        /// <param name="SpName">procuder Name</param>
        /// <param name="ParamName">Param name</param>
        /// <param name="comboBox">Value from combobox</param>
        /// <param name="DataTableName">DataTableName in DataSet</param>
        /// <returns></returns>
        //public static DataSetTable FunReportWithDate(string SpName, string ParamName, DateTimePicker  dateTimePicker, string DataTableName)
        //{

        //    cmd.CommandText = SpName;

        //    SqlDataAdapter DataAdapter = new SqlDataAdapter();
        //    cmd.Parameters.Clear();
        //    cmd.Connection = conn;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue(ParamName,Convert.ToDateTime( dateTimePicker.Value.ToString()));

        //    DataAdapter.SelectCommand = cmd;
        //    using (DataSetTable DataSet = new DataSetTable())
        //    {
        //        //nameDATATABLE in dataset
        //        DataAdapter.Fill(DataSet, DataTableName);
        //        return DataSet;
        //    }
        //}




        /// <summary>
        /// 
        /// </summary>
        /// <param name="SpName"></param>
        /// <param name="ParamName"></param>
        /// <param name="dateTimePicker"></param>
        /// 
        /// <param name="ParamNamese">ParamNameseconde</param>
        /// <param name="dateTimePicker"></param>
        /// <param name="comboBox">comboBox</param>
        /// <returns></returns>
        //public static DataSetTable FunReportWithtwoparam(string SpName, string ParamName, DateTimePicker dateTimePicker, string ParamNamese,ComboBox comboBox , string DataTableName)
        //{

        //    cmd.CommandText = SpName;

        //    SqlDataAdapter DataAdapter = new SqlDataAdapter();
        //    cmd.Parameters.Clear();
        //    cmd.Connection = conn;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue(ParamName, Convert.ToDateTime(dateTimePicker.Value.ToString())) ;
        //    cmd.Parameters.AddWithValue(ParamNamese,Convert.ToInt32(comboBox.SelectedValue.ToString()));



        //    DataAdapter.SelectCommand = cmd;
        //    using (DataSetTable DataSet = new DataSetTable())
        //    {
        //        //nameDATATABLE in dataset
        //        DataAdapter.Fill(DataSet, DataTableName);
        //        return DataSet;
        //    }
        //}


        //public static DataSetTable FunReportWithTextBox(string SpName, string ParamName, TextBox textBox, string DataTableName)
        //{

        //    cmd.CommandText = SpName;

        //    SqlDataAdapter DataAdapter = new SqlDataAdapter();
        //    cmd.Parameters.Clear();
        //    cmd.Connection = conn;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue(ParamName, int.Parse(textBox.Text));

        //    DataAdapter.SelectCommand = cmd;
        //    using (DataSetTable DataSet = new DataSetTable())
        //    {
        //        //nameDATATABLE in dataset
        //        DataAdapter.Fill(DataSet, DataTableName);
        //        return DataSet;
        //    }
        //}

        //public static DataSetTable FunReportNoParam(string SpName, string DataTableName)
        //{

        //    cmd.CommandText = SpName;

        //    SqlDataAdapter DataAdapter = new SqlDataAdapter();
        //    cmd.Parameters.Clear();
        //    cmd.Connection = conn;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    //cmd.Parameters.AddWithValue(ParamName, int.Parse(comboBox.SelectedValue.ToString()));

        //    DataAdapter.SelectCommand = cmd;
        //    using (DataSetTable DataSet = new DataSetTable())
        //    {
        //        //nameDATATABLE in dataset
        //        DataAdapter.Fill(DataSet, DataTableName);
        //        return DataSet;
        //    }
        //}

        //public static ReportDocument ReportD(CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer ) {
        //    ReportDocument crystalReport = new ReportDocument();
        //    TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

        //    TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();

        //    ConnectionInfo crConnectionInfo = new ConnectionInfo();
        //    string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\Reports\CRPAllCustomer.rpt";

        //    Tables CrTables;
        //    crystalReport.Load(filename);

        //    //crConnectionInfo.ServerName = "DESKTOP-CSKLGRC";

        //    //crConnectionInfo.DatabaseName = "Warehouse";

        //    //crConnectionInfo.UserID = "sa";

        //    //crConnectionInfo.Password = "123456";


        //    CrTables = crystalReport.Database.Tables;

        //    foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)

        //    {

        //        crtableLogoninfo = CrTable.LogOnInfo;

        //        crtableLogoninfo.ConnectionInfo = crConnectionInfo;

        //        CrTable.ApplyLogOnInfo(crtableLogoninfo);

        //    }

        //    crystalReportViewer.ReportSource = crystalReport;
        //    crystalReportViewer.Refresh();
        //    return null;
        //}
    }


}