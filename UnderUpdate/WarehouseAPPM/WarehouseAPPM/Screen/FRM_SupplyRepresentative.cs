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
    public partial class FRM_SupplyRepresentative : MetroFramework.Forms.MetroForm
    {
        public FRM_SupplyRepresentative()
        {
            InitializeComponent();
        }

        private void FRM_SupplyRepresentative_Load(object sender, EventArgs e)
        {

        }

        private void CMBSUPPLIERS_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBSUPPLIERS, "_WarehouseSelectAllSuppliers", "SName", "SuppliersID");
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

                    _ExecuteNonquery.executeNonquery("_Warehouse_SupplyRepresentative",
                    new _Parameter("@SuppliersID", SqlDbType.Int, Convert.ToInt32(CMBSUPPLIERS.SelectedValue.ToString())),
                    new _Parameter("@SRName", SqlDbType.NVarChar, txtname.Text),
                    new _Parameter("@Phone", SqlDbType.Int, txtphone.Text),
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

        private void CMBSearch_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CMBSearch.Text != string.Empty)
            {
                DataTable dt = new DataTable();

                dt = _Executequerysearch.executequerysearch("_WarehouseSelectALL_SupplyRepresentativeByID", CommandType.StoredProcedure, new _Parameter

                    ("@SupplyRepID", SqlDbType.Int, int.Parse(CMBSearch.SelectedValue.ToString())));

                //lblIDCustomer.Text = dt.Rows[0]["CustomersID"].ToString();

                txtname.Text = dt.Rows[0]["SRName"].ToString();

                daWDate.Value = Convert.ToDateTime(dt.Rows[0]["WDate"].ToString());
                txtphone.Text = dt.Rows[0]["Phone"].ToString();
                txtaddress.Text = dt.Rows[0]["Address"].ToString();
                txtnote.Text = dt.Rows[0]["Notes"].ToString();


                DataTable dt_ = new DataTable();
                dt_ = _Executequerysearch.executequerysearch("_WarehouseSelectSuppliersById", CommandType.StoredProcedure, new _Parameter

                            ("@SuppliersID", SqlDbType.Int, int.Parse(CMBSearch.SelectedValue.ToString())));
                CMBSUPPLIERS.Text = dt_.Rows[0]["SName"].ToString();
            }
        }

        private void BTNEDit_Click(object sender, EventArgs e)
        {
            if (txtname.Text == string.Empty || CMBSUPPLIERS.Text == string.Empty || txtaddress.Text == string.Empty || txtphone.Text == string.Empty || txtnote.Text == string.Empty)
            {

                return;
            }
            else
            {
                _ExecuteNonquery.executeNonquery("_Warehouse_UpdateSupplyRepresentative"
              ,
new _Parameter("@IdCategoryProduct", SqlDbType.Int, Convert.ToInt32(CMBSearch.SelectedValue.ToString())),

                 new _Parameter("@SuppliersID", SqlDbType.Int, Convert.ToInt32(CMBSUPPLIERS.SelectedValue.ToString())),
                    new _Parameter("@SRName", SqlDbType.NVarChar, txtname.Text),
                    new _Parameter("@Phone", SqlDbType.Int, txtphone.Text),
                    new _Parameter("@Address", SqlDbType.NVarChar, txtaddress.Text),
                    new _Parameter("@Notes", SqlDbType.NVarChar, txtnote.Text),
                    new _Parameter("@WDate", SqlDbType.Date, daWDate.Value),
                    new _Parameter("@UsersID", SqlDbType.Int, Login_.Userid));
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
                _ExecuteNonquery.executeNonquery("_Warehouse_delSupplyRepresentative",
        new _Parameter("@SupplyRepID", SqlDbType.Int, int.Parse(CMBSearch.SelectedValue.ToString()))

        );
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            _CheckExIsts.Check_exists("Warehouse_SupplyRepresentative", "SRName", "@SRName", txtname.Text);
        }

        private void CMBSUPPLIERSSEarch_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBSUPPLIERSSEarch, "_WarehouseSelectAllSuppliers", "SName", "SuppliersID");
        }

        private void CMBSUPPLIERSSEarch_Leave(object sender, EventArgs e)
        {
            _AutoFillCMBWithPARAm.Bindcmb(CMBSearch, "_WarehouseSelectALL_SupplyRepresentative", "@SuppliersID", Convert.ToInt32(CMBSUPPLIERSSEarch.SelectedValue.ToString()), "SRName", "SuppliersID");

        }
    }
}
