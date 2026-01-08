using StockMonitoringCommunity.Data;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Net.Sockets;

namespace StockMonitoringCommunity.SubForm
{
    public partial class ConnectServerUserForm : UserControl
    {
        public ConnectServerUserForm()
        {
            InitializeComponent();
        }
        private void ConnectServerUserForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var store = db.Stores.ToList();
                    cmbStore.Items.Clear();
                    cmbStore.Items.AddRange(store);

                    var server = db.ServerConnections.FirstOrDefault(x => x.SourcePCID == GetHardwareUUID());
                    if (server != null)
                    {
                        txtIP.Text = server.ServerAddress;
                        txtPort.Text = server.Port.ToString();
                        cmbStore.Text = server?.StoreID!;
                    }


                }
            }
            catch
            {
                MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isValidIP = IsStrictIPv4(txtIP.Text.Trim());
            bool isValidPort = IsDigitsOnly(txtPort.Text.Trim());
            string uuid = GetHardwareUUID();

            if (isValidIP && isValidPort)
            {
                using (var db = new AppDbContext())
                {
                    var server = db.ServerConnections.FirstOrDefault(x => x.SourcePCID == uuid);
                    if (server == null)
                    {
                        server = new ServerConnection
                        {
                            SourcePCID = uuid,
                            ServerAddress = txtIP.Text.Trim(),
                            Port = int.Parse(txtPort.Text.Trim()),
                            StoreID = cmbStore.Text.Trim()
                        };
                        db.ServerConnections.Add(server);
                    }
                    else
                    {
                        server.ServerAddress = txtIP.Text.Trim();
                        server.Port = int.Parse(txtPort.Text.Trim());
                        server.StoreID = cmbStore.Text.Trim();
                        db.ServerConnections.Update(server);
                    }
                    db.SaveChanges();
                    lbResult.Text = "Saved successfully.";
                }
            }
            else
            {
                lbResult.Text = "Invalid IP or Port.";
            }
        }



        public static string GetHardwareUUID()
        {
            using var searcher = new ManagementObjectSearcher(
                "SELECT UUID FROM Win32_ComputerSystemProduct");

            foreach (ManagementObject obj in searcher.Get())
            {
                var uuid = obj["UUID"]?.ToString();
                if (!string.IsNullOrWhiteSpace(uuid))
                    return uuid;
            }

            return string.Empty;
        }

        private bool IsStrictIPv4(string input)
        {
            if (!IsValidIPv4(input))
                return false;

            return input.Split('.')
                        .All(octet => octet == "0" || !octet.StartsWith("0"));
        }
        private bool IsValidIPv4(string input)
        {
            return IPAddress.TryParse(input, out var ip)
                && ip.AddressFamily == AddressFamily.InterNetwork;
        }
        private bool IsDigitsOnly(string input)
        {
            return input.All(char.IsDigit);
        }



    }


}
