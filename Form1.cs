using System;
using System.IO;
using System.Management;
using System.Net;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;

namespace LabWebProgramme_1
{
    public partial class InfoForm : Form
    {
        readonly uint byteInGb = 1073741824;
        readonly string hostName;
        readonly IPHostEntry standartHostEntry;

        public InfoForm()
        {
            InitializeComponent();
            hostName = Dns.GetHostName();
            standartHostEntry = Dns.GetHostEntry(hostName);
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            IPAddress ipAddress = GetIp();
            ipLabel.Text = "IP address: " + ipAddress.ToString();
            osVer.Text = "Версия ОС: " + Environment.OSVersion.ToString();
            totalRam.Text = "RAM: " + GetRAM();

            GetListOfDomainObjects();
            GetListOfHardDrives();
            GetListOfNetPorts();
            GetAV();

            IPHostEntry hostEntry = Dns.GetHostEntry(ipAddress);
            domain.Text = "Домен: " + hostEntry.HostName;
        }

        IPAddress GetIp()
        {
            foreach (IPAddress ip in standartHostEntry.AddressList)
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    return ip;
            throw new Exception("Ошибка получения IPv4/Error get IPv4");
        }

        void GetListOfHardDrives()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                try
                {
                    drivesBox.Items.Add("Name: " + drive.Name + ", disk size: " + drive.TotalSize / byteInGb + " GB");
                }
                catch
                {
                    drivesBox.Items.Add("No drive");
                }
            }
        }

        string GetRAM()
        {
            ulong totalRAM = new ulong();

            ConnectionOptions connectionOptions = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate
            };
            ManagementScope scope = new ManagementScope("\\root\\CIMV2", connectionOptions);
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");

            scope.Connect();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

            foreach (ManagementBaseObject obj in searcher.Get())
                totalRAM += Convert.ToUInt64(obj["Capacity"]) / byteInGb;

            return totalRAM.ToString() + " Gb";
        }

        void GetAV()
        {
            ConnectionOptions connectionOptions = new ConnectionOptions
            {
                EnablePrivileges = true,
                Impersonation = ImpersonationLevel.Impersonate
            };
            ManagementScope scope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", connectionOptions);
            ObjectQuery query = new ObjectQuery("SELECT * FROM AntivirusProduct");

            scope.Connect();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

            foreach (ManagementObject obj in searcher.Get())
                antiVirusBox.Items.Add(obj["displayName"].ToString());
        }

        void GetListOfDomainObjects()
        {
            AppDomain domain = AppDomain.CurrentDomain;
            Assembly[] assemblies = domain.GetAssemblies();
            foreach (Assembly asm in assemblies)
            {
                string s = asm.GetName().Name;
                objectsDomain.Items.Add(s);
            }
        }

        void GetListOfNetPorts()
        {
            int nPort = 0;
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnections = properties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation port in tcpConnections)
                portsBox.Items.Add("Port #" + ++nPort + ": " + port.LocalEndPoint.Port);
        }
        string GetSysInfo()
        {
            string text = "Системная информация";

            text += "\n";
            text += "\n-";
            text += "Информация о компьютере:";

            if(osVer.Checked == true)
            {
                text += "\n--";
                text += osVer.Text;
            }

            if (totalRam.Checked == true)
            {
                text += "\n--";
                text += totalRam.Text;
            }    

            if(objectsInDomain.Checked == true)
            {
                text += "\n";
                text += "\n--";
                text += objectsInDomain.Text;
                text += "\n";
                text += GetListOfBox(objectsDomain);
            }

            if (infoAV.Checked == true)
            {
                text += "\n--";
                text += infoAV.Text;
                text += "\n";
                text += GetListOfBox(antiVirusBox);
            }

            if(drivesInfo.Checked == true)
            {
                text += "\n--";
                text += drivesInfo.Text;
                text += "\n";
                text += GetListOfBox(drivesBox);
            }


            text += "\n";
            text += "\n-";
            text += "Сетевая информация:";

            if (ports.Checked == true)
            {
                text += "\n--";
                text += ports.Text;
                text += "\n";
                text += GetListOfBox(portsBox);
            }

            if (ipLabel.Checked == true)
            {
                text += "\n--";
                text += ipLabel.Text;
            }

            if (domain.Checked == true)
            {
                text += "\n--";
                text += domain.Text;
            }

            return text;
        }


        void WriteToTxt()
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                OverwritePrompt = true,
                Filter = format.Text,
                FileName = "SysInfo"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string allInfo = GetSysInfo();
                File.WriteAllText(sfd.FileName, allInfo, Encoding.UTF8);
                result.Text = "Запись выполнена";
                pathDir.Text = sfd.InitialDirectory + sfd.FileName;
            }
        }

        private void SaveButt_Click(object sender, EventArgs e)
        {
            WriteToTxt();
        }

        private void Format_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveButt.Visible = true;
            pathDir.Visible = true;
            result.Visible = true;
        }

        string GetListOfBox(ListBox objList)
        {
            string list = "";
            foreach (string item in objList.Items)
            {
                list += "---";
                list += item;
                list += "\n";
            }
            return list;
        }
    }
}
