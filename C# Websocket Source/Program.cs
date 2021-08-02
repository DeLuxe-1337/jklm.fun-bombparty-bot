using System;

namespace WordFinderServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing phase");

            API.Find("AA"); //Just init the dictionary for faster use

            Websocket.Setup();

            while (true)
            {
                Console.ReadKey(); //Prevent console from closing/exiting
            }
        }
    }
}
