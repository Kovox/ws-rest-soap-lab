using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.ServiceReferenceGlobalWeather;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Starting call to service");



            // make a call to a web service using an async method

            GetGlobalWeather("Edinburgh", "United Kingdom");



            // print out a line to show we are not waiting for the service call to complete 

            // but rather and pressing on with this main thread

            Console.WriteLine("Call in progress...");



            // wait for the user to finish reading the report

            Console.ReadLine();

        }


        // because of Async call to web methods, GetGlobalWeather must be async 
        static async void GetGlobalWeather(string city, string country)

        {


            {

                try

                {

                    // create an instance of the client

                    GlobalWeatherSoapClient client = new GlobalWeatherSoapClient("GlobalWeatherSoap12");




                    // set a string to the results of the weather query - use await to hold here for the results to

                    // be returned to the string variable

                    string weather = await client.GetWeatherAsync(city, country);



                    // once the string is populated, write it out to the console

                    Console.WriteLine(weather);



                    // report completion from the async method

                    Console.WriteLine("Service call complete");

                }

                catch (Exception ex)

                {

                    // handle any errors here else risk an unhandled exception

                    Console.WriteLine("Error:  " + ex.Message);

                }

                finally

                {

                    // tell the user to click a key to close the console window

                    Console.WriteLine("Press any key to close this window");

                }

            }
        }
    }
}
            /*
            if (result)

            {

                resultCityState.Text = String.Format("{0}, {1}", result.City, result.State);

                resultDetails.Text = String.Format

                    ("\n\nConditions - {0} \n\nTemperature - {1} \n\nRelative Humidity - {2} \n\nWind - {3} \n\nPressure - {4} - 
                     \n\nPressure - { 5}
                - \n\nWind Chill - { 6}
                - \n\nVisibility - { 7}
                ",

                    result.Description, result.Temperature, result.RelativeHumidity, result.Wind, result.Pressure, fr.WeatherStationCity, result.WindChill, result.Visibility);

            }

            GetWeatherInformationResponse result1 = await proxy.GetWeatherInformationAsync();

            WeatherDescription[] r = result1.GetWeatherInformationResult;

            foreach (WeatherDescription d in r)

                if (d.WeatherID == result.WeatherID)

                {

                    image i = new image();

                    i.imageurl = d.PictureURL;

                    myimage.DataContext = i;

                    break;

                }

        }
    }*/
        
