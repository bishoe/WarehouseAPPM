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

namespace WarehouseAPPM.Reports
{
    public partial class FRPALLUSers : MetroFramework.Forms.MetroForm
    {
        public FRPALLUSers()
        {
            InitializeComponent();
        }

        private void FRPALLUSers_Load(object sender, EventArgs e)
        {
            _ALLReportDocumentFunc.AllReportS(crystalReportViewer1, "CRPALLUSers.rpt");

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //ALLReportDocumentFunc.AllReportS(crystalReportViewer1, "CRPALLUSers.rpt");

        }
    }
}
