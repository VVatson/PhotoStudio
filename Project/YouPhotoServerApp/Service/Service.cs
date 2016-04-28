using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace YouPhotoServerApp.Service
{
    public class Service : IService
    {
        private Socket _listener;
        private readonly Model.Model _model;
        private const int Port = 11000;
        private const int RecieveBufferSize = 1024;

        public Service(Model.Model model)
        {
            _model = model;
        }

        public void Start()
        {
            try
            {
                var ipHost = Dns.GetHostEntry("localhost");
                var ipAddr = ipHost.AddressList[0];
                var ipEndPoint = new IPEndPoint(ipAddr, Port);

                _listener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                _listener.Bind(ipEndPoint);
                _listener.Listen(10);
            }
            catch (Exception)
            {
                // ignored
            }

            while (true)
            {
                try
                {
                    var handler = _listener.Accept();
                    var thread = new Thread(ProcessConnection);
                    thread.Start(handler);
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        public void ProcessConnection(object handler)
        {
            var connection = (Socket) handler;
            while (true)
            {
                
                var recieveBuffer = new byte[RecieveBufferSize];
                var bytesRecieved = connection.Receive(recieveBuffer);

                var recievedData = Encoding.UTF8.GetString(recieveBuffer, 0, bytesRecieved);

                var answerToClient = _model.ProcessRequest(recievedData);
                var msg = Encoding.UTF8.GetBytes(answerToClient);
                
                connection.Send(msg);
            }
        }
    }
}
