using TestApp.Application.Models;
using TestApp.Application.Repositories;
using TestApp.Application.Services.Models;

namespace TestApp.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService( IUserRepository userRepository )
        {
            _userRepository = userRepository;
        }

        public void AddUser(AddUser addUser)
        {
            User existingUser = _userRepository.GetByUsername(addUser.UserName);
            if ( existingUser != null )
            {
                throw new Exception( $"User with username: {addUser.UserName} already exist!" );
            }

            var newUser = new User( addUser.UserName, addUser.FirstName, addUser.LastName, addUser.Password );
            _userRepository.AddUser( newUser );
        }

        public void DeleteUser(int id)
        {
            User existingUser = _userRepository.GetByUserId(id);
            if (existingUser == null)
            {
                throw new Exception($"User with user id: {id} not found!");
            }

            _userRepository.DeleteByUser(existingUser);
        }
    }
}
