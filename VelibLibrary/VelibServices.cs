using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace VelibLibrary
{
    public class VelibServices : IVelibServices
    {
        private JCDecauxRequestHandler requestHandler = new JCDecauxRequestHandler();

        public async Task<List<Station>> GetStationsInCity(String city)
        {
            List<Station> request = CacheExtension.Get<List<Station>>(city);
            if (request == null)
            {
                request = await requestHandler.RequestStations(city);
                CacheExtension.Add(city, request);
            }
            return request;
        }

        public async Task<Station> GetAvailableVelibsInStation(String city, String station)
        {
            Station request = CacheExtension.Get<Station>(city + station);
            if (request == null)
            {
                request = await requestHandler.RequestAvailableVelibsInStation(city, station);
                CacheExtension.Add(city + station, request);
            }
            return request;
        }
    }
}