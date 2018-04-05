using System;
using System.ServiceModel;

namespace EventsLib
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class CalcService : ICalcService
    {
        public static int sharedValue = 0;

        static Action<int, double, double, double> m_Event1 = delegate { };
        static Action m_Event2 = delegate { };
        static Action<int> m_Event3 = delegate { };

        public void SubscribeCalculatedEvent()
        {
            ICalcServiceEvents subscriber =
            OperationContext.Current.GetCallbackChannel<ICalcServiceEvents>();
            m_Event1 += subscriber.Calculated;
        }

        public void SubscribeCalculationFinishedEvent()
        {
            ICalcServiceEvents subscriber =
            OperationContext.Current.GetCallbackChannel<ICalcServiceEvents>();
            m_Event2 += subscriber.CalculationFinished;
        }

        public void SubscribeSharedValueModifiedEvent()
        {
            ICalcServiceEvents subscriber = 
            OperationContext.Current.GetCallbackChannel<ICalcServiceEvents>();
            m_Event3 += subscriber.SharedValueModified;
        }

        public void Calculate(int nOp, double dblX, double dblY)
        {
            double dblResult = 0;
            switch (nOp)
            {
                case 0: dblResult = dblX + dblY; break;
                case 1: dblResult = dblX - dblY; break;
                case 2: dblResult = dblX * dblY; break;
                case 3: dblResult = (dblY == 0) ? 0 : dblX / dblY; break;
            }

            m_Event1(nOp, dblX, dblY, dblResult);
            m_Event2();
        }

        public void ModifySharedValue(int modifier)
        {
            sharedValue = modifier;
            m_Event3(modifier);
        }
    }
}
