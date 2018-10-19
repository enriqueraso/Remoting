using Remote.Application.Adapters;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;

namespace Remote.Application.Services
{
    public sealed class TcpChannelServerService
    {
        private readonly TcpServerChannel _channel = null;

        public TcpChannelServerService(int port, bool ensureSecurity)
        {
            _channel = new TcpServerChannel(port);
            ChannelServices.RegisterChannel(_channel, ensureSecurity);

            RegisterAdapters();
        }

        private static void RegisterAdapters()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Class1Adapter), "Class1Adapter", WellKnownObjectMode.Singleton);
        }
    }
}
