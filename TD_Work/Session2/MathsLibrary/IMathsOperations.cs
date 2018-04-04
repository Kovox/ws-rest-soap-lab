using System.Runtime.Serialization;
using System.ServiceModel;

namespace MathsLibrary
{
    [ServiceContract]
    public interface IMathsOperations
    {
        [OperationContract]
        int Add(int num1, int num2);

        [OperationContract]
        int Mult(int num1, int num2);

        [OperationContract]
        int Sub(int num1, int num2);

        [OperationContract]
        [FaultContract(typeof(CustomFaultDetails))]
        int Div(int num1, int num2);
    }

    [DataContract]
    public class CustomFaultDetails
    {
        private string errorId;
        private string errorDetails;

        [DataMember]
        public string ErrorID
        {
            get { return errorId; }
            set { errorId = value; }
        }

        [DataMember]
        public string ErrorDetails
        {
            get { return errorDetails; }
            set { errorDetails = value; }
        }
    }
}
