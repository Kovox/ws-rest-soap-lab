using System;
using Newtonsoft.Json.Linq;

namespace VelibLibrary
{
    public class Station
    {
        private Boolean exists = false;

        private String station;
        private Int64 number;
        private String name;
        private String address;
        private Double lat;
        private Double lng;
        private Boolean banking;
        private Boolean bonus;
        private String status;
        private String contractName;
        private Int16 bikeStands;
        private Int16 availableBikeStands;
        private Int16 availableBikes;
        private Int64 lastUpdate;

        private JObject jsonObject;
        private JArray jsonArray;

        public Station(String station, String result)
        {
            this.station = station;

            jsonArray = JArray.Parse(result);

            foreach (JObject item in jsonArray)
            {
                if (((String)item.GetValue("name")).ToUpper().Contains(station.ToUpper()))
                {
                    exists = true;

                    number = (Int64)item.GetValue("number");
                    name = (String)item.GetValue("name");
                    address = (String)item.GetValue("address");

                    jsonObject = (JObject)item.GetValue("position");
                    lat = (Double)jsonObject.GetValue("lat");
                    lng = (Double)jsonObject.GetValue("lng");

                    banking = (Boolean)item.GetValue("banking");
                    bonus = (Boolean)item.GetValue("bonus");
                    status = (String)item.GetValue("status");
                    contractName = (String)item.GetValue("contract_name");
                    bikeStands = (Int16)item.GetValue("bike_stands");
                    availableBikeStands = (Int16)item.GetValue("available_bike_stands");
                    availableBikes = (Int16)item.GetValue("available_bikes");
                    lastUpdate = (Int64)item.GetValue("last_update");
                }
            }
        }

        private static String BoolToString(Boolean value)
        {
            if (value.Equals("true"))
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }


        public override String ToString()
        {
            if (exists)
            {
                String station =
                "Info on station " + this.station + ":\n" +
                        "Number: " + number + "\n" +
                        "Name: " + name + "\n" +
                        "Address: " + address + "\n" +
                        "Position : " + "Latitude = " + lat + "; Longitude = " + lng + "\n" +
                        "Banking: " + BoolToString(banking) + "\n" +
                        "Bonus: " + BoolToString(bonus) + "\n" +
                        "Status: " + status + "\n" +
                        "Contract name: " + contractName + "\n" +
                        "Bike stands: " + bikeStands + "\n" +
                        "Available bike stands: " + availableBikeStands + "\n" +
                        "Available bikes: " + availableBikes + "\n" +
                        "Last update: " + lastUpdate;
                return station;
            }
            else
            {
                return "The station " + station + " doesn't exist.";
            }
        }

        public Boolean Exists
        {
            get { return exists; }
        }

        public String Name
        {
            get { return name; }
        }

        public Int16 AvailableBikes
        {
            get { return availableBikes; }
        }
    }
}