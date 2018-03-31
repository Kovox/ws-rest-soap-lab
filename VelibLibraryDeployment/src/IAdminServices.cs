using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace VelibLibrary
{
    [ServiceContract]
    public interface IAdminServices
    {
        [OperationContract]
        int RetrieveTotalConnections();
    }
}