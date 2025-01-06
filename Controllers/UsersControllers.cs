using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Data.Users;
using WeatherAPI.Dto;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsersController: ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost("login")]
        public ActionResult Login(UserRequestDto loginRequest)
        {
            var user = _repository.GetUser(loginRequest.Username, loginRequest.PIN);
            if (user != null)
            {
                return Ok(new
                {
                    Id = user.Id,
                    Username = user.Username
                });
            }
            return NotFound(loginRequest.Username);
        }

        [HttpPost("signup")]
        public ActionResult SignUp(UserRequestDto signupRequest)
        {
            var newUser = _mapper.Map<User>(signupRequest);
            _repository.AddUser(newUser);
            if (_repository.SaveChanges())
            {
                return Ok();
            }
            return BadRequest(signupRequest);
        }
    }
}