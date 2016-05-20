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
            return Model.Autorize(login, password);
        }

        public void Register(string login, string password, UserType userType)
        {
            Model.Register(login, password, userType);
        }

        public void LogOut()
        {
            
        }
    }
}
