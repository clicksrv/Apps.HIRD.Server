using HIRD.HWiNFOAccess;
using HIRD.Service;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Sockets;

namespace HIRD.ServerUI
{
    public partial class MainForm : Form
    {
        private GrpcServer? _grpcServer;
        private readonly ILoggerFactory _loggerFactory;
        private readonly ILogger<MainForm> _logger;
        private byte _hwInfoStatus = 3;

        public MainForm(ILoggerFactory loggerFactory)
        {
            InitializeComponent();
            compNameText.Text = Environment.MachineName;
            var ips = GetLocalIPAddress();
            if (ips.Count > 1)
                ipLabel.Text = "Local IP Addresses";
            ipText.Text = string.Join("\n", ips);

            _loggerFactory = loggerFactory;
            _logger = _loggerFactory.CreateLogger<MainForm>();

            SensorDataService.AddPeerEventDelegates.Add(AddPeer);
            SensorDataService.RemovePeerEventDelegates.Add(RemovePeer);
            CheckStatus();
            SetStatus();

            Task.Run(() => MonitorHWiNFO());

            LoadAsPerSettings();
            UpdateFormAsPerServerStatus();
        }

        private void LoadAsPerSettings()
        {
            if (_hwInfoStatus == 2 && AppSettings.Instance.AutoStartServer)
                startStopServerButton.Checked = true;

            if (AppSettings.Instance.StartMinimized)
            {
                WindowState = FormWindowState.Minimized;
                if (AppSettings.Instance.MinimizeToTray)
                    MinimizeToTray();
            }
        }

        public void AddPeer(string peer) => connectedClientsList.Invoke(() => connectedClientsList.Items.Add(peer));

        public void RemovePeer(string peer) => connectedClientsList.Invoke(() => connectedClientsList.Items.Remove(peer));

        private void MonitorHWiNFO()
        {
            byte lastStatus = _hwInfoStatus;

            while (true)
            {
                CheckStatus();

                if (_hwInfoStatus != lastStatus)
                {
                    Invoke(() => SetStatus());
                    lastStatus = _hwInfoStatus;
                }

                Task.Delay(2000).Wait();
            }
        }

        private void CheckStatus()
        {
            _logger.LogInformation("Checking HWiNFO Status");
            var isRunning = HWiNFOProcessDetails.IsRunning();
            var isSMRunning = isRunning && HWiNFOSharedMemoryAccessor.IsRunning();

            if (isRunning & isSMRunning)
                _hwInfoStatus = 2;
            else if (isRunning)
                _hwInfoStatus = 1;
            else
                _hwInfoStatus = 0;
        }

        private void SetStatus()
        {
            if (_hwInfoStatus == 0)
            {
                if (startStopServerButton.Checked)
                    startStopServerButton.Checked = false;

                statusLabel.Text = "Not Ready";
                errorLabel.Visible = true;
                errorLabel.Text = "HWiNFO64 is not running!";
                startStopServerButton.Enabled = false;
                statusIndicator.BackgroundImage = Properties.Resources.bullet_red;
                SetSize(false, true);
            }
            else if (_hwInfoStatus == 1)
            {
                if (startStopServerButton.Checked)
                    startStopServerButton.Checked = false;

                statusLabel.Text = "Not Ready";
                errorLabel.Visible = true;
                errorLabel.Text = "HWiNFO64 Shared Memory Access is not enabled! See Help to learn how to enable.";
                startStopServerButton.Enabled = false;
                statusIndicator.BackgroundImage = Properties.Resources.bullet_red;
                SetSize(false, true);
            }
            else if (statusLabel.Text == "Not Ready")
            {
                statusLabel.Text = "Ready";
                errorLabel.Text = "";
                errorLabel.Visible = false;
                startStopServerButton.Enabled = true;
                statusIndicator.BackgroundImage = Properties.Resources.bullet_yellow;
                SetSize(_grpcServer != null, false);
                if (AppSettings.Instance.AutoStartServer)
                    startStopServerButton.Checked = true;
            }
        }

