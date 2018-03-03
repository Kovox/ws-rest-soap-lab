using System;
using System.Diagnostics;
using System.Windows.Forms;
using VelibClientGui.VelibServices;

namespace VelibClientGui
{
    public partial class VelibClientForm : Form
    {
        /// <summary>
        /// 0 = StationsButton
        /// 1 = BikesButton
        /// </summary>
        private Int16 focus = 0;

        private Boolean cityTextBoxReady = false;
        private Boolean stationTextBoxReady = false;

        private static VelibServicesClient client = new VelibServicesClient("WSHTTP");

        public VelibClientForm()
        {
            InitializeComponent();
            SearchValidateButton.Enabled = false;
            ButtonSidePanel.Height = StationsButton.Height;
            ButtonSidePanel.Top = StationsButton.Top;
        }

        // Stations button

        private void Stations_Click(object sender, EventArgs e)
        {
            ButtonSidePanel.Height = StationsButton.Height;
            ButtonSidePanel.Top = StationsButton.Top;
            CityTextBox.Enabled = true;
            StationTextBox.Enabled = false;
            focus = 0;
            CheckSearchActivateButtonState();
        }

        // Bikes button

        private void Bikes_Click(object sender, EventArgs e)
        {
            ButtonSidePanel.Height = BikesButton.Height;
            ButtonSidePanel.Top = BikesButton.Top;
            CityTextBox.Enabled = false;
            StationTextBox.Enabled = true;
            focus = 1;
            CheckSearchActivateButtonState();
        }

        // City text box

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CityTextBox.Text.Length > 0)
            {
                cityTextBoxReady = true;
            }
            else
            {
                cityTextBoxReady = false;
            }
            CheckSearchActivateButtonState();
        }

        // Station text box

        private void StationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StationTextBox.Text.Length > 0)
            {
                stationTextBoxReady = true;
            }
            else
            {
                stationTextBoxReady = false;
            }
            CheckSearchActivateButtonState();
        }

        // Search validate button

        private void SearchValidateButton_Click(object sender, EventArgs e)
        {
            switch (focus)
            {
                case 0:
                    Results.Text = client.GetStationsInCity(CityTextBox.Text).Replace("\n", Environment.NewLine);
                    break;
                case 1:
                    Results.Text = client.GetAvailableVelibsInStation(StationTextBox.Text).Replace("\n", Environment.NewLine); ;
                    break;
            }
        }

        // JCDecaux panel

        private void JCDecaux_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("http://www.jcdecaux.fr/");
            Process.Start(startInfo);
        }

        private void CheckSearchActivateButtonState()
        {
            switch (focus)
            {
                case 0:
                    if (cityTextBoxReady)
                    {
                        SearchValidateButton.Enabled = true;
                    }
                    else
                    {
                        SearchValidateButton.Enabled = false;
                    }
                    break;
                case 1:
                    if (stationTextBoxReady)
                    {
                        SearchValidateButton.Enabled = true;
                    }
                    else
                    {
                        SearchValidateButton.Enabled = false;
                    }
                    break;
            }
        }

    }
}