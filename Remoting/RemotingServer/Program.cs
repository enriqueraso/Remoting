using Remote.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemotingServer
{
    public static class Program
    {
        static void Main(string[] args)
        {
            TcpChannelServerService server = new TcpChannelServerService(8080, true);

            Console.ReadKey();
        }
    }
}
