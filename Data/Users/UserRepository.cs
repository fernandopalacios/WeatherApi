using WeatherAPI.Models;

namespace WeatherAPI.Data.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            var userExists = GetUser(user.Username);
            if (userExists == null)
                _context.Users.Add(user);        
        }

        public User GetUser(int id)
        {
            return _context.Users.FirstOrDefault(user => user.Id == id);
        }

        public User GetUser(string username)
        {
            return _context.Users.FirstOrDefault(user => user.Username == username);
        }

        public User GetUser(string username, int pin)
        {
            return _context.Users.FirstOrDefault(user => user.Username == username && user.PIN == pin);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}