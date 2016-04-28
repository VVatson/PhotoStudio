namespace YouPhotoServerApp.Service
{
    internal interface IService
    {
        void Start();
        void ProcessConnection(object handler);
    }
}
