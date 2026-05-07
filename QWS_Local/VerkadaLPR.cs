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
    public partial class VerkadaLPR : Form
    {
        public VerkadaLPR()
        {
            InitializeComponent();
        }

        private void VerkadaLPR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsVerkada.LPR2Discard' table. You can move, or remove it, as needed.
            this.talPR2Discard.Fill(this.dsVerkada.LPR2Discard);
            // TODO: This line of code loads data into the 'dsVerkada.LicensePlates' table. You can move, or remove it, as needed.
            this.taLicensePlates.Fill(this.dsVerkada.LicensePlates);
            // TODO: This line of code loads data into the 'dsVerkada.Vehicles' table. You can move, or remove it, as needed.
            this.taVehiclesLPR.Fill(this.dsVerkada.Vehicles);
            // TODO: This line of code loads data into the 'dsVerkada.VehiclesOnSite' table. You can move, or remove it, as needed.
            this.taVehiclesOnSite.Fill(this.dsVerkada.VehiclesOnSite);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetVehiclesOnSite();
        }

        private void GetVehiclesOnSite()
        {
            try
            {
                int iOffset = 10;
                // TODO nudOffset.Value cast decimal to int
                // TODO remember DTP might be out of sync if page open for a long time
                taVehiclesOnSite.FillBy(dsVerkada.VehiclesOnSite,dateTimePicker1.Value,iOffset);
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
    }
}
