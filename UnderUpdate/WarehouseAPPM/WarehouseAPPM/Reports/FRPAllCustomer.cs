using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM.ds;
using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Reports
{
    public partial class FRPAllCustomer : MetroFramework.Forms.MetroForm
    {
        public FRPAllCustomer()
        {
            InitializeComponent();
        }

        private void FRPAllCustomer_Load(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBSearch, "_WarehouseSelectAll_Customers", "CName", "CustomersID");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _ALLReportDocumentFunc.AllReportS(crystalReportViewer1, "CRPAllCustomer.rpt");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ReportDocument crystalReport = new ReportDocument();
string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\Reports\CRPCustomerID.rpt";
            crystalReport.Load(filename);

            DataSet1 dsMembe_IN=          GETREportWithMultipleParam.GetDataWithMultiParam("_WarehouseSelectAll_CustomersById", "WarehouseCustomers", new _Parameter("@CustomersID", SqlDbType.Int, int.Parse(CMBSearch.SelectedValue.ToString())));
            //DataSet1 dsMembe_IN = FunReports.FunReport("_WarehouseSelectAll_CustomersById", "@CustomersID", CMBSearch, "WarehouseCustomers");
            crystalReport.SetDataSource(dsMembe_IN);
            crystalReportViewer1.ReportSource = crystalReport;
        }
    }
}
