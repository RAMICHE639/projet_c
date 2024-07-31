namespace SchoolManagement
{
    public class Admin
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Admin(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool Authenticate(string username, string password)
        {
            return Username == username && Password == password;
        }
    }
}
