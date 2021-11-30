using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WarehouseAPPM.Reports;
//using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Screen
{
    public partial class FRM_Selling : MetroFramework.Forms.MetroForm
    {

        public FRM_Selling()
        {
            InitializeComponent();
        }

        #region Vars
        public object AddColINGrid;//add data from textbox to  datagrid ;
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
        private int Discount;//Discount
        private decimal AMountDicount;//AMountAfterDicount
        private decimal AMoDicotDivid;//AMount eg => AMoDicotDivid = TotalBDiscount * Discount /100 
        private decimal ToAmAfDi; //Total Amount after Discount
        private decimal GetSellingPrice;//Add value from txt selling price to variable
        private decimal GetSellingQt;
        private decimal TotalAmountRow;
        //
        private decimal GetQuntity_Product;//=GetQuntity_Product 
        private decimal GetQuntityTextBox;
        private decimal CalcQuntity;
        //
        private decimal UnitConvert_;//GET UnitConvertNumber From COMBOBOX UNITS
        private decimal GETQTFROMTXTQT;//GET QT 
        private decimal CalcQT;// CalcQT = UnitConvert_  * GETQTFROMTXTQT=>get QT save in db.productquntity
        DeleteSellingBilling deleteSellingBilling = new DeleteSellingBilling();
        SearchTORemoveSellingBilling searchTORemoveSellingBilling = new SearchTORemoveSellingBilling();
        ComboBox comboBox;

        private int GETPrroductid;//GETPrroductid
        private string _SellingPrice;//GetSelling price from db
        private void _GenerateReport()
        {
            ReportDocument crystalReport = new ReportDocument();
            string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\Reports\CRPInvoiceSelling_Print.rpt";
            crystalReport.Load(filename);

            DataSet1 dsMembe_IN = GETREportWithMultipleParam.GetDataWithMultiParam("_Warehouse_InvoiceSelling_Print", "_Warehouse_InvoiceSelling_Print", new _Parameter("@Selling_MasterID", SqlDbType.Int, int.Parse(Selling_MasterID.Text)));
            crystalReport.SetDataSource(dsMembe_IN);
            //FRPInvoiceSelling_Print fRPInvoiceSelling_Print = new FRPInvoiceSelling_Print();
            //fRPInvoiceSelling_Print.crystalReportViewer1.ReportSource = crystalReport;
            crystalReport.PrintToPrinter(1, false, 0, 0);
            //crystalReportViewer1.ReportSource = crystalReport;
            _TxtClear.TxtClear(this, PanelMain);
            BTNSAVE.Enabled = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Set  KeyPreview properties =True
            if (keyData == (Keys.F1))
            {

                BtnNewSelling();
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                BTNADDSelling();
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                BTNSaveSelling();
                return true;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
        private void Selling_Load(object sender, EventArgs e)
        {

            using(WarehouseEntities db= new WarehouseEntities())
            {
                warehouseMainUnitesBindingSource1.DataSource = db.Warehouse_MainUnites.ToList();

            }
            this.ActiveControl = CMBEMPLOYEE;
            _AutoCompleTextBox._AutoCompleTextBox_("_Warehosue_Select_ProductBYBarcodePrint", "@Pname", TXTPRODUCT.Text, TXTPRODUCT);

          


        }
        private void DGVStore_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {


            //////////////int TotalBDiscount = DGVSelling.Rows.Cast<DataGridViewRow>()
            //////////////            .Sum(t => Convert.ToInt32(t.Cells[9].Value));
            //////////////txtTotalBDiscount.Text = Convert.ToString(TotalBDiscount);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BTNADDSelling();

        }
        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            _CheckTxt.CheckTxt(this, PanelMain);
            if (_CheckTxt._ResultValidate == 1)
            {

                return;
            }
            else
            {

                BTNSaveSelling();

            }

        }
        //private void txtSellingPrice_Leave(object sender, EventArgs e)
        //{
        //    GetSellingPrice = Convert.ToDecimal(txtSellingPrice.Text);

        //    GetSellingQt = Convert.ToInt32(txtQT.Text);


        //    TotalAmountRow = GetSellingQt * GetSellingPrice;
        //    TxtTotalAmountRow.Text = Convert.ToString(TotalAmountRow);
        //}

        private void CMBProductiondate_Leave(object sender, EventArgs e)
        {

            //DataTable dataTable = new DataTable();

            //dataTable = _Executequerysearch.executequerysearch("WarehouseSelectProdouctsBY_Qt", CommandType.StoredProcedure, new _Parameter("@Billno", SqlDbType.Int, Convert.ToInt32(CMBProductiondate.SelectedValue.ToString())));

            //LBLQuntity_Product.Text = dataTable.Rows[0]["Quntity_Product"].ToString();
        }


        private void TXTDiscount_Leave(object sender, EventArgs e)
        {
            if (TXTDiscount.Text == null)
            {
                MessageBox.Show("عفوا خانة الخصم لايجب ان تكون فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTDiscount.Focus();
                return;
            }
            else
            {
                TotalBDiscount = Convert.ToDecimal(txtTotalBDiscount.Text);
                Discount = Convert.ToInt32(TXTDiscount.Text);

                AMountDicount = TotalBDiscount * Discount;
                AMoDicotDivid = AMountDicount / 100;
                txtAMountDicount.Text = Convert.ToString(AMoDicotDivid);
                ToAmAfDi = TotalBDiscount - AMoDicotDivid;
                TxtTotalPrice.Text = Convert.ToString(ToAmAfDi);
            }

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            DGVSelling_.Visible = false;

        }


        DataTable dataTable_Getprice = new DataTable();

        private void TXTBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                #region MyRegion
                DataTable dataTable = new DataTable();

                dataTable = _Executequerysearch.executequerysearch("_Warehouse_Select_BarCodeByProductid", CommandType.StoredProcedure,
                    new
                  _Parameter("@BarCode", SqlDbType.Int, Convert.ToInt32(TXTBarCode.Text))

                     );
                if (dataTable.Rows.Count > 0)
                {
                    TXTPRODUCT.Text = dataTable.Rows[0]["Pname"].ToString();

                    GETPrroductid = int.Parse(dataTable.Rows[0]["ProdouctsID"].ToString());
                    dataTable.Rows.Clear();
                    dataTable.Dispose();
                    #endregion


                    using (dataTable_Getprice = _Executequerysearch.executequerysearch("_Warehouse_GetPriceSelling", CommandType.StoredProcedure, new _Parameter("@Pname", SqlDbType.NVarChar, TXTPRODUCT.Text)))
                    {

                        if (dataTable_Getprice.Rows.Count > 0)
                        {

                            _SellingPrice = dataTable_Getprice.Rows[0]["SellingPrice"].ToString();
                            dataTable_Getprice.Rows.Clear();
                            dataTable_Getprice.Dispose();
                            #region GETQT
                            DataTable dataTable_ = new DataTable();

                            dataTable_ = _Executequerysearch.executequerysearch("_Warehouse_Select_QuantityByProductid", CommandType.StoredProcedure, new _Parameter("@ProdouctsID", SqlDbType.Int, GETPrroductid));
                            if (dataTable_.Rows.Count == 0)
                            {
                                MessageBox.Show("عفوا لايوجد نتيجه");
                                return;
                            }
                            else
                            {
                                GetQuntity_Product = Convert.ToDecimal(dataTable_.Rows[0]["QuantityProduct"].ToString());
                            }
                            #endregion
                        }
                        else
                        {
                            MessageBox.Show("عفوا باركود خطأ  او غير مسجل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                }
                BTNADDSelling();
                 
                    

                }
            }
        }

        //       private void txtQT_Leave(object sender, EventArgs e)
        //       {
        //           if(txtQT.Text !=string.Empty || txtQT.Text != "0")
        //           {

        //GetQuntityTextBox = Convert.ToDecimal(txtQT.Text);

        //           CalcQuntity = GetQuntity_Product - GetQuntityTextBox;

        //           if (GetQuntityTextBox > GetQuntity_Product)
        //           {
        //               MessageBox.Show("الكمية اكبر من الموجود بالمخزن", "الكمية كبيرة", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //               this.ActiveControl = txtQT;

        //               return;

        //           }
        //           UnitConvert_ = Convert.ToDecimal(CMBMAINUNITS.SelectedValue.ToString());

        //           GETQTFROMTXTQT = Convert.ToDecimal(txtQT.Text);
        //           CalcQT = UnitConvert_ * GETQTFROMTXTQT;
        //               GetSellingPrice = Convert.ToDecimal(txtSellingPrice.Text);

        //               GetSellingQt = Convert.ToInt32(txtQT.Text);


        //               TotalAmountRow = GetSellingQt * GetSellingPrice;
        //               TxtTotalAmountRow.Text = Convert.ToString(TotalAmountRow);
        //           }
        //           else { return;}


        //       }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            _TxtClear.TxtClear(this, PanelMain);
            BTNSAVE.Enabled = true;
            BtnNewSelling();
        }
        private void BtnNewSelling()
        {
            DataTable dt = new DataTable();
            dt = _Executequery._ExecuteQuery("_Warehouse_Select_MAX_ID_Selling_Master", CommandType.StoredProcedure);
            Selling_MasterID.Text = Convert.ToString(dt.Rows[0]["Selling_MasterID"].ToString());
            if (Selling_MasterID.Text == "")
            {
                _ExecuteNonquery.executeNonquery("_WarehouseAddrow_Selling_Master");
                return;
            }
        }
        private void BTNADDSelling()
        {

            #region ADDTOGrid
            try
            {
                AddColINGrid = DGVSelling.Rows.Add(Counterdgv++,
                CMBEMPLOYEE.Text,
                int.Parse(CMBEMPLOYEE.SelectedValue.ToString()),
                GETPrroductid,
                TXTPRODUCT.Text,
                CalcQT,
                Convert.ToDecimal(_SellingPrice),
                Convert.ToDecimal(100));

                #endregion
                #region MyRegion
                var loopTo = DGVSelling.Rows.Count - 1;
                for (var i = 0; i <= loopTo; i++)
                {
                    DataGridViewRow rw = DGVSelling.Rows[i];
                    rw.Height = 32;
                    ccOunt = DGVSelling.Rows.Count;
                    #endregion
                    #region MyRegion
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            #endregion
        }
        private void BTNSaveSelling()
        {
            if (TXTDiscount.Text == "")
            {
                MessageBox.Show("عفوا خانة الخصم لايجب ان تكون فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {

                #region save



                for (int i = 0; i < ccOunt - 1; i++)
                {
                    _ExecuteNonquery.executeNonquery("_Warehouse_Insert_Selling",
new _Parameter("@Selling_MasterID", SqlDbType.Int, int.Parse(Selling_MasterID.Text)),
new _Parameter("@EmpId", SqlDbType.Int, Convert.ToInt32(DGVSelling.Rows[i].Cells[2].Value.ToString())), new _Parameter("@ProdouctsID", SqlDbType.Int, int.Parse(DGVSelling.Rows[i].Cells[3].Value.ToString())),
new _Parameter("@UnitesNId", SqlDbType.Int, int.Parse(DGVSelling.Rows[i].Cells[5].Value.ToString())), new _Parameter("@Quntity_Product", SqlDbType.Decimal, Convert.ToDecimal(DGVSelling.Rows[i].Cells[7].Value.ToString())),

    new _Parameter("@SellingPrice", SqlDbType.Decimal, Convert.ToDecimal(DGVSelling.Rows[i].Cells[8].Value.ToString())),
     new _Parameter("@Discount", SqlDbType.Int, int.Parse(TXTDiscount.Text)),
      new _Parameter("@TotalPrice", SqlDbType.Decimal, Convert.ToDecimal(TxtTotalPrice.Text)),
   new _Parameter("@TotalBDiscount", SqlDbType.Decimal, txtTotalBDiscount.Text),
    new _Parameter("@AMountDicount", SqlDbType.Decimal,
   txtAMountDicount.Text),
 new _Parameter("@TotalAmountRow", SqlDbType.Decimal, Convert.ToDecimal(DGVSelling.Rows[i].Cells[9].Value.ToString())),
new _Parameter("@UsersID", SqlDbType.Int, Login_.Userid)); }
                _ExecuteNonquery.executeNonquery("_Warehouse_Insert_Selling_Master",
               new _Parameter("@CustomerID", SqlDbType.Int, int.Parse(CMBCUSTOMER.SelectedValue.ToString())),
              new _Parameter("@WDate", SqlDbType.DateTime, DTP.Value));
                #endregion

                #region   _GenerateReport
                _GenerateReport();

                #endregion
            }
        }

        private void DGVSelling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CMBEMPLOYEE_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBEMPLOYEE, "_WarehouseSelectAll_Employee", "EName", "EmployeeId");
        }

        private void CMBCUSTOMER_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBCUSTOMER, "_WarehouseSelectAll_Customers", "CName", "CustomersID");

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXTPRODUCT_KeyDown(object sender, KeyEventArgs e)
        {
            //GET barcode based product Name  
            //Get price Based product Name
            if (e.KeyCode == Keys.Enter)
            {

                DataTable dataTable = new DataTable();
                DataTable dataTable_Getprice = new DataTable();
                using (dataTable = _Executequerysearch.executequerysearch("_Warehosue_Select_ProductBarcodeBYNamePrint", CommandType.StoredProcedure, new _Parameter("@Pname", SqlDbType.NVarChar, TXTPRODUCT.Text)))

                {
                    using (dataTable_Getprice = _Executequerysearch.executequerysearch("_Warehouse_GetPriceSelling", CommandType.StoredProcedure, new _Parameter("@Pname", SqlDbType.NVarChar, TXTPRODUCT.Text))) {

                        if (dataTable.Rows.Count > 0 && dataTable_Getprice.Rows.Count > 0)
                        {

                            TXTBarCode.Text = dataTable.Rows[0]["BarCodeText"].ToString();
                            _SellingPrice = dataTable_Getprice.Rows[0]["SellingPrice"].ToString();
                            GETPrroductid = Convert.ToInt32(dataTable.Rows[0]["ProdouctsID"].ToString());
                            //_Warehouse_GetPriceSelling
                            #region GETQT
                            DataTable dataTable_ = new DataTable();

                            dataTable_ = _Executequerysearch.executequerysearch("_Warehouse_Select_QuantityByProductid", CommandType.StoredProcedure, new _Parameter("@ProdouctsID", SqlDbType.Int, GETPrroductid));
                            if (dataTable_.Rows.Count == 0)
                            {
                                MessageBox.Show("عفوا لايوجد نتيجه");
                                return;
                            }
                            else
                            {
                                GetQuntity_Product = Convert.ToDecimal(dataTable_.Rows[0]["QuantityProduct"].ToString());
                            }
                            #endregion

                        }
                        else
                        {
                            MessageBox.Show("صنف غير موجود يرجى التأكد من الاسم الصحيح", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
        }

        //     private void txtQT_MouseLeave(object sender, EventArgs e)
        //     {
        //         if (GetSellingPrice > 0 )
        //         {
        //GetSellingPrice = Convert.ToDecimal(txtSellingPrice.Text);

        //         GetSellingQt = Convert.ToInt32(txtQT.Text);


        //         TotalAmountRow = GetSellingQt * GetSellingPrice;
        //         TxtTotalAmountRow.Text = Convert.ToString(TotalAmountRow);
        //         }
        //         else
        //         {
        //             return;
        //         }

        //     }

        private void DGVSelling_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //#region txtQT_Leave
            ////txtQT =DGVSelling.Rows[0].Cells[5].Value.ToString
            //if (DGVSelling.Rows[0].Cells[5].Value.ToString() != string.Empty || decimal.Parse(DGVSelling.Rows[0].Cells[5].Value.ToString()) != 0)
            //{

            //    GetQuntityTextBox = Convert.ToDecimal(DGVSelling.Rows[0].Cells[5].Value);

            //    CalcQuntity = GetQuntity_Product - GetQuntityTextBox;

            //    if (GetQuntityTextBox > GetQuntity_Product)
            //    {
            //        MessageBox.Show("الكمية اكبر من الموجود بالمخزن", "الكمية كبيرة", MessageBoxButtons.OK, MessageBoxIcon.Error);


            //        return;

            //        //MessageBox.Show("ارذع");
            //    }
            //}
            //else { return; }
            //#endregion
            //#region MyRegion
            //UnitConvert_ = Convert.ToDecimal(DGVSelling.Rows[0].Cells[8].Value.ToString());

            //GETQTFROMTXTQT = Convert.ToDecimal(DGVSelling.Rows[0].Cells[5].Value);
            //CalcQT = UnitConvert_ * GETQTFROMTXTQT;
            //GetSellingPrice = Convert.ToDecimal(DGVSelling.Rows[0].Cells[6].Value);

            //GetSellingQt = Convert.ToInt32(DGVSelling.Rows[0].Cells[5].Value);


            //TotalAmountRow = GetSellingQt * GetSellingPrice;
            //DGVSelling.Rows[0].Cells[7].Value = Convert.ToString(TotalAmountRow);
            //#endregion
            //#region MyRegion
            //if (GetSellingPrice > 0)
            //{
            //    GetSellingPrice = Convert.ToDecimal(DGVSelling.Rows[0].Cells[6].Value);

            //    GetSellingQt = Convert.ToInt32(DGVSelling.Rows[0].Cells[5].Value);


            //    TotalAmountRow = GetSellingQt * GetSellingPrice;
            //    DGVSelling.Rows[0].Cells[7].Value = Convert.ToString(TotalAmountRow);
            //}
            //else
            //{
            //    return;
            //}
            //#endregion
            //#region MyRegion
            //GetSellingPrice = Convert.ToDecimal(DGVSelling.Rows[0].Cells[6].Value);

            //GetSellingQt = Convert.ToInt32(DGVSelling.Rows[0].Cells[5].Value);


            //TotalAmountRow = GetSellingQt * GetSellingPrice;
            //DGVSelling.Rows[0].Cells[7].Value = Convert.ToString(TotalAmountRow); 
            //#endregion
        }
            
         

        //private void DGVSelling_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    //comboBox = e.Control as ComboBox;
        //    //if (comboBox != null)
        //    //{


        //    //    comboBox.SelectedValueChanged -= new EventHandler(comboBox_ValueMember);

        //    //    comboBox.SelectedValueChanged += comboBox_ValueMember;
        //    //}
        //}
 
        private void DGVSelling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
 
            //comboBoxColumn.DataSource = _ExecutSPNOParam._ExecutSP("SELECT ProdouctsID, Pname FROM WatehouseProdoucts");
            //comboBoxColumn.DisplayMember = "";
            //comboBoxColumn.ValueMember = "ProdouctsID"; DGVSelling.Columns.Add(comboBoxColumn);
            //cbCell.Items.Add("2");
            //DGVSelling.Rows[0].Cells[8].Value= _ExecutSPNOParam._ExecutSP("SELECT ProdouctsID, Pname FROM WatehouseProdoucts");
        }

 

        private void DGVSelling_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //DGVSelling.Rows[0].Cells[3].Value = "99";
            ////DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)DGVSelling.Rows[0].Cells[8];
            ////cbCell.DataSource = _ExecutSPNOParam._ExecutSP("SELECT ProdouctsID, Pname FROM WatehouseProdoucts");
            ////cbCell.DisplayMember = "Pname";
            ////cbCell.ValueMember = "ProdouctsID";
        }

        private void DGVSelling_KeyDown(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Enter)
            {
                var selectedCell = DGVSelling_.SelectedCells[0];
                // do something with selectedCell...
                //MessageBox.Show(selectedCell.ToString());

            }
            int NumberRow = DGVSelling_.Rows.Count;

            //MessageBox.Show((DGVSelling.Rows[0].Cells[7].Value.ToString()));

            if (int.Parse(DGVSelling_.Rows[0].Cells[8].Value.ToString()) != 0)
            {
           GetSellingPrice = Convert.ToDecimal(_SellingPrice);
          GetSellingQt = Convert.ToDecimal(DGVSelling_.Rows[0].Cells[6].Value.ToString());
                TotalAmountRow = GetSellingQt * GetSellingPrice;
                DGVSelling_.Rows[0].Cells[8].Value = Convert.ToString(TotalAmountRow);
            }
        }

        //private void DGVSelling_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    //comboBox = e.Control as ComboBox;
        //    //if (comboBox != null)
        //    //{


        //    //    comboBox.SelectedValueChanged -= new EventHandler(comboBox_ValueMember);

        //    //    comboBox.SelectedValueChanged += comboBox_ValueMember;
        //    //}
        //}

        private void DGVSelling_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)DGVSelling.Rows[0].Cells[8];
            //cbCell.DataSource = _ExecutSPNOParam._ExecutSP("SELECT ProdouctsID, Pname FROM WatehouseProdoucts");
            //cbCell.DisplayMember = "Pname";
            //cbCell.ValueMember = "ProdouctsID";

        }

        private void DGVSelling_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //comboBox = null;
            
        }

        private void DGVSelling_CellBeginEdit_1(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn Cb = new DataGridViewComboBoxColumn();
            DataTable dt = new DataTable();
            dt = _Executequery._ExecuteQuery("SELECT ProdouctsID, Pname FROM WatehouseProdoucts",CommandType.Text);
            Cb.DataSource = dt;
            Cb.Name = "insurance";
            Cb.DisplayMember = "Pname";
            Cb.ValueMember = "ProdouctsID";
            DGVSelling.Columns.Insert(0, Cb);
            DGVSelling.Refresh();
        }
    }
}
