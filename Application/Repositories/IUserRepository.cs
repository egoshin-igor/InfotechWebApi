using TestApp.Application.Models;

namespace TestApp.Application.Repositories
{
    public interface IUserRepository
    {
        IReadOnlyList<User> GetAll();
        User GetByUsername( string username );
        void AddUser( User user );

        User GetByUserId(int userId);

        void DeleteByUser(User user);
    }
}