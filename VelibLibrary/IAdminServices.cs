using System.ServiceModel;

namespace VelibLibrary
{
    [ServiceContract]
    public interface IAdminServices
    {
        [OperationContract]
        int BasicOperation();
    }
}