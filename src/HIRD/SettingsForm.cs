using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIRD.ServerUI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            startMin.Checked = AppSettings.Instance.StartMinimized;
            startAtWindowsStart.Checked = AppSettings.StartWithWindows;
            minToTray.Checked = AppSettings.Instance.MinimizeToTray;
            autoStart.Checked = AppSettings.Instance.AutoStartServer;
        }

        private void startAtWindowsStart_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.StartWithWindows = startAtWindowsStart.Checked;
        }

        private void startMin_CheckedChanged(object sender, EventArgs e)
        {
            var settings = AppSettings.Instance;
            settings.StartMinimized = startMin.Checked;
            settings.Save();
        }

        private void minToTray_CheckedChanged(object sender, EventArgs e)
        {
            var settings = AppSettings.Instance;
            settings.MinimizeToTray = minToTray.Checked;
            settings.Save();
        }

        private void autoStart_CheckedChanged(object sender, EventArgs e)
        {
            var settings = AppSettings.Instance;
            settings.AutoStartServer = autoStart.Checked;
            settings.Save();
        }
    }
}
