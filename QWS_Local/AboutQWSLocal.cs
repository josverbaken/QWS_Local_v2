using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QWS_Local
{
    partial class AboutQWSLocal : Form
    {
        public AboutQWSLocal()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.label1.Text = AssemblyProduct;
            this.label2.Text = String.Format("Version {0}", AssemblyVersion);
            this.label3.Text = AssemblyCopyright;
            this.label4.Text = AssemblyCompany;
            //this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutQWSLocal_Load(object sender, EventArgs e)
        {
            try
            {
                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    string deployedVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
                    label2.Text = "Version : " + deployedVersion;
                }
                else
                {
                    string deployedVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    label2.Text = "Version : " + deployedVersion;
                }
                string msg = "\r\n\r\nSite : ";
                string SiteLabel = string.Empty;
                // TODO refactor to cater for more than 2 sites
                if (Properties.Settings.Default.SiteID == 7)
                {
                    SiteLabel = "07 Northern Quarries";
                }
                else if (Properties.Settings.Default.SiteID == 2)
                {
                    SiteLabel = "02 Stawell Quarry";
                }
                msg += SiteLabel;
                string DomainName = Environment.UserDomainName;
                string Username = Environment.UserName;
                string MachineName = Environment.MachineName;
                msg += "\r\n\r\nUsername: " + DomainName + "\\" + Username;
                msg += "\r\n\r\nComputer: " + MachineName;
                textBoxDescription.Text += msg;
                if (Username.Contains(".") == false) 
                {
                    Username += ".";
                }
                int iCount = this.taOperator.FillBy(this.dsAdmin.Operator,Username);
                if ( iCount ==1)
                {
                    DataRow myRow = ((DataRowView)bsOperator.Current).Row;
                    dsAdmin.OperatorRow myOperatorRow = (dsAdmin.OperatorRow)myRow;
                    int OperatorID = myOperatorRow.OperatorID;
                    taOperatorRolesDetailed.Fill(dsAdmin.OperatorRolesDetailed, OperatorID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                    }
        }

   
    }
}
