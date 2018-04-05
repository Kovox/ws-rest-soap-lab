using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;

namespace VelibLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class VelibServices : IVelibServices
    {
        static Action<Station> stationEvent = delegate { };

        private JCDecauxRequestHandler requestHandler = new JCDecauxRequestHandler();

        public void SubscribeToStationEvent()
        {
            IVelibServicesEvents subscriber =
            OperationContext.Current.GetCallbackChannel<IVelibServicesEvents>();
            stationEvent += subscriber.StationVelibInfo;
        }

        public void UnsubscribeToStationEvent()
        {
            IVelibServicesEvents subscriber =
            OperationContext.Current.GetCallbackChannel<IVelibServicesEvents>();
            stationEvent -= subscriber.StationVelibInfo;
        }

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

        public async Task<Station> StationSubEvent(int time, string city, string station)
        {
            Station request = await requestHandler.RequestAvailableVelibsInStation(city, station);
            stationEvent(request);
            return request;
        }
    }
}