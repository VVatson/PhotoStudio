namespace YouPhotoClientApp.Connection
{
    internal interface IConnector
    {
        void ConnectToServer();
        void CloseConnection();
        string RequestToServer(string request);
    }
}
