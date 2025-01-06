using WeatherAPI.Models;

namespace WeatherAPI.Data
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }
        private static void SeedData(AppDbContext context)
        {
            if(!context.Users.Any())
            {
                context.Users.Add(new User {Id=1, Username = "lpalacios", PIN = 93024});
                context.Users.Add(new User {Id=2, Username = "jperez", PIN = 76253});
            }

            if(!context.Locations.Any())
            {
                context.Locations.Add(new Location { Id = 1, CityId = 3169692, UserId = 1 });
                context.Locations.Add(new Location { Id = 2, CityId = 3303287, UserId = 1 });
            }

            context.SaveChanges();
        }
    }
}