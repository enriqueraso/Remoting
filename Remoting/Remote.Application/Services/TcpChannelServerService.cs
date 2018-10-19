using Remote.Application.Adapters;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;

namespace Remote.Application.Factories
{
    public class TcpChannelServerService
    {
        public TcpChannelServerService(int port, bool ensureSecurity)
        {
            TcpServerChannel channel = new TcpServerChannel(port);
            ChannelServices.RegisterChannel(channel, ensureSecurity);

            RegisterAdapters();
        }

        public void RegisterAdapters()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Class1Adapter), "Class1Adapter", WellKnownObjectMode.Singleton);
        }
    }
}
