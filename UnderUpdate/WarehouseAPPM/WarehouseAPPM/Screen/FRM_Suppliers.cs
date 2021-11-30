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
    public partial class FRM_Suppliers : MetroFramework.Forms.MetroForm
    {
        public FRM_Suppliers()
        {
            InitializeComponent();
        }

        private void FRM_Suppliers_Load(object sender, EventArgs e)
        {

        }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            _TxtClear.TxtClear(this, PanelMain);
            BtnSave.Enabled = true;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _CheckTxt.CheckTxt(this, PanelMain);
            if (_CheckTxt._ResultValidate == 1)
            {

                return;
            }
            else
            {
                if (_CheckExIsts.Returnresult == true)
                {
                    MessageBox.Show("عفوا هذا السجل مسجل مسبقا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    _ExecuteNonquery.executeNonquery("_Warehouse_Suppliers",
                    new _Parameter("@SName", SqlDbType.NVarChar, TXTName.Text)
                  ,
                    new _Parameter("@Phone", SqlDbType.Int,int.Parse( txtphone.Text)),
 new _Parameter("@Address", SqlDbType.NVarChar, txtaddress.Text),
 new _Parameter("@Notes", SqlDbType.NVarChar, txtnote.Text),
                    new _Parameter("@WDate", SqlDbType.Date, daWDate.Value),
                    new _Parameter("@UsersID", SqlDbType.Int, Login_.Userid)
                    );
                }
            }
            _TxtClear.TxtClear(this, PanelMain);
            BtnSave.Enabled = false;
        }
        private void CMBSearch_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBSearch, "_WarehouseSelectAllSuppliers", "SName", "SuppliersID");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CMBSearch.Text != string.Empty)
            {
                DataTable dt = new DataTable();

                dt = _Executequerysearch.executequerysearch("_WarehouseSelectSuppliersById", CommandType.StoredProcedure, new _Parameter

                    ("@SuppliersID", SqlDbType.Int, int.Parse(CMBSearch.SelectedValue.ToString())));

                //lblIDCustomer.Text = dt.Rows[0]["CustomersID"].ToString();
                if (dt.Rows.Count > 0)
                {
TXTName.Text = dt.Rows[0]["SName"].ToString();

                daWDate.Value = Convert.ToDateTime(dt.Rows[0]["WDate"].ToString());
                txtphone.Text = dt.Rows[0]["Phone"].ToString();
                txtaddress.Text = dt.Rows[0]["Address"].ToString();
                txtnote.Text = dt.Rows[0]["Notes"].ToString();

                }
                else
                {
                    MessageBox.Show("عفوا لايوجد نتيجه");
                    return;
                }

            }
        }

        private void BTNEDit_Click(object sender, EventArgs e)
        {
            if (TXTName.Text == string.Empty || txtaddress.Text == string.Empty || txtphone.Text == string.Empty)
            {

                return;
            }
            else
            {
                _ExecuteNonquery.executeNonquery("Warehouse_UpdateSuppliers"
              ,
new _Parameter("@SuppliersID", SqlDbType.Int, Convert.ToInt32(CMBSearch.SelectedValue.ToString())),

            new _Parameter("@SName", SqlDbType.NVarChar, TXTName.Text),
           new _Parameter("@Phone", SqlDbType.Int, txtphone.Text),
 new _Parameter("@Address", SqlDbType.NVarChar, txtaddress.Text),
 new _Parameter("@Notes", SqlDbType.NVarChar, txtnote.Text),
                    new _Parameter("@WDate", SqlDbType.Date, daWDate.Value)
                  );
            }
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            if (CMBSearch.SelectedValue == null)
            {

                return;
            }
            else
            {
                _ExecuteNonquery.executeNonquery("Warehouse_delSuppliers",
        new _Parameter("@SuppliersID", SqlDbType.Int, int.Parse(CMBSearch.SelectedValue.ToString()))

        );
            }
        }

        private void TXTName_Leave(object sender, EventArgs e)
        {
            _CheckExIsts.Check_exists("Warehouse_Suppliers", "SName", "@SName", TXTName.Text);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
