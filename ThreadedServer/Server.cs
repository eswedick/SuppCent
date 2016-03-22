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
        public IPAddress IP { get; set; }
        public int Port { get; set; }
        private bool isListening;
        public static Dictionary<string, TcpClient> clientsList;
        TcpListener serverSocket;
        TcpClient clientSocket;


        public Server(IPAddress ip, int port)
        {
            this.IP = ip;
            this.Port = port;
        }

        public void Start()
        {
            clientsList = new Dictionary<string, TcpClient>();
            serverSocket = new TcpListener(IP, Port);
            clientSocket = default(TcpClient);

            int counter = 0;
            isListening = true;

            serverSocket.Start();
            Console.WriteLine("Chat Server Started ....");

            while (isListening)
            {
                counter += 1;
                clientSocket = serverSocket.AcceptTcpClient();

                byte[] bytesFrom = new byte[10025];
                string dataFromClient = null;

                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);

                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                clientsList.Add(dataFromClient, clientSocket);

                broadcast(dataFromClient + " Joined ", dataFromClient, false);

                Console.WriteLine(dataFromClient + " Joined chat room ");

                ClientHandler client = new ClientHandler();
                client.startClient(clientSocket, dataFromClient, clientsList);

            }

            clientSocket.Close();
            serverSocket.Stop();

            Console.WriteLine("exit");
            Console.ReadLine();
        }

        public void Stop()
        {
            //stop listening
            isListening = false;

            //loop through client list closing
            foreach (TcpClient client in clientsList.Values){
                client.Close();
            }
        }

        public static  void broadcast(string msg, string uName, bool includeName)
        {
            foreach (string Item in clientsList.Keys)
            {
                TcpClient broadcastSocket;
                clientsList.TryGetValue(uName, out broadcastSocket);

                NetworkStream broadcastStream = broadcastSocket.GetStream();

                Byte[] broadcastBytes = null;

                if (includeName == true)
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(uName + " says : " + msg);
                }
                else
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(msg);
                }

                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                broadcastStream.Flush();
            }
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
