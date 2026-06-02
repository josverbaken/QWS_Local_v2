using System;
using System.Data;
using System.Deployment.Application;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Windows.Forms;

namespace QWS_Local
{
    partial class AboutQWSLocal : Form
    {
        private static string NetworkAddress = string.Empty;
        private static string NetworkSubnet = string.Empty;

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
                GetNetworkInfo();
                // AssemblyInfo.cs
                //[assembly: AssemblyVersion("0.5.1.0")] // this is what shows in label2 above
                //[assembly: AssemblyFileVersion("0.5.1.5")]

                //// Get the version of the currently executing app
                //Version version = Assembly.GetExecutingAssembly().GetName().Version;
                //string displayVersion = version.ToString();
                //label5.Text = displayVersion;

                //// Get specific attributes like Title or Description
                //var assembly = Assembly.GetExecutingAssembly();
                //var titleAttribute = (AssemblyTitleAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyTitleAttribute));
                //string title = titleAttribute?.Title;
                //label6.Text = title;



                string msg = "\r\n\r\nSite : ";
                string SiteLabel = string.Empty;
                var parent = this.MdiParent as QWS_MDIParent;
                int SiteID = parent.SiteID;
                if (SiteID == 7)
                {
                    SiteLabel = "07 Northern Quarries";
                }
                else if (SiteID == 2)
                {
                    SiteLabel = "02 Stawell Quarry";
                }
                else
                {
                    SiteLabel = "Site Unknown!";
                }
                msg += SiteLabel;
                string DomainName = Environment.UserDomainName;
                string Username = Environment.UserName;
                string MachineName = Environment.MachineName;
                msg += "\r\n\r\nUsername: " + DomainName + "\\" + Username;
                msg += "\r\n\r\nComputer: " + MachineName;
                msg += "\r\n\r\nNetwork IP: " + NetworkAddress;
                msg += "\r\n\r\nNetwork Subnet: " + NetworkSubnet;
                textBoxDescription.Text += msg;
                if (Username.Contains(".") == false)
                {
                    Username += ".";
                }
                int iCount = this.taOperator.FillBy(this.dsAdmin.Operator, Username);
                if (iCount == 1)
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

        private void GetNetworkInfo()
        {
            try
            {
                NetworkAddress = GetEthernetIpAddress();
                NetworkSubnet = "192.168.15.0/24"; //TODO
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string GetEthernetIpAddress()
        {
            string strReturn = "tba";
            var ethernetInterface = NetworkInterface.GetAllNetworkInterfaces()
                .FirstOrDefault(ni => ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet
                                   && ni.OperationalStatus == OperationalStatus.Up);

            if (ethernetInterface != null)
            {
                var ipProps = ethernetInterface.GetIPProperties();
                var ipv4Address = ipProps.UnicastAddresses
                    .FirstOrDefault(ua => ua.Address.AddressFamily == AddressFamily.InterNetwork);

                if (ipv4Address != null)
                {
                    strReturn = ipv4Address.Address.ToString();
                }
            }
            return strReturn;
        }

        public struct CidrSubnet
        {
            private readonly byte[] _networkAddressBytes;
            private readonly byte[] _subnetMaskBytes;

            public CidrSubnet(string cidrNotation)
            {
                var parts = cidrNotation.Split('/');
                if (parts.Length != 2)
                    throw new ArgumentException("Invalid CIDR notation format.");

                var ipAddress = IPAddress.Parse(parts[0]);
                int prefixLength = int.Parse(parts[1]);

                _networkAddressBytes = ipAddress.GetAddressBytes();
                _subnetMaskBytes = GetSubnetMaskBytes(prefixLength, _networkAddressBytes.Length);
            }

            private static byte[] GetSubnetMaskBytes(int prefixLength, int addressLength)
            {
                var maskBytes = new byte[addressLength];
                for (var i = 0; i < addressLength; i++)
                {
                    if (prefixLength >= 8)
                    {
                        maskBytes[i] = 255;
                        prefixLength -= 8;
                    }
                    else
                    {
                        maskBytes[i] = (byte)(255 << (8 - prefixLength));
                        prefixLength = 0;
                    }
                }
                return maskBytes;
            }

            public bool Contains(string targetIpAddress)
            {
                var targetBytes = IPAddress.Parse(targetIpAddress).GetAddressBytes();
                if (targetBytes.Length != _networkAddressBytes.Length) return false;

                for (var i = 0; i < targetBytes.Length; i++)
                {
                    // Apply bitwise AND with the subnet mask to isolate the network portion
                    if ((targetBytes[i] & _subnetMaskBytes[i]) != (_networkAddressBytes[i] & _subnetMaskBytes[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
        }



    }
}
