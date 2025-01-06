using Microsoft.EntityFrameworkCore;
using WeatherAPI.Models;

namespace WeatherAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext (DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}