using WeatherAPI.Models;

namespace WeatherAPI.Data.Locations
{
    public interface ILocationRepository
    {
        bool SaveChanges();
        IEnumerable<Location> GetLocations(int userId);
        void DeleteLocation(int id);
        void AddLocation(Location location);

    }
}