using System.IO.Compression;
using WeatherAPI.Models;

namespace WeatherAPI.Data.Locations
{
    public class LocationRepository : ILocationRepository
    {
        private readonly AppDbContext _context;

        public LocationRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddLocation(Location location)
        {
            var locationExists = GetLocation(location);
            if (locationExists == null)
                _context.Locations.Add(location);
        }

        public void DeleteLocation(int id)
        {
            var location = GetLocation(id);
            if (location != null)
                _context.Locations.Remove(location);
        }

        public IEnumerable<Location> GetLocations(int userId)
        {
            return _context.Locations.Where(location => location.UserId == userId).ToList();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        private Location GetLocation(int id)
        {
            return _context.Locations.FirstOrDefault(location => location.Id == id);
        }

        private Location GetLocation(Location location)
        {
            return _context.Locations.FirstOrDefault(x => x.UserId == location.UserId && x.CityId == location.CityId);
        }
    }
}