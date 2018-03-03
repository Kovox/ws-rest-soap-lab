using System;
using System.Collections.Generic;
using VelibClientConsole.VelibServices;

namespace VelibClientConsole
{
    public class Program
    {
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
                        shouldContinue = ProcessCommand(keyword, rawArgs);
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
                "  - available_bikes: Request the number of the available Velib at a given station.\n    Does support station name with spaces (available_bikes STATION)\n");
        }

        private static Boolean ProcessCommand(String keyword, List<String> rawArgs)
        {
            switch (keyword)
            {
                case "quit":
                    return false;
                case "stations":
                    if (rawArgs.Count < 1)
                    {
                        Console.WriteLine("Illegal arguments for command " + keyword);
                    }
                    else if (rawArgs.Count == 1)
                    {
                        Console.WriteLine(client.GetStationsInCity(rawArgs[0]));
                    }
                    else
                    {
                        Console.WriteLine(client.GetStationsInCity(String.Join(" ", rawArgs.ToArray())));
                    }
                    break;
                case "available_bikes":
                    if (rawArgs.Count < 1)
                    {
                        Console.WriteLine("Illegal arguments for command " + keyword);
                    }
                    else if (rawArgs.Count == 1)
                    {
                        Console.WriteLine(client.GetAvailableVelibsInStation(rawArgs[0]));
                    }
                    else
                    {
                        Console.WriteLine(client.GetAvailableVelibsInStation(String.Join(" ", rawArgs.ToArray())));
                    }
                    break;
                default:
                    Console.WriteLine("Unknown command: " + keyword);
                    break;
            }
            return true;
        }
    }
}