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
    public partial class QWS_MDIParent : Form
    {
        public QWS_MDIParent()
        {
            InitializeComponent();
        }

        private void QWS_MDIParent_Load(object sender, EventArgs e)
        {
            TrucksInQuarry frmTIQ = new TrucksInQuarry();
            frmTIQ.MdiParent = this;
            frmTIQ.Show();
        }
    }
}
