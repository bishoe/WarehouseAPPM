using CrystalDecisions.CrystalReports.Engine;
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
using WarehouseAPPM.ds;

namespace WarehouseAPPM.Screen
{
    public partial class FRMPRINTBARCODE : MetroFramework.Forms.MetroForm
    {
        //Data Source =.; Initial Catalog = Warehouse; Integrated Security = True
        public FRMPRINTBARCODE()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            _AutoCompleTextBox._AutoCompleTextBox_("_Warehosue_Select_ProductBYBarcodePrint", "@Pname", TXTPRODUCTNAME.Text, TXTPRODUCTNAME);

        }
        //C:\Users\bishoe\source\repos\WindowsFormsApp5\WindowsFormsApp5\
        string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\Reports\barcode.rpt";

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnect.FUllConnection))
            {

           
            ReportDocument crystal = new ReportDocument();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from Warehouse_Store", sqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "StoreId");
            crystal.Load(filename);
            crystal.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crystal;
        }
 }
        private void button1_Click_1(object sender, EventArgs e)
        {
   
        }

        private void TXTPRODUCTNAME_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TXTPRODUCTNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dataTable = new DataTable();
                dataTable=_Executequerysearch.executequerysearch("_Warehosue_Select_ProductBarcodeBYNamePrint", CommandType.StoredProcedure, new _Parameter("@Pname", SqlDbType.NVarChar,TXTPRODUCTNAME.Text));
                if (dataTable.Rows.Count >0)
                {

                    TXTBarCode.Text = dataTable.Rows[0]["BarCodeText"].ToString();

                }
                else
                {
                    MessageBox.Show("ERR","ERR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void BTNPrint_Click(object sender, EventArgs e)
        {
            if(txtQT.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال عدد مرات الطباعه","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else { 
            ReportDocument crystal = new ReportDocument();
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Warehouse;Integrated Security=True");
            string sql = "SELECT BarCodeText,Pname FROM WatehouseProdoucts where BarCodeText='" + TXTBarCode.Text + "'";
            for (int i = 1; i < int.Parse(txtQT.Text); i++)
            {
                sql = sql + "Union All select BarCodeText,Pname from WatehouseProdoucts where BarCodeText='" + TXTBarCode.Text + "'";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            crystal.Load(filename);

            DataSet1 ds = new DataSet1();
            adapter.Fill(ds, "ProductCRPunderedt");//nametablein dataset
            crystal.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crystal;
        }
        }
    }
}
