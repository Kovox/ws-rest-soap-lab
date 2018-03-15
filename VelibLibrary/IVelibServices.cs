using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace VelibLibrary
{
    [ServiceContract]
    public interface IVelibServices
    {
        [OperationContract]
        List<Station> GetStationsInCity(String city);

        [OperationContract]
        Station GetAvailableVelibsInStation(String city, String station);
    }
}
