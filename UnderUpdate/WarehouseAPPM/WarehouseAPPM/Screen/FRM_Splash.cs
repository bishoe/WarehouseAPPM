using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAPPM.Screen
{
    public partial class FRM_Splash : MetroFramework.Forms.MetroForm
    {
        public FRM_Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroProgressBar1.Value += 10;

            if (metroProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                FRM_login fRM_login = new FRM_login();
                fRM_login.Show();
                //this.Dispose();
                this.Hide();
            }
        }

        private void FRM_Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
