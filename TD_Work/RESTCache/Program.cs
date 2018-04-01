using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTCache
{
    public class WebRequestGetExample
    {
        public static void Main()
        {
            JCDecauxRequestHandler requestHandler = new JCDecauxRequestHandler();

            // User input at initialization
            String userInput = Welcome();
            String[] args = userInput.Split(' ');

            while (!args[0].ToUpper().Equals("/EXIT"))
            {
                switch (args[0].ToUpper())
                {
                    case "/SEARCH":
                        if (args.Length != 3)
                        {
                            Console.WriteLine("\nBad argument exception: you must only specify both the name of the city and the name of the station\n");
                        }
                        else
                        {
                            Console.WriteLine(requestHandler.RequestSearch(args[1], args[2]));
                        }
                        break;
                    case "/AVAILABLE_CITIES":
                        Console.WriteLine(requestHandler.RequestContracts());
                        break;
                    case "/CITY_STATIONS":
                        if (args.Length != 2)
                        {
                            Console.WriteLine("\nBad argument exception: you must only specify the name of the city\n");
                        }
                        else
                        {
                            Console.WriteLine(requestHandler.RequestStations(args[1]));
                        }
                        break;
                    default:
                        Console.WriteLine("\nCommand unrecognized...\n");
                        break;
                }
                userInput = Welcome();
                args = userInput.Split(' ');
            }
        }

        private static string Welcome()
        {
            Console.Write(
                "Available user commands:\n" +
                "/search <city_name> <station_name>\t- Displays station data given a city name and the station's name\n" +
                "/available_cities\t\t\t- Displays all availables cities (contracts)\n" +
                "/city_stations <city_name>\t\t- Displays every stations given a city name\n" +
                "/exit\t\t\t\t\t- Close application\n\n>>> ");
            return Console.ReadLine();
        }
    }
}
