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
//using WarehouseAPPM.Classes;
/// <summary>
/// Using version 1.0 from SimpleDataGridViewPaging 
/// link video
/// https://www.youtube.com/watch?v=7x0UyW6NFmU
/// </summary>
namespace WarehouseAPPM.Screen
{
    public partial class FRM_SearchAll_InvoiceStore : MetroFramework.Forms.MetroForm
    {
        public FRM_SearchAll_InvoiceStore()
        {
            InitializeComponent();
            //this.dataGridViewPaging1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridViewPaging1.DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewPaging1.RequestQueryData += DataGridViewPaging_RequestQueryData;
            dataGridViewPaging1.Initialize(count());
        }

        private void FRM_SearchAll_InvoiceStore_Load(object sender, EventArgs e)
        {
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
                new _Parameter("@MaxRecords", SqlDbType.Int,e.MaxRecords)); 
                }
            }

        }
              




    