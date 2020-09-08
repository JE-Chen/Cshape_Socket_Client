using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cshape_WebSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            String Client_Message = "Hello World";
            SendMessage(Client_Message);
        }

        private static void SendMessage(String Message)
        {
            TcpClient Client;

            try
            {
                Client = new TcpClient();
                Client.Connect("localhost",5555);
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return;
            }
            NetworkStream StreamToServer = Client.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes(Message);
            StreamToServer.Write(buffer, 0, buffer.Length);
            Client.Close();
        }
    }
}
