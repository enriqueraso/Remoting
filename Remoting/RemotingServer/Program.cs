using Remote.Application.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemotingServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannelServerService server = new TcpChannelServerService(8080, true);

            Console.ReadKey();
        }
    }
}