        private void SetSize(bool running, bool error)
        {
            const int width = 314;

            if (running)
            {
                statusGroup.Height = 168;

                Size size = new(width, 401);
                MinimumSize = size;
                MaximumSize = size;
                Height = size.Height;
            }
            else
            {
                statusGroup.Height = error ? 84 : 48;

                Size size = new(width, error ? 167 : 128);
                MinimumSize = size;
                MaximumSize = size;
                Height = size.Height;
            }
        }

        private async void StartStopServerButton_CheckedChanged(object sender, EventArgs e)
        {
            startStopServerButton.Enabled = false;
            statusIndicator.BackgroundImage = Properties.Resources.bullet_yellow;

            try
            {
                if (startStopServerButton.Checked)
                {
                    statusLabel.Text = "Starting Server...";
                    startStopServerButton.Text = "Starting Server";
                    _grpcServer = new(_loggerFactory.CreateLogger<GrpcServer>());
                    await _grpcServer.StartAsync(new CancellationToken());
                }
                else
                {
                    statusLabel.Text = "Stopping Server...";
                    startStopServerButton.Text = "Stopping Server";
                    await _grpcServer!.StopAsync(new CancellationToken());
                    _grpcServer.Dispose();
                    _grpcServer = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                $"Error when {(startStopServerButton.Checked ? "stopping" : "starting")} the server",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
#if DEBUG
                MessageBox.Show($"{ex.Source}\n\n{ex.StackTrace}", "Stacktrace");
#endif
            }

            UpdateFormAsPerServerStatus();

            startStopServerButton.Enabled = true;
        }

        private void UpdateFormAsPerServerStatus()
        {
            bool isServerRunning = _grpcServer != null;

            startStopServerButton.Checked = isServerRunning;
            connectedClientsLabel.Visible = isServerRunning;
            connectedClientsList.Visible = isServerRunning;
            serverInfoGroup.Visible = isServerRunning;

            if (isServerRunning)
            {
                startStopServerButton.Text = "Stop Server";
                statusLabel.Text = "Running";
                statusIndicator.BackgroundImage = Properties.Resources.bullet_green;
            }
            else
            {
                connectedClientsList.Items.Clear();
                startStopServerButton.Text = "Start Server";

                if (_hwInfoStatus == 2)
                {
                    statusLabel.Text = "Ready";
                    statusIndicator.BackgroundImage = Properties.Resources.bullet_yellow;
                }
            }

            SetSize(isServerRunning, _hwInfoStatus != 2);
        }

        private static List<string> GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            List<string> ips = new();
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    ips.Add(ip.ToString());
            }

            if (ips.Count == 0)
                throw new IPAddressNotFoundException();

            return ips;
        }

        private void RecheckButton_Click(object sender, EventArgs e) => CheckStatus();

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RestoreFromTray();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (AppSettings.Instance.MinimizeToTray && WindowState == FormWindowState.Minimized)
                MinimizeToTray();
        }

        private void RestoreFromTray()
        {
            Show();
            WindowState = FormWindowState.Normal;
            BringToFront();
            SetSize(_grpcServer != null, statusLabel.Text == "Not Ready");
            ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }

        private void MinimizeToTray()
        {
            WindowState = FormWindowState.Minimized;
            notifyIcon.Visible = true;
            Hide();
            ShowInTaskbar = false;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new();
            settingsForm.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ensure that HWiNFO64 is installed and running.\n\nFrom the System Tray, right click HWiNFO and open Settings.\n\nEnsure Shared Memory Support is checked.\n\nEnsure that this machine and your phone are connected to the same network.\n\nClick on Start Server.\n\nOpen an HIRD client app and select this server.", "How to run HIRD", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            startStopServerButton.Checked = false;
        }
    }
}