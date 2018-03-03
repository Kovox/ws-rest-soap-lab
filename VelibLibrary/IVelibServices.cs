using System;
using System.ServiceModel;

namespace VelibLibrary
{
    [ServiceContract]
    public interface IVelibServices
    {
        [OperationContract]
        String GetStationsInCity(String city);

        [OperationContract]
        String GetAvailableVelibsInStation(String station);
    }
}
