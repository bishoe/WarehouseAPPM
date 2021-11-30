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
    public partial class FrmReturnProducts : MetroFramework.Forms.MetroForm
    {
    
        public FrmReturnProducts()
        {
            InitializeComponent(); this.dataGridViewPaging1.DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewPaging1.RequestQueryData += DataGridViewPaging_RequestQueryData;
            dataGridViewPaging1.Initialize(count());
        }
        private void FrmReturnProducts_Load(object sender, EventArgs e)
        {

        }
        private int count()
        {
            using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
            {
                con.Open();
                using (var command = con.CreateCommand())
                {
                    command.CommandText = " SELECT      COUNT(*) from Warehouse_ReturnProducts";
                    var reader = command.ExecuteScalar();
                    return Convert.ToInt32(reader);
                }
            }
        }

        private void DataGridViewPaging_RequestQueryData(object sender, RequestQueryDataEventArgs e)
        {
            _SearchAll_Invoice.GETALLInVoice_(dataGridViewPaging1, "_Warehosue_Select_ALL_ReturnProducts", CommandType.StoredProcedure,
                new _Parameter("@PageOffset", SqlDbType.Int, e.PageOffset)
                ,
                new _Parameter("@MaxRecords", SqlDbType.Int, e.MaxRecords));
        }
    }
}
