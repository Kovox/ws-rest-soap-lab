using MathsLibraryClient.MathsOperations;
using System;

namespace MathsLibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MathsOperationsClient client = new MathsOperationsClient("WSHTTP");
            Console.WriteLine(client.Add(100, 101));
            Console.WriteLine(client.Mult(100, 101));
            Console.WriteLine(client.Sub(100, 50));
            Console.WriteLine(client.Div(100, 50));
            Console.ReadLine();
        }
    }
}
