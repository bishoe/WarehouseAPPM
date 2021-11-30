using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WarehouseAPPM.Classes;
//using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Screen
{
    public partial class FRM_Warehouse : MetroFramework.Forms.MetroForm
    {
        public FRM_Warehouse()
        {
            InitializeComponent();
        }
        #region Vars
        public object AddColINGrid;//add data from text to  datagrid ;
        public int SUM;
        public int TotalFStore;//Get all Qt from store 
        //public int AQT;
        //  TotalSendToDB.Text //Quantity after discount
        public int ccOunt;//count row gridview
        //public int CHKPrdouct;
        //public int ConvertQTToMl; //size * qt = 1000Ml
        public int Counterdgv = 1; //counter in grid start from 1 next press ++1

        //TotalBDiscount = Convert.ToInt32(txtTotalBDiscount.Text);
        //    Discount = Convert.ToInt32(TXTDiscount.Text);

        //    AMountDicount = TotalBDiscount* Discount;
        //AMoDicotDivid = AMountDicount / 100;
        //AmountDiscount = 1pound 10pound etc....
        private decimal TotalBDiscount; //txtTotalBDiscount.Text TotalAmount Before Discount
        private Decimal Discount;//Discount
        private decimal AMountDicount;//AMountAfterDicount
        private decimal AMoDicotDivid;//AMount eg => AMoDicotDivid = TotalBDiscount * Discount /100 
        private decimal ToAmAfDi; //Total Amount after Discount
        private decimal QuantityProductCurrent;
        private decimal NewQuantityProductPurchasing;
        private decimal FinalTotalQuantity;
        private decimal UnitConvert_;//GET UnitConvertNumber From COMBOBOX UNITS
        private decimal GETQTFROMTXTQT;//GET QT 
        private decimal CalcQT;// CalcQT = UnitConvert_  * GETQTFROMTXTQT=>get QT save in db.productquntity
        private decimal _QuantityProduct;
        private decimal _TotalPrice; private decimal _AMOUNTPAID;
        private decimal _RemainingAMOUNTCalc;
        int GETIDMAINUNITS; //GET ID MAIN UNITS
        #endregion
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Set  KeyPreview properties =True
            if (keyData == (Keys.F1))
            {

                BTNNEWWAREhouse();
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                BTNADDWarehouse();
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                BTNSaveWarehouse();
                return true;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void BTNNEWWAREhouse()
        {
            DGVStore.Rows.Clear();
            DGVStore.Refresh();

            _TxtClear.TxtClear(this, PaneMain);
            DataTable dt = new DataTable();


            dt = _ExecutSPNOParam._ExecutSP("_Warehouse_SElectMAXIDStore");
            LBLStoreNO.Text = Convert.ToString(dt.Rows[0]["StoreId"].ToString());
            if (LBLStoreNO.Text == "")
            {



                _ExecuteNonquery.executeNonquery("_WarehouseAddrowStore");
                this.Close();
                //return;
            }

        }

        private void BTNADDWarehouse()
        {
            #region MyRegion
            AddColINGrid = DGVStore.Rows.Add(Counterdgv++,

               int.Parse(cmbEmployee.SelectedValue.ToString()),

                  int.Parse(cmbSupplyRep.SelectedValue.ToString())
                  ,
                  int.Parse(cmbSuppliers.SelectedValue.ToString())
                  ,
                  int.Parse(TXTBILLNO.Text),
                   int.Parse(CMBCategory.SelectedValue.ToString()),
                  int.Parse(cmbProdoucts.SelectedValue.ToString()),
                    cmbProdoucts.Text
                  ,
                 Convert.ToDecimal(txtPurchasingPrice.Text),
                Convert.ToDecimal(txtSellingPrice.Text),
                DTPProductiondate.Value,
               DTPExpireDate.Value,
                  int.Parse(CMBMAINUNITS.SelectedValue.ToString()),
                        CMBMAINUNITS.Text,
                          txtNotes.Text,
                      Login_.Userid,
                     Convert.ToDecimal(TxtTotalAmountRow.Text),
                      Convert.ToDecimal(TXTTotalSize.Text),
                    Convert.ToDecimal(txtQT.Text),
                     Convert.ToDecimal(txtQT.Text)//Quantity first period
                     ,
                      _QuantityProduct, Convert.ToDecimal(txtsize.Text),
                    Convert.ToInt32(  GETIDMAINUNITS)

                      );
            txtTotalBDiscount.Enabled = true;
            TXTDiscount.Enabled = true;
            var loopTo = DGVStore.Rows.Count - 1;
            for (var i = 0; i <= loopTo; i++)
            {
                DataGridViewRow rw = DGVStore.Rows[i];
                rw.Height = 32;
                ccOunt = DGVStore.Rows.Count;
                //textBox1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                //textBox2.Text= dataGridView1.Rows[0].Cells[2].Value.ToString();

            }
            #endregion
        }

        private void BTNSaveWarehouse()
        {
            if (TXTDiscount.Text == string.Empty)
            {
                MessageBox.Show("عفوا خانة الخصم لايجب ان تكون فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _ExecuteNonquery.executeNonquery("_Warehouse_MasterStore",
    new _Parameter("@EmployeeId", SqlDbType.Int, int.Parse(DGVStore.Rows[0].Cells[1].Value.ToString())),
        new _Parameter("@WDate", SqlDbType.DateTime, (DTP.Value)),
                  new _Parameter("@UsersID", SqlDbType.Int, Login_.Userid));


                #region save
                for (int i = 0; i < DGVStore.Rows.Count; i++)
                {
                    _ExecuteNonquery.executeNonquery("_Warehouse_Store",

new _Parameter("@SupplyRepId", SqlDbType.Int, int.Parse(DGVStore.Rows[i].Cells[2].Value.ToString())),
     new _Parameter("@SuppliersId", SqlDbType.Int, int.Parse(DGVStore.Rows[i].Cells[3].Value.ToString())),

  new _Parameter("@Billno", SqlDbType.Int, int.Parse(DGVStore.Rows[i].Cells[4].Value.ToString())),
    new _Parameter("@IdCategoryProduct", SqlDbType.Int, int.Parse(DGVStore.Rows[i].Cells[5].Value.ToString())),
               new _Parameter("@ProdouctsID", SqlDbType.Int, int.Parse(DGVStore.Rows[i].Cells[6].Value.ToString())),

      new _Parameter("@PurchasingPrice", SqlDbType.Decimal, Convert.ToDecimal(DGVStore.Rows[i].Cells[8].Value.ToString())),

      new _Parameter("@SellingPrice", SqlDbType.Decimal, Convert.ToDecimal(DGVStore.Rows[i].Cells[9].Value.ToString())),


         new _Parameter("@Productiondate", SqlDbType.DateTime, Convert.ToDateTime(DGVStore.Rows[i].Cells[10].Value.ToString())),

     new _Parameter("@ExpireDate", SqlDbType.DateTime, Convert.ToDateTime(DGVStore.Rows[i].Cells[11].Value.ToString())),


   //new _Parameter("@MinimumQT", SqlDbType.Int, int.Parse(DGVStore.Rows[i].Cells[12].Value.ToString())),

   new _Parameter("@MainUnitesId", SqlDbType.Int, int.Parse(DGVStore.Rows[i].Cells[22].Value.ToString())),

    new _Parameter("@Notes", SqlDbType.NVarChar, DGVStore.Rows[i].Cells[14].Value.ToString()),

  new _Parameter("@Discount", SqlDbType.Decimal, Convert.ToDecimal(TXTDiscount.Text)),

  new _Parameter("@TotalPrice", SqlDbType.Decimal, Convert.ToDecimal(TxtTotalPrice.Text)),

  new _Parameter("@MStoreId", SqlDbType.Int, int.Parse(LBLStoreNO.Text)),

  new _Parameter("@TotalBDiscount", SqlDbType.Decimal, Convert.ToDecimal(txtTotalBDiscount.Text)),

   new _Parameter("@AMountDicount", SqlDbType.Decimal, Convert.ToDecimal(
   txtAMountDicount.Text)),

   new _Parameter("@TotalAmountRow", SqlDbType.Decimal, Convert.ToDecimal(DGVStore.Rows[i].Cells[16].Value.ToString())),

      new _Parameter("@TotalSize", SqlDbType.Decimal, Convert.ToDecimal(DGVStore.Rows[i].Cells[17].Value.ToString())),

      new _Parameter("@Quntity_Product", SqlDbType.Decimal, Convert.ToDecimal(DGVStore.Rows[i].Cells[18].Value.ToString())),

new _Parameter("@QtStartPeriod", SqlDbType.Decimal, Convert.ToDecimal(DGVStore.Rows[i].Cells[19].Value.ToString())),

new _Parameter("@SizeProducts", SqlDbType.Decimal, Convert.ToDecimal(DGVStore.Rows[i].Cells[20].Value.ToString()))

);

                    //--------//////------UPdate Qt
                    #region MyRegion
                    QuantityProductCurrent = Convert.ToDecimal(DGVStore.Rows[i].Cells[20].Value.ToString());
                    NewQuantityProductPurchasing = CalcQT;
                    FinalTotalQuantity = QuantityProductCurrent + NewQuantityProductPurchasing;
                    // -------------
                    //update qt
                    //id product 
                    _ExecuteNonquery.executeNonquery("_Warehouse_Insert_NewQuantity",
                        new _Parameter("@ProductID", SqlDbType.Int, Convert.ToInt32(DGVStore.Rows[i].Cells[6].Value.ToString())),

                    new _Parameter("@QuantityProduct", SqlDbType.Decimal, FinalTotalQuantity));
                    FinalTotalQuantity = 0;
                    QuantityProductCurrent = 0;
                    NewQuantityProductPurchasing = 0;


                }
                if (Convert.ToDecimal(TXTRemainingAMOUNT.Text) > 0)
                {
                    _ExecuteNonquery.executeNonquery("_Warehouse_invoice_Store_StatusINSERT",
    new _Parameter("@MStoreId", SqlDbType.Int, int.Parse(LBLStoreNO.Text)),
    new _Parameter("@Billno", SqlDbType.Int, int.Parse(TXTBILLNO.Text)),
    new _Parameter("@PAIDAMOUNT", SqlDbType.Decimal, decimal.Parse(TXTAMOUNTPAID.Text)),
    new _Parameter("@RemainingAMOUNT", SqlDbType.Decimal, decimal.Parse(TXTRemainingAMOUNT.Text)),
    new _Parameter("@UserID", SqlDbType.Int, Login_.Userid)
    ,
    new _Parameter("@Wdate", SqlDbType.DateTime, DateTime.Now.ToLongDateString())

    );
                }
                #endregion

                #endregion
            }
            DGVStore.Rows.Clear();
            DGVStore.Refresh();

            _TxtClear.TxtClear(this, PaneMain);


        }
        private void Warehouse_Load(object sender, EventArgs e)
        {





        }



        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSupplyRep_Click(object sender, EventArgs e)
        {
            _AutoFillCMBWithPARAm.Bindcmb(cmbSupplyRep, "_WarehouseSelectALL_SupplyRepresentativeByID", "@SupplyRepID", Convert.ToInt32(cmbSuppliers.SelectedValue.ToString()), "SRName", "SupplyRepID"
);
        }



        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void DGVStore_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            decimal TotalBDiscount = DGVStore.Rows.Cast<DataGridViewRow>()
                          .Sum(t => Convert.ToDecimal(t.Cells[17].Value));
            txtTotalBDiscount.Text = Convert.ToString(TotalBDiscount);
            BTNSAVE.Enabled = true;
        }

        private void TxtTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void cmbProdoucts_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }




        //private void CMBUnitSub_Leave(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();

        //    dt = _Executequerysearch.executequerysearch("_Warehouse_Select_SubUnis_BYID", CommandType.StoredProcedure, new _Parameter

        //        ("@UnitesId", SqlDbType.Int, int.Parse(CMBSUBUNITS.SelectedValue.ToString())));

        //    //lblIDCustomer.Text = dt.Rows[0]["CustomersID"].ToString();

        //    LBLGETUnitConvert.Text = dt.Rows[0]["UnitConvert"].ToString();
        //}

        private void cmbProdoucts_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = _Executequerysearch.executequerysearch("_Warehouse_Select_QuantityProduct",
                CommandType.StoredProcedure

                ,
                new _Parameter("@IdCategoryProduct", SqlDbType.Int, CMBCategory.SelectedValue.ToString()),

                new _Parameter("@ProdouctsID", SqlDbType.Int, cmbProdoucts.SelectedValue.ToString()));

            //lblIDCustomer.Text = dt.Rows[0]["CustomersID"].ToString();
            if (dt.Rows.Count == 0)
            {
                _QuantityProduct = 0;
            }
            else if (dt.Rows.Count > 0)
            {
                _QuantityProduct = Convert.ToDecimal(dt.Rows[0]["QuantityProduct"].ToString());
            }
        }

        private void TXTBarCode_Enter(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsize_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(txtsize);


            if (txtQT.Text == string.Empty)
            {
                return;
            }
            decimal GETCURRENTSIZE;
            decimal QT;//GET QT FROM TXTQT
            decimal TotalSize;//GETTOTAL SIZE
            GETCURRENTSIZE = Convert.ToDecimal(txtsize.Text);

            QT = Convert.ToDecimal(txtQT.Text);

            TotalSize = (GETCURRENTSIZE) * (QT);

            TXTTotalSize.Text = Convert.ToString(TotalSize);
        }




        private void txtPurchasingPrice_Leave(object sender, EventArgs e)
        {
            decimal TotalAmountRow;
            TotalAmountRow =
Convert.ToDecimal(txtQT.Text) * Convert.ToDecimal(txtPurchasingPrice.Text);
            TxtTotalAmountRow.Text = Convert.ToString(TotalAmountRow);
        }

        private void txtPurchasingPrice_Click(object sender, EventArgs e)
        {
            //metroToolTip1.ToolTipTitle = "00000000";
            //metroToolTip1.ToolTipIcon = ToolTipIcon.Info;

        }







        private void BTNSAVE_Click_1(object sender, EventArgs e)
        {

        }
        private void txtQT_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(txtQT);
        }




        private void txtPurchasingPrice_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(txtPurchasingPrice);

        }

        private void txtSellingPrice_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(txtSellingPrice);

        }

        private void txtTotalBDiscount_TextChanged(object sender, EventArgs e)
        {
        }

        private void TXTDiscount_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(TXTDiscount);

        }

        private void txtAMountDicount_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotalAmountRow_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(TxtTotalAmountRow);
        }

        private void TxtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            //_DecimalForTEXTbox.AcceptingDecimal(TxtTotalPrice);

        }

        private void TXTBILLNO_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CMBMAINUNITS_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBMAINUNITS, "_Warehouse_Select_MainUnites", "UName", "UnitConvert");

        }

        private void txtQT_Leave(object sender, EventArgs e)
        {
            UnitConvert_ = Convert.ToDecimal(CMBMAINUNITS.SelectedValue.ToString());

            GETQTFROMTXTQT = Convert.ToDecimal(txtQT.Text);
            CalcQT = UnitConvert_ * GETQTFROMTXTQT;
        }

        private void cmbSuppliers_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(cmbSuppliers, "_WarehouseSelectAllSuppliers", "SName", "SuppliersID");
        }

        private void BTNNEW_Click(object sender, EventArgs e)
        {
            _TxtClear.TxtClear(this, PaneMain);


            BTNSAVE.Enabled = true;
            BTNNEWWAREhouse();
        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {

            _CheckTxt.CheckTxt(this, PaneMain);
            if (_CheckTxt._ResultValidate == 1)
            {

                return;
            }
            else
            {

                BTNSaveWarehouse();
            }
            _TxtClear.TxtClear(this, PaneMain);
            BTNSAVE.Enabled = false;

        }

        private void txtTotalBDiscount_TextChanged_1(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(txtTotalBDiscount);

        }

        private void TXTDiscount_Leave(object sender, EventArgs e)
        {
            #region MyRegion
            TotalBDiscount = Convert.ToDecimal(txtTotalBDiscount.Text);
            Discount = Convert.ToDecimal(TXTDiscount.Text);

            AMountDicount = TotalBDiscount * Discount;
            AMoDicotDivid = AMountDicount / 100;
            txtAMountDicount.Text = Convert.ToString(AMoDicotDivid);
            ToAmAfDi = TotalBDiscount - AMoDicotDivid;
            TxtTotalPrice.Text = Convert.ToString(ToAmAfDi);
            #endregion
        }

        private void txtAMountDicount_TextChanged_1(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(txtAMountDicount);
        }

        private void TxtTotalPrice_TextChanged_1(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(TxtTotalPrice);

        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
            BTNADDWarehouse();
        }

        private void TXTAMOUNTPAID_Leave(object sender, EventArgs e)
        {
            _TotalPrice = Convert.ToDecimal(TxtTotalPrice.Text);
            _AMOUNTPAID = Convert.ToDecimal(TXTAMOUNTPAID.Text);
            _RemainingAMOUNTCalc = _TotalPrice - _AMOUNTPAID;
            TXTRemainingAMOUNT.Text = Convert.ToString(_RemainingAMOUNTCalc);

        }

        private void PaneMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbEmployee_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(cmbEmployee, "_WarehouseSelectAll_Employee", "EName", "EmployeeId");

        }

        private void CMBCategory_Click(object sender, EventArgs e)
        {

            _FillComboboxNoParam.FillComboboxNoParams(CMBCategory, "_WarehouseSelectAll_CategoryProduct", "CategoryName", "IdCategoryProduct");

        }

        private void cmbProdoucts_Click(object sender, EventArgs e)
        {
            _AutoFillCMBWithPARAm.Bindcmb(cmbProdoucts, "_Warehouse_SelectProducts", "@IdCategoryProduct", Convert.ToInt32(CMBCategory.SelectedValue.ToString()), "Pname", "ProdouctsID");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CMBMAINUNITS_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = _Executequerysearch.executequerysearch("_WarehouseGetIDMainUnits", CommandType.StoredProcedure, new _Parameter("@UName", SqlDbType.NVarChar, CMBMAINUNITS.Text));
            if(table.Rows.Count > 0) { 
            GETIDMAINUNITS = Convert.ToInt32(table.Rows[0]["UnitesNId"].ToString());

            }
            else
            {
                return;
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            //_AutoFillCMBWithPARAm.Bindcmb(metroButton1.Text, "GetIDMain", "@UName", CMBMAINUNITS.Text, "UName", "UnitesNId");
         
        }
    }

    }
   
    
