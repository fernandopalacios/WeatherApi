using System.ComponentModel.DataAnnotations;

namespace WeatherAPI.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set;}
        [Required]
        public int CityId { get; set;}
        [Required]
        public int UserId { get; set;}
    }
}