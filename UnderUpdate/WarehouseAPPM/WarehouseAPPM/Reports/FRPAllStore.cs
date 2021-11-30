using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseApp.Classes;
using WarehouseApp.dataSet;

namespace WarehouseApp.Reports
{
    public partial class FRPAllStore : Form
    {
        public FRPAllStore()
        {
            InitializeComponent();
        }
        //private DataSet1 GetData()
        //{

       
            //DBConnect.cmd.CommandText = ("WarehouseAllStore");
            //using (SqlDataAdapter DataAdapter = new SqlDataAdapter())
            //{
            //    DBConnect.cmd.Parameters.Clear();
            //    DBConnect.cmd.Connection = DBConnect.conn;
            //    DBConnect.cmd.CommandType = CommandType.StoredProcedure;
            //    //DBConnect.cmd.Parameters.AddWithValue("@EmployeeId", int.Parse(cmbserach.SelectedValue.ToString()));

            //    DataAdapter.SelectCommand = DBConnect.cmd;
            //    using (DataSet1 DataSetStore = new DataSet1())
            //    {
            //        //nameDATATABLE in dataset
            //        DataAdapter.Fill(DataSetStore, "WarehouseAllStore");
            //        return DataSetStore;
            //    }
            //}


        //}

 

        private void FRPAllStore_Load(object sender, EventArgs e)
        {
            ReportDocument crystalReport = new ReportDocument();
            string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\Reports\CRpAllStore.rpt";
             crystalReport.Load(filename);
            DataSet1 dsMembe_IN = FunReports.FunReportNoParam("WarehouseAllStore", "WarehouseAllStore");
            crystalReport.SetDataSource(dsMembe_IN);
            crystalReportViewer1.ReportSource = crystalReport;
        }
    }
}
