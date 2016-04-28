using System.Net;
using System.Net.Sockets;
using System.Text;

namespace YouPhotoClientApp.Connection
{
    public class Connector : IConnector
    {
        private Socket _sender;
        private const int Port = 11000;
        private const int RecieveBufferSize= 1024;

        public void ConnectToServer()
        {
            var ipHost = Dns.GetHostEntry("localhost");
            var ipAddr = ipHost.AddressList[0];
            var ipEndPoint = new IPEndPoint(ipAddr, Port);
            _sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            _sender.Connect(ipEndPoint);
        }

        public void CloseConnection()
        {
            _sender.Shutdown(SocketShutdown.Both);
            _sender.Close();
        }

        public string RequestToServer(string request)
        {
            var msg = Encoding.UTF8.GetBytes(request);
            _sender.Send(msg);

            var recieveBuffer = new byte[RecieveBufferSize];
            var bytesRecieved = _sender.Receive(recieveBuffer);
            return Encoding.UTF8.GetString(recieveBuffer, 0, bytesRecieved);
        }
    }
}
