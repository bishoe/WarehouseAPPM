using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Classes
{
	//_AutoFillCMBWithPARAm Fill Combobox with 1param
  static  class _AutoFillCMBWithPARAm
    {
        public static void Bindcmb(ComboBox comboBox, String sp,string ParamName, int ParamValue, String displayMember, String valueMember)
        {
            comboBox.DataSource = null;
            comboBox.Items.Clear();
            comboBox.ResetText();
            //"_SelectAll_Customers"
            comboBox.DataSource = _Executequerysearch.executequerysearch(sp, CommandType.StoredProcedure,new _Parameter(ParamName, SqlDbType.Int, ParamValue));
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            //comboBox.Text = comboBox.SelectedValue.ToString();
            comboBox.Text = "";
            comboBox.Refresh();
          


        }
     

    }
}
