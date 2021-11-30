using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
using WarehouseAPPM.Classes;
using WarehouseAPPM.ds;
using WarehouseAPPM.Reports;

namespace WarehouseAPPM.Screen
{
    public partial class FRM_SearchInWarehouseBYBillNo : MetroFramework.Forms.MetroForm
    {
        public FRM_SearchInWarehouseBYBillNo()
        {
            InitializeComponent();
        }
        //C:\Users\bishoe\Google Drive\UnderUpdate\WarehouseAPPM\WarehouseAPPM\Reports\CrystalReport3.rpt
        private void SearchInWarehouseBYBillNo_Load(object sender, EventArgs e)
        {
          
         

        }
        ComboBox comboBox = new ComboBox();
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ReportDocument crystalReport = new ReportDocument();
            string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\Reports\SearchInWarehouseBYBillNo.rpt";
            crystalReport.Load(filename);
            DataSet1 dsMembe_IN = FunReportWithTextBox("WarehouseinvoiceNOStore", "@BillNO", TXTBillNO, "WarehouseinvoiceNOStore");
            crystalReport.SetDataSource(dsMembe_IN);
            crystalReportViewer1.ReportSource = crystalReport;

        }
        public static DataSet1 FunReportWithTextBox(string SpName, string ParamName, MetroFramework.Controls.MetroTextBox textBox, string DataTableName)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = SpName;

            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            cmd.Parameters.Clear();
            cmd.Connection = DBConnect.conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(ParamName, int.Parse(textBox.Text));

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
