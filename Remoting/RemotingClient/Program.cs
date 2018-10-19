using Remote.Application.Factories;
using Remote.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemotingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannelClientService client = new TcpChannelClientService(8080, true);

            var adapter = client.GetAdapter<IClass1Adapter>();

            var result = adapter.Sum(5, 2);
            Console.WriteLine(result);

            var result2 = adapter.Sum2(5, 3);
            Console.WriteLine("{0} {1}", result2.Id, result2.Result);

            var result3 = adapter.CreateClass2();
            result3.Result = 1;

            result2 = adapter.Sum3(result3, 4);
            Console.WriteLine("{0} {1}", result2.Id, result2.Result);

            Console.ReadKey();
        }
    }
}
