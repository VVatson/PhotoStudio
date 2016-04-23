using System.Collections.Generic;
using YouPhotoServerApp.Structures;

namespace YouPhotoServerApp.Model
{
    public class Model : IModel
    {
        private readonly Service.Service service;
        private List<User> users;

        public Model()
        {
            users = new List<User>();
            service = new Service.Service();
        }

        public void StartService()
        {
            service.Start();
        }
    }
}
