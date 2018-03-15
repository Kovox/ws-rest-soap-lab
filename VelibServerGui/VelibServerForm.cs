using System;
using System.Diagnostics;
using System.Web.Caching;
using System.Windows.Forms;
using VelibServerGui.VelibServices;

namespace VelibServerGui
{
    public partial class VelibServerForm : Form
    {
        /// <summary>
        /// 0 = CacheButton
        /// 1 = MonitoringButton
        /// </summary>
        private Int16 focus = 0;

        private const String infoLogAbsoluteExpiration = "Cache absolute expiration time set to: ";
        private const String infoLogSlidingExpiration = "Cache sliding expiration time set to: ";
        private const String infoLogAbsoluteExpirationError = "ERROR: Cache absolute expiration time has " +
            "to be a number...";
        private const String infoLogSlidingExpirationError = "ERROR: Cache sliding expiration time has " +
            "to be a number...";

        private static VelibServicesClient client = new VelibServicesClient("WSHTTP");

        public VelibServerForm()
        {
            InitializeComponent();
            ButtonSidePanel.Height = CacheButton.Height;
            ButtonSidePanel.Top = CacheButton.Top;

            AbsoluteExpirationTimeComboBox.Items.Add("No Absolute Expiration");
            AbsoluteExpirationTimeComboBox.Items.Add("1");
            AbsoluteExpirationTimeComboBox.Items.Add("3");
            AbsoluteExpirationTimeComboBox.Items.Add("5");
            AbsoluteExpirationTimeComboBox.Items.Add("10");
            AbsoluteExpirationTimeComboBox.Items.Add("30");
            AbsoluteExpirationTimeComboBox.Items.Add("60");
            AbsoluteExpirationTimeComboBox.Items.Add("120");

            SlidingExpirationTimeComboBox.Items.Add("No Sliding Expiration");
            SlidingExpirationTimeComboBox.Items.Add("Zero");
            SlidingExpirationTimeComboBox.Items.Add("1");
            SlidingExpirationTimeComboBox.Items.Add("3");
            SlidingExpirationTimeComboBox.Items.Add("5");
            SlidingExpirationTimeComboBox.Items.Add("10");
            SlidingExpirationTimeComboBox.Items.Add("30");
            SlidingExpirationTimeComboBox.Items.Add("60");
            SlidingExpirationTimeComboBox.Items.Add("120");

            if (VelibLibrary.CacheExtension.AbsoluteExpiration == Cache.NoAbsoluteExpiration)
            {
                AbsoluteExpirationTimeComboBox.Text = "No Absolute Expiration";
            }
            else
            {
                AbsoluteExpirationTimeComboBox.Text =  VelibLibrary.CacheExtension.AbsoluteExpiration.Minute.ToString();
            }

            if (VelibLibrary.CacheExtension.SlidingExpiration == Cache.NoSlidingExpiration)
            {
                SlidingExpirationTimeComboBox.Text = "No Sliding Expiration";
            }
            else
            {
                SlidingExpirationTimeComboBox.Text = VelibLibrary.CacheExtension.SlidingExpiration.TotalMinutes.ToString();
            }

        }

        // Stations button

        private void Cache_Click(object sender, EventArgs e)
        {
            ButtonSidePanel.Height = CacheButton.Height;
            ButtonSidePanel.Top = CacheButton.Top;
            focus = 0;
            ButtonClicked();
        }

        private void CacheButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip sbToolTip = new ToolTip();
            sbToolTip.SetToolTip(CacheButton, "Manage cache settings");
        }

        // Bikes button

        private void Monitoring_Click(object sender, EventArgs e)
        {
            ButtonSidePanel.Height = MonitoringButton.Height;
            ButtonSidePanel.Top = MonitoringButton.Top;
            focus = 1;
            ButtonClicked();
        }

        private void MonitoringButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip bbToolTip = new ToolTip();
            bbToolTip.SetToolTip(MonitoringButton, "Monitoring view (server deep statistics)");
        }

        // JCDecaux panel

        private void JCDecaux_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("http://www.jcdecaux.fr/");
            Process.Start(startInfo);
        }

        private void ApplyChangesButton_Click(object sender, EventArgs e)
        {
            switch (AbsoluteExpirationTimeComboBox.Text)
            {
                case "No Absolute Expiration":
                    VelibLibrary.CacheExtension.AbsoluteExpiration = Cache.NoAbsoluteExpiration;
                    InfoTextBox.Text = infoLogAbsoluteExpiration + "NoAbsoluteExpiration." + Environment.NewLine;
                    break;
                default:
                    int n;
                    bool isNumeric = int.TryParse(AbsoluteExpirationTimeComboBox.Text, out n);
                    if (isNumeric)
                    {
                        VelibLibrary.CacheExtension.AbsoluteExpiration = new DateTime().AddMinutes(n);
                        InfoTextBox.Text = infoLogAbsoluteExpiration + AbsoluteExpirationTimeComboBox.Text + Environment.NewLine;
                    }
                    else
                    {
                        InfoTextBox.Text = infoLogAbsoluteExpirationError + Environment.NewLine;
                    }
                    break;
            }

            switch (SlidingExpirationTimeComboBox.Text)
            {
                case "No Sliding Expiration":
                    VelibLibrary.CacheExtension.SlidingExpiration = Cache.NoSlidingExpiration;
                    InfoTextBox.Text += infoLogSlidingExpiration + "NoSlidingExpiration.";
                    break;
                case "Zero":
                    VelibLibrary.CacheExtension.SlidingExpiration = TimeSpan.Zero;
                    InfoTextBox.Text += infoLogSlidingExpiration + "Zero.";
                    break;
                default:
                    int n;
                    bool isNumeric = int.TryParse(SlidingExpirationTimeComboBox.Text, out n);
                    if (isNumeric)
                    {
                        VelibLibrary.CacheExtension.SlidingExpiration = new TimeSpan(0, n, 0);
                        InfoTextBox.Text += infoLogSlidingExpiration + SlidingExpirationTimeComboBox.Text + ".";
                    }
                    else
                    {
                        InfoTextBox.Text += infoLogSlidingExpirationError + ".";
                    }
                    break;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            VelibLibrary.CacheExtension.ClearCache();
            InfoTextBox.Text = "Cache successfully cleared...";
        }

        private void ButtonClicked()
        {
            switch (focus)
            {
                case 0:
                    CachePanel.Visible = true;
                    break;
                case 1:
                    CachePanel.Visible = false;
                    break;
            }
        }
    }
}