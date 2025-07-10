using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWS_Local
{
    public partial class AxleConfiguration : Form
    {
        public AxleConfiguration()
        {
            InitializeComponent();
        }

        private void Axle_Configuration_Load(object sender, EventArgs e)
        {
            this.taAxleConfig.Fill(this.dsQWSLocal2024.AxleConfiguration);
            this.bsAxleConfig.Sort = "AxleConfiguration";
        }

              private void tspUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bsAxleConfig.EndEdit();
                this.taAxleConfig.Update(this.dsQWSLocal2024.AxleConfiguration);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            uploadPicture();
        }

        private void uploadPicture()
        {
            try
            {
                DataRow myDR = ((DataRowView)bsAxleConfig.Current).Row;
                dsQWSLocal2024.AxleConfigurationRow axleconfigRow = (dsQWSLocal2024.AxleConfigurationRow)myDR;
                OpenFileDialog openFileDialog = this.openFileDialog1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string strPath = openFileDialog.FileName;
                    // get image for picturebox
                    //Bitmap bit = new Bitmap(openFileDialog.FileName);
                    //pictureBox1.Image = bit;

                    // need a byte array for database
                    FileStream fs = File.OpenRead(strPath);
                    Byte[] myPicture = new byte[fs.Length];
                    fs.Read(myPicture, 0, (int) fs.Length);
                    axleconfigRow.Schematic = myPicture;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upload Error");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.bsAxleConfig.Filter = "VehicleType like 'cmb'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.bsAxleConfig.Filter = "";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.bsAxleConfig.Filter = "VehicleType not like 'cmb'";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string searchPattern = "AxleConfiguration like '";
            searchPattern += tspSearchPattern.Text;
            searchPattern += "%'"; 
            this.bsAxleConfig.Filter = searchPattern;
        }
    }
}
