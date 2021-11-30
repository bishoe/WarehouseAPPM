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
    public partial class FRPALLPRODUCTS : MetroFramework.Forms.MetroForm
    {
        public FRPALLPRODUCTS()
        {
            InitializeComponent();
        }

        private void FRPALLPRODUCTS_Load(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            _ALLReportDocumentFunc.AllReportS(crystalReportViewer1, "CRPALLProducts.rpt");
        }
    }
}
