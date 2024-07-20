using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class ImportedOverload : Form
    {
        private static int DriverID;
        private static string Driver;
        private static decimal Gross;
        private static decimal GVM;
        private int myOverloadPoints;
        private string myOverloadDesc;

        public ImportedOverload()
        {
            InitializeComponent();
        }

        public ImportedOverload(int myDriverID, string myDriver, decimal myGross, decimal myGVM)
        {
            InitializeComponent();
            DriverID = myDriverID;
            Driver = myDriver;
            Gross = myGross;
            GVM = myGVM;
        }

        public int OverloadPoints
        {
            get
            {
                return myOverloadPoints;
            }
        }

        public string OverloadDesc
        { 
            get 
            { 
                return myOverloadDesc; 
            } 
        }  

            private void ImportedOverload_Load(object sender, EventArgs e)
        {
            SetSanctionsText(); 
            GetImportedOverloads(DriverID);
            txtDriver.Text = Driver;
            txtGross.Text = Gross.ToString();
            txtGVM.Text = GVM.ToString();
            //CalcOverloadCategory(); 
            CalculatePoints();
        }

        private void SetSanctionsText()
        {
            rtxtSanctions.Text = "Categories of mass offences\r\n\r\nMinor\r\n\r\nA minor risk breach occurs if the breach is less than the substantial risk breach lower limit.\r\n\r\nSubstantial\r\n\r\nThe lower limit of a substantial risk breach is the higher of the following:\r\n\r\na) a mass equalling 105% of the maximum mass (rounded up to the nearest 0.1t); or\r\n\r\nb) 0.5t\r\n\r\nThe upper limit of a substantial risk breach is less than 120% of the maximum mass.\r\n\r\nSevere\r\n\r\nThe lower limit of a severe risk breach is defined as the mass equalling 120% of the maximum mass rounded up to the nearest 0.1t).\r\n\r\nMinor risk breach:\r\n\r\nWhen a minor breach of a mass requirement is detected the driver or operator will be:\r\n\r\n· verbally notified by the WBO;\r\n\r\n· issued a weighbridge docket with the infringement level denoted, and;\r\n\r\n· Business Partner will be notified via an electronic Daily Docket Summary.\r\n\r\nSubstantial risk breach:\r\n\r\nWhen a substantial breach of a mass requirement is detected the driver or operator will be:\r\n\r\n· verbally notified by the WBO;\r\n\r\n· issued a weighbridge docket with the infringement level denoted;\r\n\r\n· incur a total of 10 overload sanction point;\r\n\r\n· supervised during tip off, and;\r\n\r\n· Business Partner will be notified via an electronic Daily Docket Summary.\r\n\r\nA driver or operator who accumulates 60 points during a day will be suspended for the remainder of that day.\r\n\r\nSevere risk breach:\r\n\r\nWhen a severe breach of a mass requirement is detected the driver or operator will be:\r\n\r\n· verbally notified by the WBO;\r\n\r\n· issued a weighbridge docket with the infringement level denoted;\r\n\r\n· escorted to the tip location and supervised during tip off;\r\n\r\n· denied entry to the quarry site for one month, and;\r\n\r\n· Business Partner will be notified via an electronic Daily Docket Summary.\r\n\r\nAn Issue Resolution Form will be raised and the principal supplier will be issued a warning for removal from imported material supplier status. Three severe non-conformances within the Issue Resolution Form nominated time frame may, at the managers discretion, result in the driver and the supplier being permanently removed as a supplier.\r\n\r\n";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                myOverloadPoints = System.Convert.ToInt16(txtPointsDocket.Text);
            myOverloadDesc = txtOverloadCategory.Text;  
            this.DialogResult = DialogResult.OK;
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void GetImportedOverloads(int DriverID)
        {
            try
            {
                this.taImportedOverloads.Fill(dsTIQ2.ImportedOverloadsByDriver, DriverID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void CalcOverloadCategory()
        {
            txtOverloadCategory.Text = "tba";
            // carry out calculations

            txtOverloadPercent.Text = "110.00 %";
            txtOverloadTonnes.Text = "4.50 t";
        }

        private void CalculatePoints()
        {
            decimal TonnesCriterion = 0.5M;
            decimal OverloadPercent;
            int OverloadPoints = 5;
            string msgSanction;

            OverloadPercent = Gross / GVM;
            txtOverloadPercent.Text = OverloadPercent.ToString("P", CultureInfo.InvariantCulture);
            txtOverloadTonnes.Text = (Gross - GVM).ToString() + " t";
            if (OverloadPercent >= 1.2M)
            {
                msgSanction = "Immediate Sanction Applies. tip off must be supervised, manager contacted, driver advised of immediate sanction and initiation of IRF";
                OverloadPoints = Properties.Settings.Default.OverloadSevere;
                txtOverloadCategory.Text = "Overload Severe";
                MessageBox.Show(msgSanction, "Overload Category = SEVERE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (OverloadPercent >= 1.05M)
            {
                OverloadPoints = Properties.Settings.Default.OverloadSubstantial;
                txtOverloadCategory.Text = "Overload Substantial";
            }
            else if (OverloadPercent >= 1.05M && (Gross - GVM) > TonnesCriterion)
            {
                OverloadPoints = Properties.Settings.Default.OverloadSubstantial;
                txtOverloadCategory.Text = "Overload Substantial";
            }
            else
            {
                OverloadPoints = Properties.Settings.Default.OverloadMinor;
                txtOverloadCategory.Text = "Overload Minor";

            }
            txtPointsDocket.Text = OverloadPoints.ToString();
            myOverloadPoints = OverloadPoints;
            myOverloadDesc = txtOverloadCategory.Text;
            AccumulatedPoints(myOverloadPoints);
        }

        private void AccumulatedPoints(int OverloadPoints)
        {
            try
            {
                int DocketPointsToday = OverloadPoints;
                int DocketPointsThisWeek = OverloadPoints;
                int SanctionToday = Properties.Settings.Default.SanctionToday;
                int SanctionThisWeek = Properties.Settings.Default.SanctionThisWeek;
                string msgSanction = "";
                taImportedOverloads.Fill(dsTIQ2.ImportedOverloadsByDriver, DriverID);
                    foreach (dsTIQ2.ImportedOverloadsByDriverRow row in dsTIQ2.ImportedOverloadsByDriver)
                    {
                        DocketPointsToday += row.OverloadPoints;
                        if (row.Tday == DateTime.Now.Day)
                        {
                            DocketPointsToday += row.OverloadPoints;   
                        }
                    }
                if (DocketPointsToday > SanctionToday)
                {
                    msgSanction = "Daily points exceeded,";
                }
                else if (DocketPointsToday > SanctionThisWeek)
                {
                    msgSanction = "Weekly points exceeded,";
                }
                if (msgSanction.Length > 0)
                {
                    msgSanction += " sanction for remainder of today and tomorrow,ensure Sanction Date is entered into SAP.";
                    MessageBox.Show(msgSanction, "Accumulated Points Sanction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                txtPointsToday.Text = DocketPointsToday.ToString(); 
                txtPointsThisWeek.Text = DocketPointsThisWeek.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Accumulated Points ERROR!");
            }
        }
    }
}
