using Microsoft.EntityFrameworkCore;
using TestApp.Application.Models;
using TestApp.Infrastructure;

namespace TestApp.Application.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TestAppDbContext _dbContext;
        private DbSet<User> _users => _dbContext.Set<User>();

        public UserRepository( TestAppDbContext dbContext )
        {
            _dbContext = dbContext;
        }

        public void AddUser( User user )
        {
            _users.Add( user );
            _dbContext.SaveChanges();
        }

        public void DeleteByUser( User user )
        {
            _dbContext.Remove( user );
            _dbContext.SaveChanges();
        }

        public IReadOnlyList<User> GetAll()
        {
            return _users.ToList();
        }

        public User GetByUserId( int userId )
        {
            return _users.FirstOrDefault( x => x.Id == userId );
        }

        public User GetByUsername( string username )
        {
            return _users.FirstOrDefault( x => x.UserName == username );
        }
    }
}
