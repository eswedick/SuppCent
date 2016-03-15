using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadedServer
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 12345;
            Server server = new Server(port);
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
