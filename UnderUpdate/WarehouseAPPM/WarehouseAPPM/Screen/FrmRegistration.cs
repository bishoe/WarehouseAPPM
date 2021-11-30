using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM.Classes;

namespace WarehouseAPPM
{
    public partial class FrmRegistration : MetroFramework.Forms.MetroForm
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
        const int ProductCode = 1;

        private void btnOK_Click(object sender, EventArgs e)
        {

            KeyManager km = new KeyManager(txtProductID.Text);
            string productKey = txtProductKey.Text;
            //Check valid
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                //Decrypt license key
                if (km.DisassembleKey(productKey, ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productKey;
                    lic.FullName = "FoxLearn";
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }
                    //Save license key to file
                    km.SaveSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                    MessageBox.Show("You have been successfully registered.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
                MessageBox.Show("Your product key is invalid.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                //Do your stuffs when network available
                txtProductID.Text = ComputerInfo.GetComputerId();

            }
            else
            {
                //Do stuffs when network not available
                MessageBox.Show("النت لا يعمل تأكد من توصيل النت بالجهاز اولا ","النت لا يعمل",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Dispose();
            }

        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(txtProductID.Text);
            string productKey = txtProductKey.Text;
            //Check valid
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                //Decrypt license key
                if (km.DisassembleKey(productKey, ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productKey;
                    lic.FullName = "Full";
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }
                    //Save license key to file
                    km.SaveSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                    MessageBox.Show("You have been successfully registered.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
                MessageBox.Show("Your product key is invalid.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.ExitThread();
            //Application.Exit();
            this.Close();
        }

        private void BTNSENDMAIL_Click(object sender, EventArgs e)
        {
            PNL.Visible = true;

            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                //Do your stuffs when network available
                txtProductID.Text = ComputerInfo.GetComputerId();
                if (TXTMail.Text == string.Empty)
                {
                    return;
                }
                else
                {
                    _SendMail.SENDInfoPC(TXTMail.Text, txtProductID.Text);

                    PNL.Visible = true;
                }
            }
            else
            {
                //Do stuffs when network not available
                MessageBox.Show("النت لا يعمل تأكد من توصيل النت بالجهاز اولا ", "النت لا يعمل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }

             
        }

        private void BTNOther_Click(object sender, EventArgs e)
        {
            PNL.Visible = true;

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Application.ExitThread();
            this.Close();
            Application.Exit();
        }

        private void FrmRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.ExitThread();
            //Application.Exit();
        }

        private void TXTMail_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (TXTMail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(TXTMail.Text.Trim()))
                {
                    MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TXTMail.Focus();
                }
            }
        }
    }
}
