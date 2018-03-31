using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VelibLibrary
{
    [DataContract]
    public class City
    {
        [DataMember]
        public String name { get; set; }

        [DataMember]
        public List<String> cities { get; set; }

        [DataMember]
        public String commercial_name { get; set; }

        [DataMember]
        public String country_code { get; set; }
    }

    [DataContract]
    public class Station
    {
        [DataMember]
        public int number { get; set; }

        [DataMember]
        public String contract_name { get; set; }

        [DataMember]
        public String name { get; set; }

        [DataMember]
        public String address { get; set; }

        [DataMember]
        public Position position { get; set; }

        [DataMember]
        public Boolean banking { get; set; }

        [DataMember]
        public Boolean bonus { get; set; }

        [DataMember]
        public String status { get; set; }

        [DataMember]
        public int bike_stands { get; set; }

        [DataMember]
        public int available_bike_stands { get; set; }

        [DataMember]
        public int available_bikes { get; set; }

        [DataMember]
        public String last_update { get; set; }

        public String BikesAvailable
        {
            get { return bike_stands + " bikes available at " + name + " station."; }
        }

        public override String ToString()
        {
            String station =
                        "Number: " + number + "\n" +
                        "Name: " + name + "\n" +
                        "Address: " + address + "\n" +
                        "Position : " + "Latitude = " + position.lat + "; Longitude = " +
                        position.lng + "\n" +
                        "Banking: " + banking + "\n" +
                        "Bonus: " + bonus + "\n" +
                        "Status: " + status + "\n" +
                        "Contract name: " + contract_name + "\n" +
                        "Bike stands: " + bike_stands + "\n" +
                        "Available bike stands: " + available_bike_stands + "\n" +
                        "Available bikes: " + available_bikes + "\n" +
                        "Last update: " + last_update;
            return station;
        }
    }

    [DataContract]
    public class Position
    {
        [DataMember]
        public Double lat { get; set; }

        [DataMember]
        public Double lng { get; set; }
    }
}