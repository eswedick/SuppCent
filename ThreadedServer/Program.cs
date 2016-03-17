using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ThreadedServer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 12345;

            Server server = new Server(ip, port);
            server.Start();
            Console.WriteLine("Started server on port: {0}", port);
            Console.WriteLine("press q to stop the server.");
            while (true)
            {
                ConsoleKeyInfo c = Console.ReadKey(true);
                if (c.Key == ConsoleKey.Q)
                {
                    Console.WriteLine("Closing server...");
                    server.Stop();
                    return;
                }
            }
        }
    }
}
