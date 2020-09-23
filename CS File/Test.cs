using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cshape_Socket
{
    class Test
    {
        static void Main(string[] args)
        {
            BlockingSocket blockingSocket = new BlockingSocket("localhost",5555);
            blockingSocket.Sendmessage("Hello Java Server I'm C# Client");
            Thread.Sleep(5000);
            blockingSocket.Close();
        }
    }
}
