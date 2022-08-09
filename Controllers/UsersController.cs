using Microsoft.AspNetCore.Mvc;
using TestApp.Application.Models;
using TestApp.Application.Repositories;
using TestApp.Application.Services;
using TestApp.Application.Services.Models;
using TestApp.Dtos;

namespace TestApp.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserService _userService;

        public UsersController(IUserRepository userRepository, IUserService userService)
        {
            _userRepository = userRepository;
            _userService = userService;
        }

        [HttpGet]
        public List<UserDto> GetAll()
        {
            IReadOnlyList<User> users = _userRepository.GetAll();

            var result = new List<UserDto>();
            foreach (User user in users)
            {
                result.Add(new UserDto(user.Id, user.FirstName, user.LastName));
            }

            return result;
        }

        [HttpPost]
        public void AddUser(AddUserDto addUserDto)
        {
            _userService.AddUser(new AddUser(
                addUserDto.UserName,
                addUserDto.FirstName,
                addUserDto.LastName,
                addUserDto.Password
            ));
        }

        [HttpPost("{id}/delete")]

        public void DeleteUser([FromRoute] int id)
        {
            _userService.DeleteUser(id);
        }
        /*
        public List<UserDto> GetAll()
        {
            // LINQ
            return _userRepository
                .GetAll()
                .Select( user => 
                    new UserDto( user.Id, user.FirstName, user.LastName ) 
                ).ToList();
        }
        */
    }
}
