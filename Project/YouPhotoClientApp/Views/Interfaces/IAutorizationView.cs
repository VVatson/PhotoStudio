using YouPhotoClientApp.Structures;

namespace YouPhotoClientApp.Views.Interfaces
{
    internal interface IAutorizationView
    {
        bool Autorize(string login, string password);
        void Register(string login, string password, UserType userType);
        void LogOut();
    }
}
