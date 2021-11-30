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
using WarehouseAPPM.Classes;
using WarehouseAPPM.ds;
//using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Reports
{
    public partial class FRPAllQutaly : MetroFramework.Forms.MetroForm
    {
        public FRPAllQutaly()
        {
            InitializeComponent();
        }

        private void FRPAllQutaly_Load(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBSearch, "_WarehouseSelectAllQutaly", "QName", "QutalyID");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //ReportWithId.ReportWit_ID("", "_Warehouse_Select_QutalBYID", "@QutalyID", crystalReportViewer1);
            ReportDocument crystalReport = new ReportDocument();
            string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\Reports\CRPQutalBYID.rpt";
            crystalReport.Load(filename);

            DataSet1 dsMembe_IN = GETREportWithMultipleParam.GetDataWithMultiParam("_Warehouse_Select_QutalBYID", "Qutaly", new _Parameter("@QutalyID", SqlDbType.Int, int.Parse(CMBSearch.SelectedValue.ToString())));
            //DataSet1 dsMembe_IN = FunReports.FunReport("_WarehouseSelectAll_CustomersById", "@CustomersID", CMBSearch, "WarehouseCustomers");
            crystalReport.SetDataSource(dsMembe_IN);
            crystalReportViewer1.ReportSource = crystalReport;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _ALLReportDocumentFunc.AllReportS(crystalReportViewer1, "CRPALLOutLay.rpt");

        }
    }
}
