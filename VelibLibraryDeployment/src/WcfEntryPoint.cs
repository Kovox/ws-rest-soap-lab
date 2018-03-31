using System;
using System.Collections.Generic;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading.Tasks;

namespace VelibLibrary
{
    /*
    public partial class WcfEntryPoint
    {
        public static void Configure(ServiceConfiguration config)
        {
            ServiceEndpoint vse = new ServiceEndpoint(new ContractDescription("IVelibServices"), new WSHttpBinding(), new EndpointAddress("/WS/VelibServices"));
            ServiceEndpoint ase = new ServiceEndpoint(new ContractDescription("IAdminServices"), new WSHttpBinding(), new EndpointAddress("/WS/AdminServices"));
            config.AddServiceEndpoint(vse);
            config.AddServiceEndpoint(ase);

            config.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });
            config.Description.Behaviors.Add(new ServiceDebugBehavior { IncludeExceptionDetailInFaults = true });
        }
    }
    */

    public partial class VelibServices : IVelibServices
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

    public partial class AdminServices : IAdminServices
    {
        public int RetrieveTotalConnections()
        {
            return 1;
        }
    }
}