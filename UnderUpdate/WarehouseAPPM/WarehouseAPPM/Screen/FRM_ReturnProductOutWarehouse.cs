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

namespace WarehouseAPPM.Screen
{ 
    public partial class FRM_ReturnProductOutWarehouse : MetroFramework.Forms.MetroForm
    {
        public FRM_ReturnProductOutWarehouse()
        {
            InitializeComponent();
        }
        public        DataTable dt = new DataTable();
        decimal GetQuntity_Product;
        decimal GetCurrentQT_product;
        decimal GETUnitConvert;
        decimal CalcQTProductTOReturn;
        decimal CalcQT;
        int RowsCount;
        private void FRM_ReturnProductOutWarehouse_Load(object sender, EventArgs e)
        {

        }
        //WarehouseinvoiceNOStore
        private void BTNSearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text != string.Empty)
            {

                dt = _Executequerysearch.executequerysearch("WarehouseinvoiceNOStore", CommandType.StoredProcedure, new _Parameter

                    ("@BillNO", SqlDbType.Int, int.Parse(txtsearch.Text)));

                //lblIDCustomer.Text = dt.Rows[0]["CustomersID"].ToString();

                //TXTName.Text = dt.Rows[0]["CategoryName"].ToString();
                if (dt.Rows.Count > 0)
                {
                    DGV.DataSource = dt;
                 RowsCount    = DGV.Rows.Count;
                }
                else
                {
                    MessageBox.Show("عفوا السجل غير موجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
            }

        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            if (txtwarehouse.Text == string.Empty || Lblproductid.Text == string.Empty || LBLBillno.Text == string.Empty)
            {
                MessageBox.Show("عفوا يجب تحديد السجل المراد حذفه من الفاتورة اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BTNDelete.Enabled = false;
                return;
            }
            else
            {
 GetQuntity_Product = Convert.ToDecimal(TxtQtreturn.Text);
 CalcQTProductTOReturn = GetQuntity_Product * GETUnitConvert;
 GetCurrentQT_product = Convert.ToDecimal( txtQuntitProduct.Text);
  CalcQT =(GetCurrentQT_product) -(CalcQTProductTOReturn)  ;
 if (CalcQTProductTOReturn > GetCurrentQT_product)
 {
 MessageBox.Show("عفوا الكميه المشتراه اكبر من الكميه الموجوده بالمخزن","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
 return;
 }
 else {
                    for (int i = 0; i < RowsCount; i++)
                    {

                    
 _ExecuteNonquery.executeNonquery("_WarehosueDelStore",
 new _Parameter("@Billno", SqlDbType.Int, Convert.ToInt32(LBLBillno.Text)),
 new _Parameter
 ("@QuantityProduct", SqlDbType.Decimal, CalcQT),
 new _Parameter
 ("@QtStartPeriod", SqlDbType.Decimal, Convert.ToDecimal(DGV.Rows[i].Cells[6].Value.ToString())),
                     new _Parameter
                    ("@ProductID", SqlDbType.Int, Convert.ToInt32(Lblproductid.Text)),
                     new _Parameter("@QTReturn",SqlDbType.Decimal,Convert.ToDecimal(TxtQtreturn.Text)),
                     new _Parameter("@UserID",SqlDbType.Int, Login_.Userid) );
            }
            }
            }
            TxtQtreturn.Text = string.Empty;
            txtwarehouse.Text = string.Empty;
            Lblproductid.Text = string.Empty;
            LBLBillno.Text = string.Empty;
            txtQuntitProduct.Text= string.Empty;

            dt.Rows.Clear();
            //DGVSelling.Rows.Clear();
            //DGVSelling.Refresh();
        }

        private void DGVSelling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetQuntity_Product = 0;
            GetCurrentQT_product = 0;
            CalcQTProductTOReturn = 0;
            int index = e.RowIndex;// get the Row Index

            DataGridViewRow selectedRow = DGV.Rows[index];
             Lblproductid.Text = selectedRow.Cells[9].Value.ToString();
            LBLBillno.Text = selectedRow.Cells[1].Value.ToString();
           GETUnitConvert  =Convert.ToDecimal( selectedRow.Cells[12].Value.ToString());
            BTNDelete.Enabled = true;
            //under Test
            #region GETQT
            DataTable dataTable_ = new DataTable();
            dataTable_.Rows.Clear();
            //10
            dataTable_ = _Executequerysearch.executequerysearch("_WarehouseReturnProduct", CommandType.StoredProcedure, new _Parameter("@Billno", SqlDbType.Int, Convert.ToInt32(txtsearch.Text)));
            if (dataTable_.Rows.Count == 0)
            {
                MessageBox.Show("عفوا لايوجد نتيجه");
            }
            else
            {
                GetQuntity_Product = Convert.ToDecimal(dataTable_.Rows[index]["Quntity_Product"].ToString());
                GetCurrentQT_product = Convert.ToDecimal(dataTable_.Rows[index]["QuantityProduct"].ToString());
                txtwarehouse.Text = Convert.ToString(GetQuntity_Product);
                txtQuntitProduct.Text = Convert.ToString(GetCurrentQT_product);



            }
            #endregion
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DGVSelling_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void txtwarehouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(txtwarehouse);

        }

        private void txtwarehouse_KeyDown(object sender, KeyEventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(txtwarehouse);

        }

        private void txtwarehouse_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(txtwarehouse);

        }

        private void TxtQtreturn_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(TxtQtreturn);

        }
    }
}
