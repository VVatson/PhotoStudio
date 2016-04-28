namespace YouPhotoServerApp.Structures
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        // something else
        
        public User(string login, string password, UserType userType)
        {
            Login = login;
            Password = password;
            UserType = userType;
        }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
