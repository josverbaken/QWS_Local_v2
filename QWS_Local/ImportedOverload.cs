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
    public partial class ImportedOverload : Form
    {
        public ImportedOverload()
        {
            InitializeComponent();
        }

        private void ImportedOverload_Load(object sender, EventArgs e)
        {
            SetSanctionsText(); 
        }

        private void SetSanctionsText()
        {
            rtxtSanctions.Text = "Categories of mass offences\r\n\r\nMinor\r\n\r\nA minor risk breach occurs if the breach is less than the substantial risk breach lower limit.\r\n\r\nSubstantial\r\n\r\nThe lower limit of a substantial risk breach is the higher of the following:\r\n\r\na) a mass equalling 105% of the maximum mass (rounded up to the nearest 0.1t); or\r\n\r\nb) 0.5t\r\n\r\nThe upper limit of a substantial risk breach is less than 120% of the maximum mass.\r\n\r\nSevere\r\n\r\nThe lower limit of a severe risk breach is defined as the mass equalling 120% of the maximum mass rounded up to the nearest 0.1t).\r\n\r\nMinor risk breach:\r\n\r\nWhen a minor breach of a mass requirement is detected the driver or operator will be:\r\n\r\n· verbally notified by the WBO;\r\n\r\n· issued a weighbridge docket with the infringement level denoted, and;\r\n\r\n· Business Partner will be notified via an electronic Daily Docket Summary.\r\n\r\nSubstantial risk breach:\r\n\r\nWhen a substantial breach of a mass requirement is detected the driver or operator will be:\r\n\r\n· verbally notified by the WBO;\r\n\r\n· issued a weighbridge docket with the infringement level denoted;\r\n\r\n· incur a total of 10 overload sanction point;\r\n\r\n· supervised during tip off, and;\r\n\r\n· Business Partner will be notified via an electronic Daily Docket Summary.\r\n\r\nA driver or operator who accumulates 60 points during a day will be suspended for the remainder of that day.\r\n\r\nSevere risk breach:\r\n\r\nWhen a severe breach of a mass requirement is detected the driver or operator will be:\r\n\r\n· verbally notified by the WBO;\r\n\r\n· issued a weighbridge docket with the infringement level denoted;\r\n\r\n· escorted to the tip location and supervised during tip off;\r\n\r\n· denied entry to the quarry site for one month, and;\r\n\r\n· Business Partner will be notified via an electronic Daily Docket Summary.\r\n\r\nAn Issue Resolution Form will be raised and the principal supplier will be issued a warning for removal from imported material supplier status. Three severe non-conformances within the Issue Resolution Form nominated time frame may, at the managers discretion, result in the driver and the supplier being permanently removed as a supplier.\r\n\r\n";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
