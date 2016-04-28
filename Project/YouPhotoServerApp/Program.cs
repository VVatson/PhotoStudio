namespace YouPhotoServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service.Service(new Model.Model());
            service.Start();
        }
    }
}
