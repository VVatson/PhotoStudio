using System;
using YouPhotoClientApp.Controllers.Interfaces;
using YouPhotoClientApp.Model;
using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Controllers
{
    internal class AuthorizationController : IAuthorizationController
    {
        IModel Model;

        public AuthorizationController(IModel model)
        {
            Model = model;
        }

        public bool Autorize(string login, string password)
        {
            throw new NotImplementedException();
        }

        public void Register(string login, string password, UserType userType)
        {
            throw new NotImplementedException();
        }
    }
}
