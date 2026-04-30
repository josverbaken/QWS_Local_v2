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

        private void rbPrimary_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrimary.Checked)
            {
                bsLicensePlates.Filter = "LicensePlate like Rego";
            }
        }

        private void rbMapped_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMapped.Checked)
            {
                bsLicensePlates.Filter = "LicensePlate not like Rego";
            }
        }

        private void rbAllLicensePlates_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllLicensePlates.Checked)
            {
                bsLicensePlates.Filter = "";
            }
        }

        private void rbQuarry_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQuarry.Checked)
            {
                bsVehicles.Filter = "VehicleType like 'Quarry'";
            }
        }

        private void rbVehicles_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVehicles.Checked)
            {
                bsVehicles.Filter = "VehicleType not like 'Quarry'";
            }
        }

        private void rbAllVehicles_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllVehicles.Checked)
            {
                bsVehicles.Filter = "";
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
    }
}
