using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace VelibLibrary
{
    [ServiceContract]
    public interface IVelibServices
    {
        [OperationContract]
        Task<List<Station>> GetStationsInCity(String city);

        [OperationContract]
        Task<Station> GetAvailableVelibsInStation(String city, String station);
    }
}