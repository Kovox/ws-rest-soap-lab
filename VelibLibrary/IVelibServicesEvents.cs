using System.ServiceModel;

namespace VelibLibrary
{
    public interface IVelibServicesEvents
    {
        [OperationContract(IsOneWay = true)]
        void StationVelibInfo(Station station);
    }
}
