using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace asrTool
{
    class TcpTool
    {

        public static bool ConnectedAsrShare = false;
        public static bool ConnectedCLIENT = false;

        public static string ASSendSpef = "";

        public static int id = 0;

        public static bool StopAS = false;
        public static bool StopCL = false;

        public static string ipc = "";
        public static int portc = 0;

        public static string QuickSend(string ip, int port, string text)
        {
            string r = "timedout";
            TcpClient client = null;
            try
            {
                Debug.Write(text);
                client = new TcpClient(ip, port);
                NetworkStream stream = client.GetStream();

                stream.ReadTimeout = 500;
                byte[] configmsg = Encoding.Unicode.GetBytes(text);
                stream.Write(configmsg, 0, configmsg.Length);

                byte[] buffer = new byte[client.ReceiveBufferSize];
                int data = stream.Read(buffer, 0, client.ReceiveBufferSize);
                string received_ch = Encoding.Unicode.GetString(buffer, 0, data);

                client.Close();

                Debug.Write(received_ch);

                return received_ch;
            }
            catch (Exception ex) { Debug.Write(ex.ToString()); }
            return r;
        }

        public static void AsrShare()
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Loopback, 15440);
            TcpListener listen = new TcpListener(ep);

            TcpClient client;


            while (true)
            {
                if (StopAS) { StopAS = false; break; }
                listen.Start();
                client = listen.AcceptTcpClient();
                NetworkStream stream = client.GetStream();

                byte[] buffer = new byte[client.ReceiveBufferSize];
                stream.ReadTimeout = 10000;

                int data = stream.Read(buffer, 0, client.ReceiveBufferSize);
                string dataReceived = Encoding.Unicode.GetString(buffer, 0, data);

                if (dataReceived == "c:askconnect")
                {
                    client.Client.Send(Encoding.Unicode.GetBytes("c:acceptconnect"));
                    ConnectedAsrShare = true;
                }

                if (ConnectedAsrShare) { client.Client.Send(Encoding.Unicode.GetBytes("[0]AsrShareContact")); }

                Debug.Write(dataReceived.Substring(0, 7));
                dataReceived = "";

            }
        }


        public static void Client()
        {
            string r = "timedout";
            TcpClient client = null;
            Random gen = new Random();
            id = gen.Next(99999, 999999999);
            while (true)
            {
                try
                {

                    if (StopCL) { client.Close(); StopCL = false; break; }

                    client = new TcpClient(ipc, portc);
                    NetworkStream stream = client.GetStream();

                    stream.ReadTimeout = 500;
                    byte[] configmsg = Encoding.Unicode.GetBytes("[" + id + "]\nclient");
                    stream.Write(configmsg, 0, configmsg.Length);

                    byte[] buffer = new byte[client.ReceiveBufferSize];
                    int data = stream.Read(buffer, 0, client.ReceiveBufferSize);
                    string received_ch = Encoding.Unicode.GetString(buffer, 0, data);

                    Debug.Write(received_ch);

                    ConnectedCLIENT = true;
                }
                catch (Exception ex) { ConnectedCLIENT = false; Debug.Write(ex.ToString()); }
            }
            ConnectedCLIENT = false;
        }

    }
}
