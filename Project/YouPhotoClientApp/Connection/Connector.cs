using System;
using System.Net;
using System.Net.Sockets;

namespace YouPhotoClientApp.Connection
{
    public class Connector : IConnector
    {
        private Socket _sender;
        private const int Port = 11000;

        public void ConnectToServer()
        {
            var ipHost = Dns.GetHostEntry("localhost");
            var ipAddr = ipHost.AddressList[0];
            var ipEndPoint = new IPEndPoint(ipAddr, Port);
            _sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            _sender.Connect(ipEndPoint);
        }

        public void RequestToServer()
        {
            throw new NotImplementedException();
        }

        public void CloseConnection()
        {
            _sender.Shutdown(SocketShutdown.Both);
            _sender.Close();
        }
    }
}
