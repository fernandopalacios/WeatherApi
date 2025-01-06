using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Data.Locations;
using WeatherAPI.Dto;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationRepository _repository;
        private readonly IMapper _mapper;

        public LocationsController(ILocationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("{userId}")]
        public ActionResult<IEnumerable<Location>> GetUserLocations(int userId)
        {
            var locations = _repository.GetLocations(userId);
            return Ok(locations);
        }

        [HttpPost]
        public ActionResult AddLocation(LocationRequestDto locationRequest)
        {
            var location = _mapper.Map<Location>(locationRequest);
            _repository.AddLocation(location);
            if (_repository.SaveChanges())
                return Ok();

            return BadRequest(location);
        }

        [HttpDelete("{locationId}")]
        public ActionResult DeleteLocation(int locationId)
        {
            _repository.DeleteLocation(locationId);
            if (_repository.SaveChanges())
                return Ok();

            return BadRequest();
        }
    }
}