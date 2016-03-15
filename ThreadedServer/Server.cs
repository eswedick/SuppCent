using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ThreadedServer
{
    class Server
    {
        public int Port { get; set; }
        public TcpListener listener;
        private Thread listenerThread;
        // Thread signal.
        public static ManualResetEvent tcpClientConnected =
            new ManualResetEvent(false);

        public Server(int port)
        {
            this.Port = port;
        }

        public void Start()
        {
            listener = new TcpListener(new IPEndPoint(IPAddress.Any, Port));
            listener.Start();
            listenerThread = new Thread(new ThreadStart(Listener));
            listenerThread.Start();
        }

        public void Stop()
        {
            listener.Stop();
            listenerThread.Abort();
        }

        public void Listener()
        {
            while (true)
            {
                try
                {
                    tcpClientConnected.Reset();
                    listener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClientCallback), listener);
                    tcpClientConnected.WaitOne();
                }
                catch
                (Exception e)
                {
                    Console.WriteLine("Error in listener thread:");
                    Console.WriteLine(e.Message);
                }
                

            }
        }

        // Process the client connection.
        public static void DoAcceptTcpClientCallback(IAsyncResult ar)
        {
            // Get the listener that handles the client request.
            TcpListener listener = (TcpListener)ar.AsyncState;

            // End the operation
            TcpClient c = listener.EndAcceptTcpClient(ar);

            // Handle returned data
            HandleClient(c);
            
            // Process the connection here.
            Console.WriteLine("Client connected completed");

            // Signal the calling thread to continue.
            tcpClientConnected.Set();

        }

        public static void HandleClient(TcpClient c)
        {
            try
            {
                byte[] packetIDData = new byte[2];
                c.GetStream().Read(packetIDData, 0, 2);
                ushort packetID = BitConverter.ToUInt16(packetIDData, 0);
                Console.WriteLine("packet id: {0}", packetID);

                switch (packetID)
                {
                    case 0:
                        byte[] data = new byte[4];
                        c.GetStream().Read(data, 0, 4);
                        int length = BitConverter.ToInt32(data, 0);
                        data = new byte[length];
                        c.GetStream().Read(data, 0, length);
                        Console.WriteLine("received data: '{0}'", Encoding.ASCII.GetString(data));
                        List<byte> backData = new List<byte>();
                        backData.AddRange(BitConverter.GetBytes((short)0));
                        string response = "successfully received data";
                        backData.AddRange(BitConverter.GetBytes(Encoding.ASCII.GetByteCount(response)));
                        backData.AddRange(Encoding.ASCII.GetBytes(response));
                        c.GetStream().Write(backData.ToArray(), 0, backData.ToArray().Length);
                        break;
                }

                c.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in handling returned data:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
