using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class QWSLogin : Form
    {
        public QWSLogin()
        {
            InitializeComponent();
        }

        private string _cnQWSLocal;
        private int _SiteID;
        private bool _TestMode;

        public string cnQWSLocal
        {
            get
            { return _cnQWSLocal; }
        }

        public int SiteID
        {
            get
            { return _SiteID; }
        }

        public bool TestMode
        {
            get { return _TestMode; }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SetConfiguration();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void QWSLogin_Load(object sender, EventArgs e)
        {
            rbClear.Checked = true;
            rbNQ.Checked = false;
            rbSQ.Checked = false;
            rbProd.Checked = true;
            rbTest.Checked = false;
        }

        private void SetConfiguration()
        {
            string dataSource = "Data Source=";
            string initialCatalog = "Initial Catalog=";

            if (rbNQ.Checked && rbProd.Checked)
            { // NQ live:
                dataSource += "ch-nq-dc02";
                initialCatalog += "QWS_NQ";
                _SiteID = 7;
                _TestMode = false;
            }
            if (rbNQ.Checked && rbTest.Checked)
            { // NQ Test:
                dataSource += "ch-sql02";
                initialCatalog += "QWS_NQ_Dev";
                _SiteID = 7;
                _TestMode = true;
            }
            if (rbSQ.Checked && rbProd.Checked)
            { // SQ Live:
                dataSource += "ch-sq-dc02";
                initialCatalog += "QWS_SQ";
                _SiteID = 2;
                _TestMode = false;
            }
            if (rbSQ.Checked &&  rbTest.Checked)
            { // SQ Test:
                dataSource += "ch-sql02";
                initialCatalog += "QWS_SQ_Dev";
                _SiteID = 2;
                _TestMode = true;
            }
            _cnQWSLocal = dataSource + ";"+ initialCatalog +";"+ "Integrated Security=True;TrustServerCertificate=True";
        }

        //Data Source=ch-sql02;Initial Catalog=QWS_NQ_Dev;Integrated Security=True;TrustServerCertificate=True

        private void rbNQ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNQ.Checked)
            {
                rbNQ.BackColor = Color.LightSkyBlue;
                rbSQ.BackColor = SystemColors.Control;
            }
        }

        private void rbSQ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSQ.Checked)
            {
                rbSQ.BackColor = Color.LightGreen;
                rbNQ.BackColor= SystemColors.Control;
            }
        }

        private void rbClear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClear.Checked)
            {
                rbNQ.BackColor = SystemColors.Control;
                rbSQ.BackColor = SystemColors.Control;
            }
        }
    }
}
