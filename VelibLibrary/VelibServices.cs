using System;
using System.Collections.Generic;

namespace VelibLibrary
{
    public class VelibServices : IVelibServices
    {
        private JCDecauxRequestHandler requestHandler = new JCDecauxRequestHandler();

        public List<Station> GetStationsInCity(String city)
        {
            List<Station> request = CacheExtension.Get<List<Station>>(city);
            if (request == null)
            {
                request = requestHandler.RequestStations(city);
                CacheExtension.Add(city, request);
            }
            return request;
        }

        public Station GetAvailableVelibsInStation(String city, String station)
        {
            Station request = CacheExtension.Get<Station>(city + station);
            if (request == null)
            {
                request = requestHandler.RequestAvailableVelibsInStation(city, station);
                CacheExtension.Add(city + station, request);
            }
            return request;
        }
    }
}