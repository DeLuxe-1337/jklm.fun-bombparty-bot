using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WordFinderServer
{
    public class Websocket
    {
        public static WebSocketServer Server = new WebSocketServer("ws://localhost");
        public class Main : WebSocketBehavior
        {
            protected override void OnOpen()
            {
                Console.WriteLine("A user has connected to the server!");
            }
            protected override void OnMessage(MessageEventArgs e)
            {
                var inp = API.Find(e.Data);
                if (inp == "NULL")
                    return;
                else
                    Send(inp);
            }
        }
        public static void Send(string message)
        {
            Server.WebSocketServices["/Word"].Sessions.Broadcast(message);
        }
        public static void Setup()
        {
            Server.AddWebSocketService<Main>("/Word");
            Server.Start();
        }
    }
}
