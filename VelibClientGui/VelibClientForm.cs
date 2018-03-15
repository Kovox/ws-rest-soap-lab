using System;
using System.Linq;
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
            bbToolTip.SetToolTip(BikesButton, "Request the number of the available Velib at a given station");
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
            ResultBox.Items.Clear();
            lastCity = CityTextBox.Text;
            switch (focus)
            {
                case 0:
                    Station[] stations = client.GetStationsInCity(CityTextBox.Text);
                    if (stations.Length != 0)
                    {
                        for (int i = 0; i < stations.Length; i++)
                        {
                            ResultBox.Items.Add(i + " - " + stations[i].name);
                        }
                    }
                    else
                    {
                        ResultBox.Items.Add("The city " + CityTextBox.Text + " doesn't exist.");
                    }
                    break;
                case 1:
                    lastStation = StationTextBox.Text;
                    Station station = client.GetAvailableVelibsInStation(CityTextBox.Text, StationTextBox.Text);
                    if (station.name != null)
                    {
                        ResultBox.Items.Add(station.bike_stands +
                        " bikes available at " + station.name + " station.");
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
            switch (focus)
            {
                case 0:
                    List<Station> stations = client.GetStationsInCity(lastCity).ToList();
                    foreach (Station station in stations)
                    {
                        if (ResultBox.Items[ResultBox.SelectedIndex].ToString().Contains(station.name))
                        {
                            new Popup(station).Show();
                        }
                    }
                    break;
                case 1:
                    Station s = client.GetAvailableVelibsInStation(lastCity, lastStation);
                    if (s.name != null)
                    {
                        new Popup(s).Show();
                    }
                    break;
            }
        }
    }
}