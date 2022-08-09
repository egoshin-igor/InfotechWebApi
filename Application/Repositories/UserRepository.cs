using TestApp.Application.Models;

namespace TestApp.Application.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            user.DefineId( _users.Count + 1 );
            _users.Add(user);
        }

        public IReadOnlyList<User> GetAll()
        {
            return _users;
        }

        public User GetByUsername( string username )
        {
            return _users.FirstOrDefault(x => x.UserName == username);
        }

        public User GetByUserId(int userId)
        {
            return _users.FirstOrDefault(x => x.Id == userId);
        }

        public void DeleteByUser(User user)
        {
            _users.Remove(user);
        }
    }
}
