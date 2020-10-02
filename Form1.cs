using System;
using System.IO;
using System.Management;
using System.Net;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection;

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

                string s = asm.GetName().Name + "\r\n";

                objectsDomain.Items.Add(s);

            }

            this.domain.Text = domain.FriendlyName;
        }

        void GetListOfNetPorts()
        {
            int nPort = 0;
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnections = properties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation port in tcpConnections)
                portsBox.Items.Add("Port #" + ++nPort + ": " + port.LocalEndPoint.Port);
        }

        void WriteToTxt()
        {
            FolderBrowserDialog DirDialog = new FolderBrowserDialog
            {
                Description = "Выбор директории",
                SelectedPath = @"C:\"
            };

            if (DirDialog.ShowDialog() == DialogResult.OK)
            {
                string writePath = DirDialog.SelectedPath + @"\SystemInfo." + format.Text;
                pathDir.Text = writePath;
                
                try
                {

                    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine("Информация о сети:");
                        sw.WriteLine(ipLabel.Text);
                        sw.WriteLine(domain.Text);
                        sw.WriteLine("\n");
                    
                        sw.WriteLine("Информация о компьютере:");
                        sw.WriteLine(osVer.Text);                                
                        sw.WriteLine(totalRam.Text);
                        sw.WriteLine("\n");

                        sw.WriteLine("\n");
                        sw.WriteLine("Запись выполнена в:");
                        sw.WriteLine(DateTime.Now);
                    }

                    result.Text = "Запись выполнена";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
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
    }
}
