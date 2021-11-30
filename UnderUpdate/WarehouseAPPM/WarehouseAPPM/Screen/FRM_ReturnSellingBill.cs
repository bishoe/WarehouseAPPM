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
    public partial class FRM_ReturnSellingBill : MetroFramework.Forms.MetroForm
    {
        decimal GetQuntity_Product;
        decimal CalcQT;
        public FRM_ReturnSellingBill()
        {
            InitializeComponent();
        }

        private void SearchSellingBill_Load(object sender, EventArgs e)
        {

        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            if (txtqt.Text == string.Empty || Lblproductid.Text == string.Empty || LBLSelling_MasterID.Text == string.Empty)
            {
                MessageBox.Show("عفوا يجب تحديد السجل المراد حذفه من الفاتورة اولا","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                BTNDelete.Enabled = false;
                return;
            }
            else
            {

                //under Test
                #region GETQT
                DataTable dataTable_ = new DataTable();
                //10
                dataTable_ = _Executequerysearch.executequerysearch("_Warehouse_Select_QuantityByProductid", CommandType.StoredProcedure, new _Parameter("@ProdouctsID", SqlDbType.Int, Convert.ToInt32(Lblproductid.Text)));
                if (dataTable_.Rows.Count == 0)
                {
                    MessageBox.Show("عفوا لايوجد نتيجه");
                }
                else
                {
                    GetQuntity_Product = Convert.ToInt32(dataTable_.Rows[0]["QuantityProduct"].ToString());
                    CalcQT = decimal.Parse(txtqt.Text) + GetQuntity_Product;
                }
                #endregion

                _ExecuteNonquery.executeNonquery("_WarehosueDelSelling",
                    new _Parameter("@Selling_MasterID", SqlDbType.Int, Convert.ToInt32(LBLSelling_MasterID.Text)),
                    new _Parameter
                    ("@QuantityProduct", SqlDbType.Decimal, CalcQT),
                    new _Parameter
                    ("@ProductID", SqlDbType.Int, Convert.ToInt32(Lblproductid.Text)));
            }
            txtqt.Text = string.Empty;
            Lblproductid.Text = string.Empty;
            LBLSelling_MasterID.Text = string.Empty;

        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text != string.Empty)
            {
                DataTable dt = new DataTable();

                dt = _Executequerysearch.executequerysearch("_Warehouse_InvoiceSelling_Print", CommandType.StoredProcedure, new _Parameter

                    ("@Selling_MasterID", SqlDbType.Int, int.Parse(txtsearch.Text)));

                //lblIDCustomer.Text = dt.Rows[0]["CustomersID"].ToString();

                //TXTName.Text = dt.Rows[0]["CategoryName"].ToString();
                if (dt.Rows.Count > 0)
                {
                    DGVSelling.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("عفوا السجل غير موجود","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void DGVSelling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("0","");
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = DGVSelling.Rows[index];
            txtqt.Text = selectedRow.Cells[4].Value.ToString();
            Lblproductid.Text = selectedRow.Cells[10].Value.ToString();
            LBLSelling_MasterID.Text = selectedRow.Cells[0].Value.ToString();
            BTNDelete.Enabled = true;
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
    }
}
