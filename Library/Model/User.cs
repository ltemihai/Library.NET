namespace Library
{
    public class User
    {
        private string _username;
        private string _password;
        private string _userType;

        public User(string username, string password, string userType)
        {
            Username = username;
            Password = password;
            UserType = userType;
        }

        public User()
        {

        }

        public User(string username)
        {
            Username = username;
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string UserType
        {
            get { return _userType; }
            set { _userType = value; }
        }
    }
}
