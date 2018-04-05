using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace VelibLibrary
{
    [ServiceContract(CallbackContract = typeof(IVelibServicesEvents))]
    public interface IVelibServices
    {
        [OperationContract]
        Task<List<Station>> GetStationsInCity(String city);

        [OperationContract]
        Task<Station> GetAvailableVelibsInStation(String city, String station);

        [OperationContract]
        Task<Station> StationSubEvent(int time, string city, string station);

        [OperationContract]
        void SubscribeToStationEvent();

        [OperationContract]
        void UnsubscribeToStationEvent();
    }
}