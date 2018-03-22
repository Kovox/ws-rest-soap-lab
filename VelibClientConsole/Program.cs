using System;
using System.Collections.Generic;
using VelibClientConsole.VelibServices;
using VelibLibrary;

namespace VelibClientConsole
{
    public class Program
    {
        private static Boolean quit = false;

        private static String INVITE = "Velib";
        private static String HELP_SYMBOL = "?";
        private static VelibServicesClient client = new VelibServicesClient("WSHTTP");

        static void Main(string[] args)
        {
            Console.WriteLine("Interactive command line interface started. " + HELP_SYMBOL + " for help.\n");
            Boolean shouldContinue = true;

            while (shouldContinue)
            {
                Console.Write(INVITE + " > ");

                String userInput = Console.ReadLine();

                if (userInput.Equals(HELP_SYMBOL))
                {
                    Help();
                }
                else
                {
                    if (userInput.Equals(""))
                    {
                        shouldContinue = true;
                    }
                    else
                    {
                        String[] command = userInput.Split(' ');
                        String keyword = command[0];
                        List<String> rawArgs = new List<String>();

                        if (command.Length > 1)
                        {
                            for (int i = 1; i < command.Length; i++)
                            {
                                rawArgs.Add(command[i]);
                            }
                        }
                        ProcessCommand(keyword, rawArgs);
                        shouldContinue = !quit;
                    }
                }
            }
        }

        private static void Help()
        {
            Console.Write(
                "Available user commands:\n" +
                "  - quit: Exit Velib Application\n" +
                "  - stations: Request for the list of velib stations for a given city.\n    Does support city name with spaces (stations CITY)\n" +
                "  - available_bikes: Request the number of the available Velib at a given station in a city.\n    Does support station name with spaces (available_bikes CITY STATION)\n");
        }

        private static async void ProcessCommand(String keyword, List<String> rawArgs)
        {
            switch (keyword)
            {
                case "quit":
                    quit = true;
                    return;
                case "stations":
                    if (rawArgs.Count < 1)
                    {
                        Console.WriteLine("Illegal arguments for command " + keyword);
                    }
                    else if (rawArgs.Count >= 1)
                    {
                        String city = String.Join(" ", rawArgs.ToArray());
                        String resultCityStation = "List of all the available stations in " + city + ":\n";
                        Station[] stations = await client.GetStationsInCityAsync(city);

                        if (stations.Length != 0)
                        {
                            for (int i = 0; i < stations.Length; i++)
                            {
                                resultCityStation += (i + 1) + " - " + stations[i].name + "\n";
                            }
                            Console.WriteLine(resultCityStation);
                        }
                        else
                        {
                            Console.WriteLine("The city " + city + " doesn't exist.");
                        }
                        Console.Write(INVITE + " > ");
                    }
                    break;
                case "available_bikes":
                    if (rawArgs.Count < 2)
                    {
                        Console.WriteLine("Illegal arguments for command " + keyword);
                    }
                    else if (rawArgs.Count >= 2)
                    {
                        String city = rawArgs[0];
                        rawArgs.Remove(rawArgs[0]);
                        String station = String.Join(" ", rawArgs.ToArray());
                        Station s = await client.GetAvailableVelibsInStationAsync(city, station);

                        if (s.name != null)
                        {
                            Console.WriteLine(s.available_bikes + " bikes available at " + s.name + 
                                " station.");
                        }
                        else
                        {
                            Console.WriteLine("The station " + station + " or the city " + city +
                                " doesn't exist.");
                        }
                        Console.Write(INVITE + " > ");
                    }
                    break;
                default:
                    Console.WriteLine("Unknown command: " + keyword);
                    break;
            }
            quit = false;
        }
    }
}