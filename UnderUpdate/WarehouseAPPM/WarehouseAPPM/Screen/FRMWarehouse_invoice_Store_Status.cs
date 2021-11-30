using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Screen
{
    public partial class FRMWarehouse_invoice_Store_Status : MetroFramework.Forms.MetroForm
    {
        public FRMWarehouse_invoice_Store_Status()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private SqlCommand cmd1;
        private SqlCommand cmd2;
        private SqlDataAdapter adp1;
        DataSet ds;

        private int PageSize = 10;
        private int CurrentPageIndex = 1;
        private int TotalPage = 0;

        private void _Warehouse_invoice_Store_Status_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.; database=Warehouse; Persist Security Info=false; Integrated Security=true;");
            cmd1 = new SqlCommand("select * from _Warehouse_invoice_Store_Status where _Warehouse_invoice_Store_Status.PAIDAMOUNT != RemainingAMOUNT order by ID", con);
            ds = new DataSet();
            adp1 = new SqlDataAdapter(cmd1);
            adp1.Fill(ds, "_Warehouse_invoice_Store_Status");


             
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "_Warehouse_invoice_Store_Status";

            // WORK IN PAGING FOR DATAGRIDVIEW
            // Get total count of the pages; 
            this.CalculateTotalPages();
            this.dataGridView1.ReadOnly = true;
            // Load the first page of data; 
            this.dataGridView1.DataSource = GetCurrentRecords(1, con);
        }
        private void CalculateTotalPages()
        {
            int rowCount = ds.Tables["_Warehouse_invoice_Store_Status"].Rows.Count;
            this.TotalPage = rowCount / PageSize;
            if (rowCount % PageSize > 0) // if remainder is more than  zero 
            {
                this.TotalPage += 1;
            }
        }
        private DataTable GetCurrentRecords(int page, SqlConnection con)
        {
            DataTable dt = new DataTable();

            if (page == 1)
            {
                cmd2 = new SqlCommand("Select TOP " + PageSize + " * from _Warehouse_invoice_Store_Status where _Warehouse_invoice_Store_Status.PAIDAMOUNT != RemainingAMOUNT order by ID", con);
            }
            else
            {
                int PreviouspageLimit = (page - 1) * PageSize;

                cmd2 = new SqlCommand("Select TOP " + PageSize +
                    " * from _Warehouse_invoice_Store_Status " +
                    "where _Warehouse_invoice_Store_Status.PAIDAMOUNT !=RemainingAMOUNT and ID NOT IN " +
                "(Select TOP " + PreviouspageLimit + " ID from _Warehouse_invoice_Store_Status ORDER BY ID) ", con); // +
                //"order by customerid", con);
            }
            try
            {
                // con.Open();
                this.adp1.SelectCommand = cmd2;
                this.adp1.Fill(dt);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        private void btnFirstPAge_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = 1;
            this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, con);
        }

        private void btnNxtPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex < this.TotalPage)
            {
                this.CurrentPageIndex++;
                this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, con);
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, con);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = TotalPage;
            this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, con);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtbillno.Text = row.Cells[2].Value.ToString();
                txtMstoreID.Text = row.Cells[1].Value.ToString();
                txtRemainingAMOUNT.Text = row.Cells[4].Value.ToString();
                //...
            }

         }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            _ExecuteNonquery.executeNonquery
  ("_Warehouse_invoice_Store_StatusUpdate",
              new _Parameter("@MStoreId", SqlDbType.Int,Convert.ToInt32(  txtMstoreID.Text))
            , new _Parameter("@PAIDAMOUNT", SqlDbType.Decimal,Convert.ToDecimal( txtPAIDAMOUNT.Text)),

                        new _Parameter("@UserID", SqlDbType.Int, Login_.Userid));



        }

        private void txtPAIDAMOUNT_TabIndexChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(txtPAIDAMOUNT);

        }
    }
}
