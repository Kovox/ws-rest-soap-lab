using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using VelibClientGui.VelibServices;
using VelibLibrary;

namespace VelibClientGui
{
    public partial class VelibClientForm : Form
    {
        /// <summary>
        /// 0 = StationsButton
        /// 1 = BikesButton
        /// </summary>
        private Int16 focus = 0;

        private Boolean error = false;

        private Boolean cityTextBoxReady = false;
        private Boolean stationTextBoxReady = false;

        private static String lastCity = "";
        private static String lastStation = "";

        private static VelibServicesClient client = new VelibServicesClient("WSHTTP");

        public VelibClientForm()
        {
            InitializeComponent();
            SearchValidateButton.Enabled = false;
            StationTextBox.Enabled = false;
            ButtonSidePanel.Height = StationsButton.Height;
            ButtonSidePanel.Top = StationsButton.Top;
            ChangeUsageLabel();
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
            ChangeUsageLabel();
        }

        private void StationsButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip sbToolTip = new ToolTip();
            sbToolTip.SetToolTip(StationsButton, "Request for the list of velib stations for a given city");
        }

        // Bikes button

        private void Bikes_Click(object sender, EventArgs e)
        {
            ButtonSidePanel.Height = BikesButton.Height;
            ButtonSidePanel.Top = BikesButton.Top;
            CityTextBox.Enabled = true;
            StationTextBox.Enabled = true;
            focus = 1;
            CheckSearchActivateButtonState();
            ChangeUsageLabel();
        }

        private void BikesButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip bbToolTip = new ToolTip();
            bbToolTip.SetToolTip(BikesButton, "Request the number of the available Velib at a given station in a given city");
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

        private async void SearchValidateButton_Click(object sender, EventArgs e)
        {
            error = true;
            ResultBox.DataSource = null;
            lastCity = CityTextBox.Text;
            switch (focus)
            {
                case 0:
                    Station[] stations = await client.GetStationsInCityAsync(CityTextBox.Text);
                    if (stations.Length != 0)
                    {
                        ResultBox.SelectedIndexChanged -= ResultBox_SelectedIndexChanged;
                        ResultBox.DataSource = stations;
                        ResultBox.DisplayMember = "name";
                        ResultBox.SelectedIndex = -1; 
                        ResultBox.SelectedIndexChanged += ResultBox_SelectedIndexChanged;
                        error = false;
                    }
                    else
                    {
                        ResultBox.Items.Add("The city " + CityTextBox.Text + " doesn't exist.");
                    }
                    break;
                case 1:
                    lastStation = StationTextBox.Text;
                    Station station = await client.GetAvailableVelibsInStationAsync(CityTextBox.Text, StationTextBox.Text);
                    if (station != null && station.name != null)
                    {
                        List<Station> s = new List<Station>() { station };
                        ResultBox.SelectedIndexChanged -= ResultBox_SelectedIndexChanged;
                        ResultBox.DataSource = s;
                        ResultBox.DisplayMember = "BikesAvailable";
                        ResultBox.SelectedIndex = -1;
                        ResultBox.SelectedIndexChanged += ResultBox_SelectedIndexChanged;
                        error = false;
                    }
                    else
                    {
                        ResultBox.Items.Add("The station " + StationTextBox.Text + " or the city " +
                            CityTextBox.Text + " doesn't exist.");
                    }
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
                    if (cityTextBoxReady && stationTextBoxReady)
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

        private void ChangeUsageLabel()
        {
            switch (focus)
            {
                case 0:
                    Usage.Text = "U s a g e: Request for the list of velib stations for a given city. Does support city name with spaces";
                    break;
                case 1:
                    Usage.Text = "U s a g e: Request the number of the available Velib at a given station in a city. Does support station name with spaces";
                    break;
            }
        }

        private void ResultBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!error)
            {
                new Popup((Station)ResultBox.SelectedItem).Show();
            }
        }
    }
}