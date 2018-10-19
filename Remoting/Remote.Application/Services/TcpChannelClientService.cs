using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;

namespace Remote.Application.Factories
{
    public class TcpChannelClientService
    {
        private int _port;

        public TcpChannelClientService(int port, bool ensureSecurity)
        {
            TcpClientChannel channel = new TcpClientChannel();
            ChannelServices.RegisterChannel(channel, ensureSecurity);

            _port = port;
        }

        public I GetAdapter<I>(string adapterName = null)
        {
            if (string.IsNullOrEmpty(adapterName) == false && adapterName.Trim().Length == 0)
            {
                adapterName = null;
            }

            Type type = typeof(I);
            adapterName = adapterName ?? type.Name.Substring(1);

            var adapter = Activator.GetObject(type, string.Format("tcp://localhost:{0}/{1}", _port, adapterName));
            return (I)adapter;
        }
    }
}
