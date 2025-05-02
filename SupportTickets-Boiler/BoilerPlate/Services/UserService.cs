using BoilerPlate.Models;

namespace BoilerPlate.Services
{
    public class UserService
    {
        private readonly List<User> _users = new();

        public bool Register(User u)
        {
            if (_users.Any(x => x.Username == u.Username)) return false;
            _users.Add(u); return true;
        }

        public User? Authenticate(string name, string pass) =>
            _users.FirstOrDefault(x => x.Username == name && x.Password == pass);
    }
}