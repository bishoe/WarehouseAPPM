using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAPPM.Classes
{
    public class _TxtClear
    {
        public static int _ResultValidate;
        public static void TxtClear(MetroFramework.Forms.MetroForm frm, MetroFramework.Controls.MetroPanel Group)
        {

            foreach (Control item in frm.Controls)
            {
                if (item is MetroFramework.Controls.MetroPanel)
                {
                    foreach (Control itemGroup in Group.Controls)
                    {
                        if (itemGroup is MetroFramework.Controls.MetroTextBox)
                        {
                            itemGroup.Text = "";

                        }
                        if (itemGroup is MetroFramework.Controls.MetroTextBox)
                        {
                            itemGroup.Text = "";

                        }
                        if (itemGroup is MetroFramework.Controls.MetroComboBox)
                        {

                            itemGroup.Text = "";
                        }
                    }

                }
            }
        }




 //       public static void TxtEm(MetroFramework.Forms.MetroForm frm, MetroFramework.Controls.MetroPanel Group  )
 //       {

 //           foreach (Control item in frm.Controls)
 //           {
 //               if (item is MetroFramework.Controls.MetroPanel)
 //               {
 //                   foreach (Control itemGroup in Group.Controls)
 //                   {
 //                       if (itemGroup is MetroFramework.Controls.MetroTextBox)
 //                       {
 //                           if (itemGroup.Text == "")
 //                           {
 //MessageBox.Show("عفوا يوجد خانه فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

 //                               _ResultValidate = 1;

 //                               return;
 //                           }
 //                       }
 //                       if (itemGroup is MetroFramework.Controls.MetroTextBox)
 //                       {
 //                     if (itemGroup.Text =="")
 // MessageBox.Show("عفوا يوجد خانه فارغه","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
 //                           _ResultValidate = 1;
 //                           return;

                           
 //                       }
 //                       if (itemGroup is MetroFramework.Controls.MetroComboBox)
 //                       {

 //                           if (itemGroup.Text == "")
 //                               MessageBox.Show("عفوا يوجد خانه فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
 //                           //_ResultValidate = 1;
 //                           return;

 //                       }
 //                   }

 //               }
 //           }
 //       }

    }
}
