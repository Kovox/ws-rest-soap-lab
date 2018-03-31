using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace VelibLibrary
{
    class JCDecauxRequestHandler
    {
        private HttpWebRequest request;
        private WebResponse response;
        private Stream dataStream;
        private StreamReader reader;

        public async Task<List<Station>> RequestStations(String city)
        {
            string resultCityStation = await Request("https://api.jcdecaux.com/vls/v1/stations?contract=" + city.ToUpper() + "&apiKey=9894216d065ff63cb3e3bf5f4eaad9f6da88df50");
            if (!resultCityStation.Equals("error"))
            {
                Clear();
                return JsonConvert.DeserializeObject<List<Station>>(resultCityStation); ;
            }
            else
            {
                return new List<Station>();
            }
        }

        public async Task<Station> RequestAvailableVelibsInStation(String city, String station)
        {
            string resultStations = await Request("https://api.jcdecaux.com/vls/v1/stations?contract=" +
                city.ToUpper() + "&apiKey=9894216d065ff63cb3e3bf5f4eaad9f6da88df50");
            Clear();
            if (!resultStations.Equals("error"))
            {
                List<Station> stations = JsonConvert.DeserializeObject<List<Station>>(resultStations);
                foreach (Station s in stations)
                {
                    if (s.name.ToUpper().Contains(station.ToUpper()))
                    {
                        return s;
                    }
                }
            }
            return new Station();
        }

        private async Task<String> Request(String url)
        {
            // Create a request for the URL.
            request = (HttpWebRequest)WebRequest.Create(url);

            // If required by the server, set the credentials.
            // request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            try
            {
                response = await request.GetResponseAsync();
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
            if (reader != null)
            {
                reader.Close();
            }
            if (response != null)
            {
                response.Close();
            }
        }
    }
}