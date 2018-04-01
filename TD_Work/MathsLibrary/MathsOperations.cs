using System;
using System.ServiceModel;

namespace MathsLibrary
{
    public class MathsOperations : IMathsOperations
    {
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }

        public int Mult(int num1, int num2)
        {
            return (num1 * num2);
        }

        public int Sub(int num1, int num2)
        {
            return (num1 - num2);
        }

        // When a division by 0 occurs, the service stops...
        public int Div(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException)
            {
                CustomFaultDetails ex = new CustomFaultDetails
                {
                    ErrorID = "12345",
                    ErrorDetails = "Division by 0."
                };
                throw new FaultException<CustomFaultDetails>(ex);   
            }
        }
    }
}
