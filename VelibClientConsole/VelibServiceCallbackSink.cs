using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibLibrary;

namespace VelibClientConsole
{
    class VelibServiceCallbackSink : VelibServices.IVelibServicesCallback
    {
        public void StationVelibInfo(Station station)
        {
            if (station.name != null)
            {
                Console.WriteLine("Info for station: " + station.name + " updated...\nAvailable bikes: " + station.available_bikes);
            }
            else
            {
                Console.Write("The station doesn't exist\nVelib > ");
            }
        }
    }
}
