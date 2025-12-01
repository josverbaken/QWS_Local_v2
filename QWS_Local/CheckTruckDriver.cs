using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class CheckTruckDriver : Form
    {
        public CheckTruckDriver()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            taCheckTruckDriver.Fill(dsTIQ2.CheckTruckDriver,txtRego.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckTruckDriver_Load(object sender, EventArgs e)
        {
            txtRego.Focus();
        }
    }
}
