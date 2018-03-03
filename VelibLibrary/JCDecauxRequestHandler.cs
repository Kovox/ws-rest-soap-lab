using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace VelibLibrary
{
    class JCDecauxRequestHandler
    {
        private HttpWebRequest request;
        private HttpWebResponse response;
        private Stream dataStream;
        private StreamReader reader;
        private JArray jsonArray;

        public String RequestStations(String city)
        {
            string resultCityStation = Request("https://api.jcdecaux.com/vls/v1/stations?contract=" + city.ToUpper() + "&apiKey=9894216d065ff63cb3e3bf5f4eaad9f6da88df50");
            if (!resultCityStation.Equals("error"))
            {
                jsonArray = JArray.Parse(resultCityStation);
                resultCityStation = "List of all the available stations in " + city + ":\n";
                int indexCityStations = 1;
                foreach (JObject item in jsonArray)
                {
                    resultCityStation += indexCityStations++ + " - " + (String)item.GetValue("name") + "\n";
                }
                Clear();
                return resultCityStation;
            }
            else
            {
                return "The city " + city + " doesn't exist.";
            }
        }

        public String RequestAvailableVelibsInStation(String station)
        {
            string resultStations = Request("https://api.jcdecaux.com/vls/v1/stations?apiKey=9894216d065ff63cb3e3bf5f4eaad9f6da88df50");
            Clear();
            Station result = new Station(station, resultStations);
            if (result.Exists)
            {
                return result.AvailableBikes + " bikes available at " + result.Name + " station.";
            }
            else
            {
                return "The station " + station + " doesn't exist.";
            }
        }

        private String Request(String url)
        {
            // Create a request for the URL.
            request = (HttpWebRequest)WebRequest.Create(url);

            // If required by the server, set the credentials.
            // request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            try
            {
                response = (HttpWebResponse)request.GetResponse();

            }
            catch (WebException)
            {
                return "error";
            }

            // Display the status and other stuff.
            //result = response.StatusDescription + "\n";
            //result += "Content type is " + response.ContentType + "\n";

            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            reader = new StreamReader(dataStream);

            return reader.ReadToEnd();
        }

        private void Clear()
        {
            // Clean up the streams and the response.
            reader.Close();
            response.Close();
        }

    }
}