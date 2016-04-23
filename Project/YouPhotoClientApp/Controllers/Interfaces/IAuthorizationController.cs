using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Controllers.Interfaces
{
    internal interface IAuthorizationController
    {
        bool Autorize(string login, string password);
        void Register(string login, string password, UserType userType);
    }
}
