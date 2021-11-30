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
 
namespace WarehouseAPPM
{
    public partial class CategoryProducts : MetroFramework.Forms.MetroForm
    {
        public CategoryProducts()
        {
            InitializeComponent();
        }

        private void CategoryProducts_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            _TxtClear.TxtClear(this, PanelMain);
            BtnSave.Enabled = true;

        }

        private void CMBSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //if (txtCategoryName.Text == string.Empty)
            //{

            //    return;
            //}
            //else
            //{
            _ExecuteNonquery.executeNonquery("Warehouse_UpdateCategory_Product"
              ,
new _Parameter("@IdCategoryProduct", SqlDbType.Int, Convert.ToInt32(CMBSearch.SelectedValue.ToString())),

            new _Parameter("@CategoryName", SqlDbType.NVarChar, TXTName.Text)

           );

            //}
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {

            if (CMBSearch.SelectedValue == null)
            {

                return;
            }
            else
            {
                _ExecuteNonquery.executeNonquery("_Warehouse_delCategoryProduct",
        new _Parameter("@IdCategoryProduct", SqlDbType.Int, int.Parse(CMBSearch.SelectedValue.ToString()))

        );
            }
        }

        private void BTNEDit_Click(object sender, EventArgs e)
        {
            if (TXTName.Text == string.Empty)
            {

                return;
            }
            else
            {
                _ExecuteNonquery.executeNonquery("Warehouse_UpdateCategory_Product"
              ,
new _Parameter("@IdCategoryProduct", SqlDbType.Int, Convert.ToInt32(CMBSearch.SelectedValue.ToString())),

            new _Parameter("@CategoryName", SqlDbType.NVarChar, TXTName.Text)

           );

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CMBSearch.Text != string.Empty)
            {
                DataTable dt = new DataTable();

                dt = _Executequerysearch.executequerysearch("Warehouse_CategoryProductByid", CommandType.StoredProcedure, new _Parameter

                    ("@IdCategoryProduct", SqlDbType.Int, int.Parse(CMBSearch.SelectedValue.ToString())));

                //lblIDCustomer.Text = dt.Rows[0]["CustomersID"].ToString();

                TXTName.Text = dt.Rows[0]["CategoryName"].ToString();

                daWDate.Value = Convert.ToDateTime(dt.Rows[0]["WDate"].ToString());
            }
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
                    _ExecuteNonquery.executeNonquery("Warehouse_Category_Product",
                new _Parameter("@CategoryName", SqlDbType.NVarChar, TXTName.Text)
              ,
                new _Parameter("@WDate", SqlDbType.Date, daWDate.Value),
                new _Parameter("@UsersID", SqlDbType.Int, Login_.Userid)
                );
                }
            }
            _TxtClear.TxtClear(this, PanelMain);
            BtnSave.Enabled = false;
        }

        private void TXTName_TextChanged(object sender, EventArgs e)
        {
            //_Textaccept_alphabetic._Textaccept(TXTName);

        }

        private void TXTName_Leave(object sender, EventArgs e)
        {


            _CheckExIsts.Check_exists("Warehouse_CategoryProduct", "CategoryName", "@CategoryName", TXTName.Text);
        }

        private void CMBSearch_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBSearch, "_WarehouseSelectAll_CategoryProduct", "CategoryName", "IdCategoryProduct");
        }

        private void TXTName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
