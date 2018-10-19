using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;

namespace Remote.Application.Services
{
    public sealed class TcpChannelClientService
    {
        private readonly TcpClientChannel _channel;

        public TcpChannelClientService(int port, bool ensureSecurity)
        {
            _channel = new TcpClientChannel();
            ChannelServices.RegisterChannel(_channel, ensureSecurity);

            this.Port = port;
        }

        public int Port
        {
            get; private set;
        }

        public I GetAdapter<I>(string adapterName = null)
        {
            if (string.IsNullOrEmpty(adapterName) == false && adapterName.Trim().Length == 0)
            {
                adapterName = null;
            }

            Type type = typeof(I);
            adapterName = adapterName ?? type.Name.Substring(1);
            
            var adapter = Activator.GetObject(type, string.Format("tcp://localhost:{0}/{1}", this.Port, adapterName));
            return (I)adapter;
        }
    }
}
