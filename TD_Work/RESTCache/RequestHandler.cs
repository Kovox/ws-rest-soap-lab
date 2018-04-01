using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace RESTCache
{
    class JCDecauxRequestHandler
    {
        private HttpWebRequest request;
        private HttpWebResponse response;
        private Stream dataStream;
        private StreamReader reader;
        private JArray jsonArray;

        public String RequestSearch(String city, String station)
        {
            string resultSearch = Request("https://api.jcdecaux.com/vls/v1/stations?contract=" +
                city.ToUpper() + "&apiKey=9894216d065ff63cb3e3bf5f4eaad9f6da88df50");
            if (!resultSearch.Equals("error"))
            {
                Clear();
                return new Station(station, resultSearch).ToString();
            }
            else
            {
                return "\nThe city " + city + " doesn't exist\n";
            }
        }

        public String RequestContracts()
        {
            String result = "\nList of all the available cities (contracts):\n";
            jsonArray = JArray.Parse(Request("https://api.jcdecaux.com/vls/v1/contracts?apiKey=9894216d065ff63cb3e3bf5f4eaad9f6da88df50"));
            int indexAvailableCities = 0;
            foreach (JObject item in jsonArray)
            {
                result += indexAvailableCities++ + " - " + (String)item.GetValue("name") + "\n";
            }
            Clear();
            return result;
        }

        public String RequestStations(String city)
        {
            string resultCityStation = Request("https://api.jcdecaux.com/vls/v1/stations?contract=" + city.ToUpper() + "&apiKey=9894216d065ff63cb3e3bf5f4eaad9f6da88df50");
            if (!resultCityStation.Equals("error"))
            {
                jsonArray = JArray.Parse(resultCityStation);
                resultCityStation = "\nList of all the available stations in " + city + ":\n";
                int indexCityStations = 0;
                foreach (JObject item in jsonArray)
                {
                    resultCityStation += indexCityStations++ + " - " + (String)item.GetValue("name") + "\n";
                }
                Clear();
                return resultCityStation;
            }
            else
            {
                return "\nThe city " + city + " doesn't exist\n";
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