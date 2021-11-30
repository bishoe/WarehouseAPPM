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
    public partial class FRM_SearchAll_InvoiceSelling : MetroFramework.Forms.MetroForm
    {
        public FRM_SearchAll_InvoiceSelling()
        {
            InitializeComponent(); this.dataGridViewPaging1.DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewPaging1.RequestQueryData += DataGridViewPaging_RequestQueryData;
            dataGridViewPaging1.Initialize(count());
        }

        private void FRM_SearchAll_InvoiceSelling_Load(object sender, EventArgs e)
        {

        }
        private int count()
        {
            using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
            {
                con.Open();
                using (var command = con.CreateCommand())
                {
                    command.CommandText = " SELECT      COUNT(*) from Warehouse_Selling";
                    var reader = command.ExecuteScalar();
                    return Convert.ToInt32(reader);
                }
            }
        }
        private void DataGridViewPaging_RequestQueryData(object sender, RequestQueryDataEventArgs e)
        {
            _SearchAll_Invoice.GETALLInVoice_(dataGridViewPaging1, "_Warehosue_Select_ALL_invoiceSelling", CommandType.StoredProcedure,
                new _Parameter("@PageOffset", SqlDbType.Int, e.PageOffset)
                ,
                new _Parameter("@MaxRecords", SqlDbType.Int, e.MaxRecords));
        }
    }
}
