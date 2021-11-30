using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms.Internal.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM.ds;
using WarehouseAPPM.Classes;
 
namespace WarehouseAPPM.Classes
{
    /// <summary>
    /// void View ReportWith 1 param
    /// using in reports Combobox 
    /// </summary>
  static  class ReportWithId
    {
        public static void ReportWit_ID(string rptName, string ProcName, string ParamName ,int Value, string DataTableName, CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1,    ComboBox comboBox =null)
        {
            ReportDocument crystalReport = new ReportDocument();
            string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0,

 

            Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\Reports\" + rptName + "";

            crystalReport.Load(filename);

            DataSet1 dsMembe_IN = FunReports.FunReportWITHTEXTBOX(ProcName, ParamName, Value, DataTableName);
            crystalReport.SetDataSource(dsMembe_IN);
            crystalReportViewer1.ReportSource = crystalReport;
        }
        //CRPSupplyRepresentativeID.rpt"
      //public static void SDF(string rptName, string ProcName, string ParamName, ComboBox comboBox, string DataTableName, CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1)
      //  {
      //      using(ReportDocument crystalReport = new ReportDocument()) { 
            
      //      string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\Reports\'" + rptName + "'";
                

      //      crystalReport.Load(filename);

      //      DataSet1 dsMembe_IN = GETREportWithMultipleParam.GetDataWithMultiParam(ProcName, DataTableName, 
      //          new _Parameter(ParamName, SqlDbType.Int, Convert.ToInt32(comboBox.SelectedValue.ToString())) 
      //          );
      //      crystalReport.SetDataSource(dsMembe_IN);
      //      crystalReportViewer1.ReportSource = crystalReport;
      //  }
      //  }
    }
}
