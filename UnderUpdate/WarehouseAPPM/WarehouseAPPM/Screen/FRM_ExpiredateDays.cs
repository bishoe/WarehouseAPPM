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

namespace WarehouseAPPM.Screen
{
    public partial class FRM_ExpiredateDays : MetroFramework.Forms.MetroForm
    {
        public FRM_ExpiredateDays()
        {
            InitializeComponent();
        }
        //int.Parse(txtDayes.Text)
        SqlConnection con;
        private SqlCommand cmd1;
        private SqlCommand cmd2;
        private SqlDataAdapter adp1;
        DataSet ds;

        private int PageSize = 10;
        private int CurrentPageIndex = 1;
        private int TotalPage = 0;
        private void LoadDaata()
        {
            con = new SqlConnection("Data Source=.; database=Warehouse; Persist Security Info=false; Integrated Security=true;");
            cmd1 = new SqlCommand("select Warehouse_Store.MStoreId as[فاتور المخزن],Warehouse_Store.Billno as [فاتورة التاجر],Warehouse_Store.ExpireDate as [تاريخ الانتهاء],WatehouseProdoucts.Pname as [المنتج],Warehouse_Store.Quntity_Product as [الكميه المشتراه],Warehouse_Store.Productiondate as [تاريخ الانتاج]from Warehouse_Master_Store ,Warehouse_Store,WatehouseProdoucts where DATEDIFF(D ,'" + DateTime.Now + "', Warehouse_Store.ExpireDate) <= '" + int.Parse(txtDayes.Text) + "' and Warehouse_Master_Store.StoreId = Warehouse_Store.MStoreId and WatehouseProdoucts.ProdouctsID = Warehouse_Store.ProdouctsID order by Warehouse_Master_Store.StoreId", con);
            ds = new DataSet();
            adp1 = new SqlDataAdapter(cmd1);
            adp1.Fill(ds, "Warehouse_Store");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Warehouse_Store";

            // WORK IN PAGING FOR DATAGRIDVIEW
            // Get total count of the pages; 
            this.CalculateTotalPages();
            this.dataGridView1.ReadOnly = true;
            // Load the first page of data; 
            this.dataGridView1.DataSource = GetCurrentRecords(1, con);
        }
        private void FRM_ExpiredateDays_Load(object sender, EventArgs e)
        {

        }
        private void CalculateTotalPages()
        {
            int rowCount = ds.Tables["Warehouse_Store"].Rows.Count;
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
                cmd2 = new SqlCommand("Select TOP " + PageSize + " Warehouse_Store.MStoreId as[فاتور المخزن],Warehouse_Store.Billno as [فاتورة التاجر],Warehouse_Store.ExpireDate as [تاريخ الانتهاء],WatehouseProdoucts.Pname as [المنتج],Warehouse_Store.Quntity_Product as [الكميه المشتراه],Warehouse_Store.Productiondate as [تاريخ الانتاج]from Warehouse_Master_Store ,Warehouse_Store,WatehouseProdoucts where DATEDIFF(D ,'" + DateTime.Now + "', Warehouse_Store.ExpireDate) <= '" + int.Parse(txtDayes.Text) + "' and Warehouse_Master_Store.StoreId = Warehouse_Store.MStoreId and WatehouseProdoucts.ProdouctsID = Warehouse_Store.ProdouctsID order by Warehouse_Master_Store.StoreId", con);
            }
            else
            {
                int PreviouspageLimit = (page - 1) * PageSize;

                cmd2 = new SqlCommand("Select TOP " + PageSize +
                    " * from Warehouse_Master_Store " +
                    "where   Warehouse_Master_Store.StoreId NOT IN " +
                "(Select TOP " + PreviouspageLimit + " Warehouse_Master_Store.StoreId from Warehouse_Master_Store ORDER BY Warehouse_Master_Store.StoreId) ", con); // +
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            LoadDaata();
        }

      

       
      

      

       

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtMstoreID.Text = row.Cells[0].Value.ToString();

                txtbillno.Text = row.Cells[1].Value.ToString();
                txtproduct.Text = row.Cells[3].Value.ToString();
                txtepiredate.Text = row.Cells[2].Value.ToString();
                //...
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirstPAge_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = 1;
            this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, con);

        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, con);
            }
        }

        private void btnNxtPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex < this.TotalPage)
            {
                this.CurrentPageIndex++;
                this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, con);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = TotalPage;
            this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, con);

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}