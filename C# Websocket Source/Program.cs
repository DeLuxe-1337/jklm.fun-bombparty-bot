using System;
using System.Net;

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
                string nope = Console.ReadLine();
                API.Find(nope.ToUpper());
            }
        }
    }
}
