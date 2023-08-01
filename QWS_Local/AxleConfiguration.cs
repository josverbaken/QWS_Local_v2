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
            // TODO: This line of code loads data into the 'dsQWSLocal.AxleConfiguration' table. You can move, or remove it, as needed.
            this.axleConfigurationTableAdapter.Fill(this.dsQWSLocal.AxleConfiguration);
            //this.dgvAxleConfiguration.rowhei
        }

              private void tspUpdate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.axleConfigurationBindingSource.EndEdit();
            this.axleConfigurationTableAdapter.Update(this.dsQWSLocal.AxleConfiguration);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            uploadPicture();
        }

        private void uploadPicture()
        {
            try
            {
                DataRow myDR = ((DataRowView)axleConfigurationBindingSource.Current).Row;
                dsQWSLocal.AxleConfigurationRow axleconfigRow = (dsQWSLocal.AxleConfigurationRow)myDR;
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
                //throw;
            }
        }
    }
}
