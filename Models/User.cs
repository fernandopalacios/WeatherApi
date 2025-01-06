using System.ComponentModel.DataAnnotations;

namespace WeatherAPI.Models
{
    public class User
    {
        [Key]
        public int Id {get;set;}
        [Required]
        public string Username {get;set;}
        [Required]
        public int PIN {get;set;}
    }
}