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
//using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Screen
{
    public partial class FRM_Customers : MetroFramework.Forms.MetroForm
    {
        public FRM_Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
          
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            _CheckTxt.CheckTxt(this, PaneMain);
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


                    _ExecuteNonquery.executeNonquery("_WarehouseCustomers", new _Parameter("@CName", SqlDbType.NVarChar, TXTName.Text)
                   , new _Parameter("@Phone", SqlDbType.Int, Convert.ToInt32(TXTPHONE.Text))
                   ,
                   new _Parameter("@Address", SqlDbType.NVarChar, TXTADDress.Text),
                   new _Parameter("@WDate", SqlDbType.DateTime, DTP.Value),
                   new _Parameter("@Notes", SqlDbType.NVarChar, TXTNOTE.Text),
                    new _Parameter("@UsersID", SqlDbType.Int, Login_.Userid));
                }
                //_TxtClear.TxtClear(this, PaneMain);
                //new parameter("@Userid", SqlDbType.Int, LoginInfo.Userid));
                _TxtClear.TxtClear(this, PaneMain);
                BTNSAVE.Enabled = false;
            }

        }

        private void TXTName_Click(object sender, EventArgs e)
        {

        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            if (TXTName.Text == string.Empty)
            {

                return;
            }
            else
            {

                _ExecuteNonquery.executeNonquery
                ("_WarehouseUpdateCustomers",
                new _Parameter("@CustomersID", SqlDbType.Int, int.Parse(CMBCustomers.SelectedValue.ToString()))
               ,
                new _Parameter("@CName", SqlDbType.NVarChar, TXTName.Text)
               , new _Parameter("@Phone", SqlDbType.Int, Convert.ToInt32(TXTPHONE.Text))
               ,
               new _Parameter("@Address", SqlDbType.NVarChar, TXTADDress.Text),
               new _Parameter("@WDate", SqlDbType.DateTime, DTP.Value),
               new _Parameter("@Notes", SqlDbType.NVarChar, TXTNOTE.Text));
                //new _Parameter("@Userid", SqlDbType.Int, LoginInfo.Userid));
            }
        }

        private void BTNDEL_Click(object sender, EventArgs e)
        {
            if (TXTName.Text == string.Empty)
            {

                return;
            }
            else
            {

                _ExecuteNonquery.executeNonquery
("_Warehouse_delCustomers",
              new _Parameter("@CustomersID", SqlDbType.Int, int.Parse(CMBCustomers.SelectedValue.ToString()))

              );

            }
        }

        private void CMBCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCustomersID.Text = CMBCustomers.SelectedValue.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (CMBCustomers.Text != string.Empty)
            {
                DataTable dt = new DataTable();

                dt = _Executequerysearch.executequerysearch("_WarehouseSelectAll_CustomersById", CommandType.StoredProcedure, new _Parameter("@CustomersID", SqlDbType.Int, CMBCustomers.SelectedValue.ToString()));

                //lblIDCustomer.Text = dt.Rows[0]["CustomersID"].ToString();
                if (dt.Rows.Count > 0) { 
                TXTName.Text = dt.Rows[0]["CName"].ToString();
                TXTADDress.Text = dt.Rows[0]["Address"].ToString();
                TXTPHONE.Text = dt.Rows[0]["Phone"].ToString();
                TXTNOTE.Text = dt.Rows[0]["Notes"].ToString();
                DTP.Value = Convert.ToDateTime(dt.Rows[0]["WDate"].ToString());
                }
            }
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            //this.Width = 500;
            //this.Height = 600;
        }

        private void Customers_MdiChildActivate(object sender, EventArgs e)
        {

        }

        private void Customers_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Height = 500;
        }

        private void Customers_Resize(object sender, EventArgs e)
        {
         


        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            //this.Width = 5;
            //this.Height=10;

        }

        private void Customers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //this.Width = 500;
            //this.Height = 600;
        }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            _TxtClear.TxtClear(this, PaneMain);



            BTNSAVE.Enabled = true;
        }

        private void TXTName_TextChanged(object sender, EventArgs e)
        {
            //_Textaccept_alphabetic._Textaccept(TXTName);
        }

        private void TXTPHONE_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(TXTPHONE);
        }

        private void TXTName_Leave(object sender, EventArgs e)
        {
            _CheckExIsts.Check_exists("WarehouseCustomers", "CName", "@CName", TXTName.Text);
        }

        private void CMBCustomers_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBCustomers, "_WarehouseSelectAll_Customers", "CName", "CustomersID");
        }

        private void TXTName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }
    }
}
