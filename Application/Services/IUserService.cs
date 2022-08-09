using TestApp.Application.Services.Models;

namespace TestApp.Application.Services
{
    public interface IUserService
    {
        void AddUser(AddUser addUser);

        void DeleteUser(int id);
    }
}