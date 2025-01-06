using AutoMapper;
using WeatherAPI.Dto;
using WeatherAPI.Models;

namespace WeatherAPI.Profiles
{
    public class WeatherApiProfile: Profile
    {
        public WeatherApiProfile()
        {
            CreateMap<UserRequestDto, User>();
            CreateMap<LocationRequestDto, Location>();
        }
    }
}