using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace formMessenger1
{
    internal class Communication
    {
        private const int port = 8888;
        public static bool isRunning = true;
        private static TcpListener listener;

        public static string StartListening()
        {
            string receiveMessege = null;
            try
            {
                IPAddress localAddr = IPAddress.Parse("0.0.0.0"); // Listen on all network interfaces
                listener = new TcpListener(localAddr, port);
                listener.Start();
                Console.WriteLine("Listening for incoming connections...");

                Thread acceptThread = new Thread(() => receiveMessege = AcceptConnections());
                acceptThread.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            return receiveMessege;
        }

        public static string AcceptConnections()
        {
            string ReceivedMessage = null;
            try
            {
                while (isRunning)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("Connected to peer: " + ((IPEndPoint)client.Client.RemoteEndPoint).Address);

                    //Thread receiveThread = new Thread(() => HandleClient(client));
                    Thread receiveThread = new Thread(() => ReceivedMessage = HandleClient(client));
                    receiveThread.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            return ReceivedMessage;
        }

        public static void SendMessage(string message, string IP)
        {
            try
            {
                string peerIP = IP;

                TcpClient client = new TcpClient();
                client.Connect(peerIP, port);
                NetworkStream stream = client.GetStream();

                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Sent: " + message);

                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static string HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            try
            {
                while (isRunning)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        Console.WriteLine("Received from peer: " + receivedMessage);
                        return receivedMessage;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                stream.Close();
                client.Close();
            }

            return null;
        }
    }
}
