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
    public partial class FRPInvoiceSelling_Print : MetroFramework.Forms.MetroForm
    {
        public FRPInvoiceSelling_Print()
        {
            InitializeComponent();
        }

private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(TXTInvoiceID.Text == string.Empty)
            {
                MessageBox.Show("","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else { 
            ReportDocument crystalReport = new ReportDocument();
            string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\Reports\CRPInvoiceSelling_Print.rpt";
            crystalReport.Load(filename);

            DataSet1 dsMembe_IN = GETREportWithMultipleParam.GetDataWithMultiParam("_Warehouse_InvoiceSelling_Print", "_Warehouse_InvoiceSelling_Print", new _Parameter("@Selling_MasterID", SqlDbType.Int, int.Parse(TXTInvoiceID.Text)));
            crystalReport.SetDataSource(dsMembe_IN);
            crystalReportViewer1.ReportSource = crystalReport;
        }
        }

        private void FRPInvoiceSelling_Print_Load(object sender, EventArgs e)
        {

        }

        private void TXTInvoiceID_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(TXTInvoiceID);
        }
    }
}
