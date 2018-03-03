using System;

namespace VelibLibrary
{
    public class VelibServices : IVelibServices
    {
        private JCDecauxRequestHandler requestHandler = new JCDecauxRequestHandler();

        public String GetStationsInCity(String city)
        {
            String request = CacheExtension.Get<String>(city);
            if (request == null)
            {
                request += requestHandler.RequestStations(city);
                CacheExtension.Add(city, request);
            }
            return request;
        }

        public String GetAvailableVelibsInStation(String station)
        {
            String request = CacheExtension.Get<String>(station);
            if (request == null)
            {
                request += requestHandler.RequestAvailableVelibsInStation(station);
                CacheExtension.Add(station, request);
            }
            return request;
        }
    }
}
