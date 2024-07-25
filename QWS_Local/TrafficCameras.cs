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
    public partial class TrafficCameras : Form
    {
        public TrafficCameras()
        {
            InitializeComponent();
        }

        private void TrafficCameras_Load(object sender, EventArgs e)
        {
            LoadWebPage();
        }

        private void LoadWebPage()
        {
            this.webBrowser1.Navigate("http://verbaken.au");


        }
    }
}
