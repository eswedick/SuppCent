using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace SupportCenter
{
    class ServerClient
    {
        public int port;
        public string ip;
        private TcpClient client;
        public string UserName { get; set; }
        public string Password { get; set; }

        private NetworkStream serverStream;
        string readData = null;

        public Button SendButton { set; get; }
        public TextBox Text { set; get; }

        public void Connect()
        {
            client = new TcpClient();
            ip = "127.0.0.1";
            port = 12345;
            client.Connect(ip, port);
            serverStream = client.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("Evan$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        public void Disconnect()
        {
            client.Close();
        }

        public bool IsConnected()
        {
            if (client == null)
            {
                return false;
            }
            else
            {
                return client.Connected;
            }
        }

        public void Send(TextBox text, Button send)
        {
            Thread ctThread;
            SendButton = send;
            Text = text;
            readData = "Conected to Chat Server ...";

            try
            {
                msg();

                if (!client.Connected)
                {
                    client.Connect(ip, port);
                }

                serverStream = client.GetStream();

                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(text.Text + "$");

                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                ctThread = new Thread(getMessage);
                ctThread.Start();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void getMessage()
        {
            while (true)
            {
                serverStream = client.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[10025];

                buffSize = client.ReceiveBufferSize;

                serverStream.Read(inStream, 0, buffSize);

                string returndata = System.Text.Encoding.ASCII.GetString(inStream);

                readData = "" + returndata;

                msg();
            }
        }

        private void msg()
        {
            if (SendButton.InvokeRequired)
                SendButton.Invoke(new MethodInvoker(msg));
            else
                Text.Text = Text.Text + Environment.NewLine + " >> " + readData;
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
        private byte[] MakeInt(int i)
        {
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
