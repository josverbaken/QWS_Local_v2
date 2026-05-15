using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class VerkadaLPR : Form
    {
        public VerkadaLPR()
        {
            InitializeComponent();
        }

        private void VerkadaLPR_Load(object sender, EventArgs e)
        {
            lblUTCOffset.Text = "UTC Offset = " + GetUTCOffset().ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetVehiclesOnSite(false); // now
        }

        private void GetVehiclesOnSite(bool dtp)
        {
            try
            {
                int iOffset = GetUTCOffset();
                DateTime EntryDTTM = DateTime.Now;
                if (dtp == true)
                {
                    EntryDTTM = dateTimePicker1.Value;
                }
                taVehiclesOnSite.FillBy(dsVerkada.VehiclesOnSite, EntryDTTM, iOffset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvVehiclesOnSite_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Replace "YourColumnName" with the actual name or index of your int column
            if (this.dgvVehiclesOnSite.Columns[e.ColumnIndex].Name == "Duration" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int totalMinutes))
                {
                    // Calculate hours and minutes from the integer
                    int hours = totalMinutes / 60;
                    int minutes = totalMinutes % 60;

                    // Set the display value in HH:mm format
                    e.Value = string.Format("{0:00}:{1:00}", hours, minutes);
                    e.FormattingApplied = true;
                }
            }
    }

        private void rbAllPlates_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllPlates.Checked)
            {
                bsVehiclesOnSite.Filter = "";
            }
        }

        private void rbQuarryOnSite_CheckedChanged(object sender, EventArgs e)
        {
            bsVehiclesOnSite.Filter = "VehicleType like 'Quarry' AND VisitStatus like 'On Site'";
        }

        private void rbAllOnSite_CheckedChanged(object sender, EventArgs e)
        {
            bsVehiclesOnSite.Filter = "VisitStatus like 'On Site'";
        }

        private void rbQuarryToday_CheckedChanged(object sender, EventArgs e)
        {
            bsVehiclesOnSite.Filter = "VehicleType like 'Quarry'";
        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            VehicleSave();
        }

        private void VehicleSave()
        {
            try
            {
                taVehiclesLPR.Update(dsVerkada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindVehicle_Click(object sender, EventArgs e)
        {
            VehicleFind();
        }

        private void VehicleFind()
        {
            try
            {
                string strRego = "%";
                strRego += txtVehicleRego.Text;
                strRego += "%";
                taVehiclesLPR.FillBy(dsVerkada.Vehicles, strRego);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshVehicle_Click(object sender, EventArgs e)
        {
            taVehiclesLPR.Fill(dsVerkada.Vehicles);
        }

        private dsVerkada.LicensePlatesRow CurrentLPR()
        {
            if (bsLicensePlates.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsLicensePlates.Current).Row;
                dsVerkada.LicensePlatesRow myLPRRow = (dsVerkada.LicensePlatesRow)myRow;
                return myLPRRow;
            }
            else
            {
                return null;
            }
        }

        private dsVerkada.VehiclesOnSiteRow CurrentLPRVehicle()
        {
            if (bsVehiclesOnSite.Count > 0)
            {
                DataRow myRow = ((DataRowView)bsVehiclesOnSite.Current).Row;
                dsVerkada.VehiclesOnSiteRow myLPRVehicleRow = (dsVerkada.VehiclesOnSiteRow)myRow;
                return myLPRVehicleRow;
            }
            else
            {
                return null;
            }
        }

        private void btnLPFind_Click(object sender, EventArgs e)
        {
            LicensPlateFind();
        }

        private void LicensPlateFind()
        {
            try
            {
                string strLP = "%";
                strLP += txtLicensePlate.Text;
                strLP += "%";
                taLicensePlates.FillBy(dsVerkada.LicensePlates, strLP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLPSave_Click(object sender, EventArgs e)
        {
            LicensePlateSave();
        }

        private void LicensePlateSave()
        {
            try
            {
                taLicensePlates.Update(dsVerkada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLPRefresh_Click(object sender, EventArgs e)
        {
            LicensePlateRefresh();
        }

        private void LicensePlateRefresh()
        {
            try
            {
                taLicensePlates.Fill(dsVerkada.LicensePlates);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDiscardsFind_Click(object sender, EventArgs e)
        {
            DiscardsFind();
        }

        private void DiscardsFind()
        {
            try
            {
                string strLPR2Find = "%";
                strLPR2Find += txtDiscards.Text;
                strLPR2Find += "%";
                talPR2Discard.FillBy(dsVerkada.LPR2Discard, strLPR2Find);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDiscardsSave_Click(object sender, EventArgs e)
        {
            DiscardsSave();
        }

        private void DiscardsSave()
        {
            try
            {
                talPR2Discard.Update(dsVerkada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDiscardsRefresh_Click(object sender, EventArgs e)
        {
            DiscardsRefresh();
        }

        private void DiscardsRefresh()
        {
            try
            {
                talPR2Discard.Fill(dsVerkada.LPR2Discard);
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void btnManualExit_Click(object sender, EventArgs e)
        {
            ManualExit();
        }

        private void btnRefreshDTP_Click(object sender, EventArgs e)
        {
            GetVehiclesOnSite(true);
        }

        private int GetUTCOffset()
        {
            try
            {
                DateTimeOffset now = DateTimeOffset.Now;
                TimeSpan offset = now.Offset;
                int UTCOffset = System.Convert.ToInt32(offset.TotalHours);
                return UTCOffset;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 10;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckLANIP();
        }


    
        public void CheckLANIP()
        {
            string hostName = Dns.GetHostName(); // Get local machine name
            var host = Dns.GetHostEntry(hostName);

            // Filter for IPv4 addresses
            var localIP = host.AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
            MessageBox.Show($"Local IPv4 Address: {localIP}");
        }
    
        public void ManualExit()
        {
            try
            {
                dsVerkada.VehiclesOnSiteRow vehiclesOnSiteRow = CurrentLPRVehicle();
                if (vehiclesOnSiteRow.VisitStatus == "Departed" )
                {
                    MessageBox.Show("Already departed!","Check status",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    dtpManualDepartureDTTM.Value = vehiclesOnSiteRow.EntryDTTM;
                    tabControl1.SelectedTab = tpManualExit;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ManualExit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveManualExit_Click(object sender, EventArgs e)
        {
            SaveManualExit();
        }

        private void SaveManualExit()
        {
            try
            {
                dsVerkada.VehiclesOnSiteRow vehiclesOnSiteRow = CurrentLPRVehicle();
                string msg = string.Empty;
                if (vehiclesOnSiteRow.Duration < 20)
                {
                    msg = "Confirm departure, has only been on site " + vehiclesOnSiteRow.Duration.ToString();
                }
                if (msg.Length > 0) 
                {
                    msg += "\r\n";
                }
                msg += "TODO save most likely using stored procedure";
                MessageBox.Show(msg);
                if (dtpManualDepartureDTTM.Value <= vehiclesOnSiteRow.EntryDTTM)
                {
                    msg = "Can't leave before Entry DTTM!@#";
                    MessageBox.Show(msg);
                }
                else
                {
                    GetVehiclesOnSite(false);
                    tabControl1.SelectedTab = tpSeenLPR;
                }                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
