using In.Sontx.SimpleDataGridViewPaging;
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

namespace WarehouseAPPM.Screen
{
    public partial class invoice_Store_Status : Form
    {
        public invoice_Store_Status()
        {
            InitializeComponent();
            this.dataGridViewPaging1.DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewPaging1.RequestQueryData += DataGridViewPaging_RequestQueryData;
            dataGridViewPaging1.Initialize(count());
        }
        private int count()
        {
            using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
            {
                con.Open();
                using (var command = con.CreateCommand())
                {
                    command.CommandText = " SELECT COUNT(*) from Warehouse_Store";
                    var reader = command.ExecuteScalar();
                    return Convert.ToInt32(reader);
                }
            }
        }
        _SearchAll_Invoice _SearchAll_InvoiceStore = new _SearchAll_Invoice();

        private void DataGridViewPaging_RequestQueryData(object sender, RequestQueryDataEventArgs e)
        {
            _SearchAll_Invoice.GETALLInVoice_(dataGridViewPaging1, "_Warehosue_Select_ALL_invoiceSTore", CommandType.StoredProcedure,
                new _Parameter("@PageOffset", SqlDbType.Int, e.PageOffset)
                ,
                new _Parameter("@MaxRecords", SqlDbType.Int, e.MaxRecords));
        }
    
    private void invoice_Store_Status_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewPaging1_Click(object sender, EventArgs e)
        {
            FRMPRINTBARCODE fRMPRINTBARCODE = new FRMPRINTBARCODE();
            fRMPRINTBARCODE.Show();
        }

        private void dataGridViewPaging1_DoubleClick(object sender, EventArgs e)
        {
            FRMPRINTBARCODE fRMPRINTBARCODE = new FRMPRINTBARCODE();
            fRMPRINTBARCODE.Show();

        }
    }
}
