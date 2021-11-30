using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WarehouseAPPM.Classes
{
    public  class _FillComboboxNoParam
    {

       
        //conn
        #region FillComboboxNoParam
        public static void FillComboboxNoParams(ComboBox comboBox, String sp, String displayMember, String valueMember)
        {
            comboBox.DataSource = null;
            comboBox.ResetText();
            //"_SelectAll_Customers"
            comboBox.DataSource = _Executequery._ExecuteQuery(sp,CommandType.StoredProcedure);
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.Text = comboBox.SelectedValue.ToString();
            comboBox.Text = "";
            comboBox.Refresh();
            //cmbcity.SelectedIndex = -1;


        }
        #endregion

        #region Bindcmb
        //public static void BindcmbWithParam(ComboBox comboBox, String sp, String displayMember, String valueMember,string NameParam,int ValueParam )
        //{
        //    comboBox.DataSource = null;
        //    comboBox.ResetText();
        //    //"_SelectAll_Customers"
        //    //comboBox.DataSource = RetriveData.executequery(sp,CommandType.StoredProcedure,new parameter(NameParam, SqlDbType.Int,Id));
        //    comboBox.DisplayMember = displayMember;
        //    comboBox.ValueMember = valueMember;
        //    comboBox.Text = comboBox.SelectedValue.ToString();
        //    comboBox.Text = "";
        //    comboBox.Refresh();
        //    //cmbcity.SelectedIndex = -1;


        //}
        #endregion

        public static void AutoSearch(ComboBox comboBox, string SP, string Filedname)

        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            SqlDataAdapter da;

            //da = new SqlDataAdapter("SELECT WarehouseCustomers.* FROM  WarehouseCustomers", conn);

            da = new SqlDataAdapter(SP, DBConnect.FUllConnection);
            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)

            {

                for (int i = 0; i < dt.Rows.Count; i++)

                {

                    coll.Add(dt.Rows[i][Filedname].ToString());

                }

            }
            else

            {

                MessageBox.Show("not found");

            }

            //comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;

            //comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            comboBox.AutoCompleteCustomSource = coll;

        }

        public void SearchBYID(ComboBox comboBox, string SP, string Paramname, int Valueparam, string fieldname1)
        {
            //if (comboBox.Text != "")
            //{
            DataTable dt = new DataTable();

            //dt = _ExecuteNonquery.executeNonquery(SP, CommandType.StoredProcedure, new _Parameter(Paramname, SqlDbType.Int, Valueparam));
            //Form1 suppliers = new Form1();
            //labelres.Text = dt.Rows[0][fieldname].ToString();
            //suppliers.textBox1.Text = dt.Rows[0][fieldname1].ToString();


            //}
        }

        public void SearchBYIDe(ComboBox comboBox, string SP, string Paramname, int Valueparam, string fieldname1)
        {
            //if (comboBox.Text != "")
            //{
            DataTable dt = new DataTable();

            //    dt = RetriveData.executequery(SP, CommandType.StoredProcedure, new parameter(Paramname, SqlDbType.Int, Valueparam));
            //Store store = new Store();
            //labelres.Text = dt.Rows[0][fieldname].ToString();
            //store.txtNotes.Text = dt.Rows[0][fieldname1].ToString();


            //}
        }

    }
}
