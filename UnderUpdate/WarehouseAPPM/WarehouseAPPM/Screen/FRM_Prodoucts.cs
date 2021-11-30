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

namespace WarehouseAPPM.Screen
{
    public partial class FRM_Prodoucts : MetroFramework.Forms.MetroForm
    {
        public FRM_Prodoucts()
        {
            InitializeComponent();
        }

        private void Prodoucts_Load(object sender, EventArgs e)
        {
          

          
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

                    _ExecuteNonquery.executeNonquery("_WatehouseProdoucts",
                 new _Parameter("@Pname", SqlDbType.NVarChar, TXTName.Text),
                     new _Parameter("@IdCategoryProduct", SqlDbType.Int, Convert.ToInt32(CMBCat.SelectedValue.ToString())),
                       new _Parameter("@WDate", SqlDbType.DateTime, DTP.Value),
                       new _Parameter("@Notes", SqlDbType.NVarChar, TXTNotes.Text),
                  new _Parameter("@BarCodeText", SqlDbType.NVarChar, TXTBarCode.Text),
        new _Parameter("@UsersID", SqlDbType.Int, Login_.Userid));
                }
            }
            _TxtClear.TxtClear(this, PanelMain);
            BtnSave.Enabled = false;
        }
        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            if (TXTName.Text == string.Empty)
            {

                return;
            }
            else
            {

                _ExecuteNonquery.executeNonquery("_WatehouseUpdateProdoucts",
                new _Parameter("@ProdouctsID", SqlDbType.Int, Convert.ToInt32(CMBPRODUCT.SelectedValue.ToString())),

                 new _Parameter("@IdCategoryProduct", SqlDbType.Int, Convert.ToInt32(CMBCat.SelectedValue.ToString())),

                new _Parameter("@Pname", SqlDbType.NVarChar, TXTName.Text)
                ,
                new _Parameter("@WDate", SqlDbType.DateTime, DTP.Value),
               new _Parameter("@Notes", SqlDbType.NVarChar, TXTNotes.Text));
            }
            _TxtClear.TxtClear(this, PanelMain);
            BtnSave.Enabled = false;

        }

        private void BTNDEL_Click(object sender, EventArgs e)
        {

            if (TXTName.Text == string.Empty)
            {

                return;
            }
            else
            {

                _ExecuteNonquery.executeNonquery("_Warehouse_delProdoucts",
          new _Parameter("@ProdouctsID", SqlDbType.Int, int.Parse(CMBPRODUCT.SelectedValue.ToString()))

          );
            }
        }
        DataTable dt = new DataTable();
        public string lblDisplayMember { get; set; }
        public int lblValueMember { get; set; }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
              if (CMBPRODUCT.Text != "")
            {

                dt = _Executequerysearch.executequerysearch("_WarehouseSelectALLProdouctsBYID",CommandType.StoredProcedure, new _Parameter("@ProdouctsID", SqlDbType.Int, Convert.ToInt32(CMBPRODUCT.SelectedValue.ToString())));

                if(dt.Rows.Count > 0) { 
                CMBCat.SelectedText = Convert.ToString(dt.Rows[0]["CategoryName"].ToString());
                CMBCat.SelectedValue = Convert.ToInt32(dt.Rows[0]["IdCategoryProduct"]);

                lblDisplayMember = dt.Rows[0]["CategoryName"].ToString();
                lblValueMember =int.Parse( dt.Rows[0]["IdCategoryProduct"].ToString());
 LBLCurrentcat.Text = dt.Rows[0]["CategoryName"].ToString();
                TXTName.Text = dt.Rows[0]["Pname"].ToString();
                TXTNotes.Text = dt.Rows[0]["Notes"].ToString();
                TXTBarCode.Text   = dt.Rows[0]["BarCodeText"].ToString();
                DTP.Value = Convert.ToDateTime(dt.Rows[0]["WDate"].ToString());

                }
                else
                {
                    MessageBox.Show("عفوا لايوجد نتيجه");
                    return;
                }
            }
        }

        private void TXTName_Leave(object sender, EventArgs e)
        {
            _CheckExIsts.Check_exists("WatehouseProdoucts", "Pname", "@Pname", TXTName.Text);

            //if (CMBPRODUCT.Text != "")
            //{

            //    dt = _Executequerysearch.executequerysearch("_Warehouse_EXISTS_Product", CommandType.StoredProcedure, new _Parameter("@Pname", SqlDbType.NVarChar, TXTName.Text));

            //    //comboBox1.DataSource = dt;
            //    //CMBCurrentCategory.Refresh();
            //    if(dt.Rows.Count > 0)
            //    {
            //        MessageBox.Show("موجود مسبقا", "لايمكن تكرار الصنف مرتين", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }
            //    else
            //    {

            //    }
               

               

                 
            //}
        }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            _TxtClear.TxtClear(this, PanelMain);
            
            BtnSave.Enabled = Enabled;
        }

        private void TXTBarCode_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(TXTBarCode);
        }

        private void TXTName_TextChanged(object sender, EventArgs e)
        {
            //_Textaccept_alphabetic._Textaccept(TXTName);
        }

        private void CMBCat_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBCat, "_WarehouseSelectAll_CategoryProduct", "CategoryName", "IdCategoryProduct");
        }

        private void CMBPRODUCT_Click(object sender, EventArgs e)
        {

            _FillComboboxNoParam.FillComboboxNoParams(CMBPRODUCT, "_WarehouseSelectALLProdoucts", "Pname", "ProdouctsID");
        }

        private void CMBPRODUCT_TextChanged(object sender, EventArgs e)
        {
            _FillComboboxNoParam.AutoSearch(CMBPRODUCT, "_WarehouseSelectALLProdoucts", "Pname");
        }
    }
    }

