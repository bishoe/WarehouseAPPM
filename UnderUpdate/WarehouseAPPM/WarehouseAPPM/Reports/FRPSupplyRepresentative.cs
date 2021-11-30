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
    public partial class FRPSupplyRepresentative : MetroFramework.Forms.MetroForm
    {
         
        public FRPSupplyRepresentative()
        {
            InitializeComponent();
        }

        private void FRPSupplyRepresentative_Load(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(cmbserach, "_WarehouseSelectAllSuppliers", "SName", "SuppliersID");
                }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //_ReportNoParam. ("CRPSupplyRepresentativeID","")
            //SDF.
            //ReportWithId.SDF("CRPSupplyRepresentativeID", "_WarehouseSelectAll_Warehouse_SupplyRepresentativeID", "", cmbSupplyRepresentative, "", crystalReportViewer1);

            ReportDocument crystalReport = new ReportDocument();
            string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\Reports\CRPSupplyRepresentativeID.rpt";

            crystalReport.Load(filename);

            DataSet1 dsMembe_IN = GETREportWithMultipleParam.GetDataWithMultiParam("_WarehouseSelectAll_Warehouse_SupplyRepresentativeID", "Warehouse_SupplyRepresentative", new _Parameter("@SuppliersID", SqlDbType.Int, Convert.ToInt32(cmbserach.SelectedValue.ToString())),
                 new _Parameter("@SupplyRepID", SqlDbType.Int, Convert.ToInt32(cmbSupplyRepresentative.SelectedValue.ToString()))
                );
            crystalReport.SetDataSource(dsMembe_IN);
            crystalReportViewer1.ReportSource = crystalReport;
        }

        private void cmbserach_Leave(object sender, EventArgs e)
        {
            _AutoFillCMBWithPARAm.Bindcmb(cmbSupplyRepresentative, "_SelectSupplyRepresentativeBYsupply",
             "@Supplyid", Convert.ToInt32(cmbserach.SelectedValue.ToString()), "SRName", "SupplyRepID");
        }
    }
}
