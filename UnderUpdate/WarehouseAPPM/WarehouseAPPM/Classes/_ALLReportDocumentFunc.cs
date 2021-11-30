//using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAPPM.Classes
{
   
  /////// <summary>
  /////// Load All Data e.g Allcustomers , AllEmployees
  /////// </summary>
  static class _ALLReportDocumentFunc
    {
        public static ReportDocument AllReportS(CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer, string reportName)
        {


            ReportDocument crystalReport = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();

            string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\Reports\" + reportName + "";

            ConnectionInfo crConnectionInfo = new ConnectionInfo();


            Tables CrTables;
            crystalReport.Load(filename);

            crConnectionInfo.ServerName = ".";

            crConnectionInfo.DatabaseName = "Warehouse";

            crConnectionInfo.UserID = "sa";

            crConnectionInfo.Password = "123456";


            CrTables = crystalReport.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)

            {

                crtableLogoninfo = CrTable.LogOnInfo;

                crtableLogoninfo.ConnectionInfo = crConnectionInfo;

                CrTable.ApplyLogOnInfo(crtableLogoninfo);

            }

            crystalReportViewer.ReportSource = crystalReport;
            crystalReportViewer.Refresh();
            return null;
        }
    }
}
