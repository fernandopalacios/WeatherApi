using WeatherAPI.Models;

namespace WeatherAPI.Data.Users
{
    public interface IUserRepository
    {
        bool SaveChanges();
        User GetUser(int id);
        User GetUser(string username);
        User GetUser(string username, int pin);
        void AddUser(User user);
    }
}