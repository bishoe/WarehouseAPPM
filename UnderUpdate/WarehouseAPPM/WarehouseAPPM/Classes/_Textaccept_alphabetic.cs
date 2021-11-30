using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAPPM.Classes
{
  static  class _Textaccept_alphabetic
    {
        public static void _Textaccept(MetroFramework.Controls.MetroTextBox textBox) {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("احرف فقط");
                textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }     
    }
}
