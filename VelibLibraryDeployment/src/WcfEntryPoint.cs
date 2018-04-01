using System;
using System.Collections.Generic;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading.Tasks;

namespace VelibLibrary
{
    public partial class WcfEntryPoint : IVelibServices
    {
        private JCDecauxRequestHandler requestHandler = new JCDecauxRequestHandler();

        public async Task<List<Station>> GetStationsInCity(String city)
        {
            Console.WriteLine("GetStationsInCity(" + city + ") request received...");
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
            Console.WriteLine("GetAvailableVelibsInStation(" + city + ", " + station + ") request received...");
            Station request = CacheExtension.Get<Station>(city + station);
            if (request == null)
            {
                request = await requestHandler.RequestAvailableVelibsInStation(city, station);
                CacheExtension.Add(city + station, request);
            }
            return request;
        }
    }

    public partial class WcfEntryPoint : IAdminServices
    {
        public int RetrieveTotalConnections()
        {
            return 1;
        }
    }
}