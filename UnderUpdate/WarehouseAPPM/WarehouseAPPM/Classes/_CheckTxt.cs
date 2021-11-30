using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;
//MetroFramework.Controls
namespace WarehouseAPPM.Classes
{
    static class _CheckTxt
    {
        public static int _ResultValidate=0;
        public static void CheckTxt(MetroFramework.Forms.MetroForm frm, MetroFramework.Controls.MetroPanel Group)
            {

                foreach (Control item in frm.Controls)
                {
                    if (item is MetroFramework.Controls.MetroPanel)
                    {
                        foreach (Control itemGroup in Group.Controls)
                        {
                            if (itemGroup is MetroFramework.Controls.MetroTextBox)
                            {
                                if (itemGroup.Text == "")
                                {
                                    MessageBox.Show("عفوا يوجد خانه فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                _ResultValidate = 1;

                                return;
                                }else
                            {
                              
                                    _ResultValidate = 0;
                                }
                            }
                            
                            //if (itemGroup is MetroFramework.Controls.MetroTextBox)
                            //{
                            //    if (itemGroup.Text == "")
                            //        MessageBox.Show("عفوا يوجد خانه فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //_ResultValidate = 1;
                            //return;


                            //}
                            if (itemGroup is MetroFramework.Controls.MetroComboBox)
                            {

                                if (itemGroup.Text == "") { 
                                    MessageBox.Show("عفوا يوجد خانه فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            _ResultValidate = 1;
                            return;
                            }
                            else
                            {
                                _ResultValidate = 0;
                            }

                            }
                        }

                    }
                }
            }

        }
        }
            