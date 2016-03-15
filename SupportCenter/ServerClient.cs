using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace SupportCenter
{
    class ServerClient
    {
        public int port;
        public string ip;
        private TcpClient client;
        public string UserName { get; set; }
        public string Password { get; set; }

        public void Connect()
        {
            client = new TcpClient();
            ip = "127.0.0.1";
            port = 12345;
            client.Connect(ip, port);
        }
        public string getPayloadAnswer(string payload)
        {
            string answer;
            List<byte> payloadData = new List<byte>();
            payloadData.AddRange(BitConverter.GetBytes((short)0));
            payloadData.AddRange(MakeString(payload));
            try
            {
                client.GetStream().Write(payloadData.ToArray(), 0, payloadData.Count);
                client.GetStream().Read(new byte[2], 0, 2);
                answer = ReadString(client);
            }
            catch (IOException io)
            {
                //server connection gone
                return "server connection closed";
            }
            
            return answer;
        }
        private byte[] MakeInt(int i){
            return BitConverter.GetBytes(i);
        }
        private byte[] MakeString(string input)
        {
            List<byte> data = new List<byte>();
            data.AddRange(MakeInt(Encoding.ASCII.GetByteCount(input)));
            data.AddRange(Encoding.ASCII.GetBytes(input));
            return data.ToArray();
        }
        private int ReadInt(TcpClient client)
        {
            byte[] data = new byte[4];
            client.GetStream().Read(data, 0, 4);
            return BitConverter.ToInt32(data, 0);
        }
        private string ReadString(TcpClient client)
        {
            byte[] data = new byte[ReadInt(client)];
            client.GetStream().Read(data, 0, data.Length);
            return Encoding.ASCII.GetString(data);
        }
    }
}
