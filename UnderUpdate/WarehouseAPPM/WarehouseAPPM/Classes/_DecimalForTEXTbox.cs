using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAPPM.Classes
{
    class _DecimalForTEXTbox
    {
 public static    void AcceptingDecimal(MetroFramework.Controls.MetroTextBox textbox)
        {
            string previousInput = "";

            Regex r = new Regex(@"^-{0,1}\d+\.{0,1}\d*$"); // This is the main part, can be altered to match any desired form or limitations
            Match m = r.Match(textbox.Text);
            if (m.Success)
            {
                previousInput = textbox.Text;
            }
            else
            {
                textbox.Text = previousInput;
            }
        }
    }
}
