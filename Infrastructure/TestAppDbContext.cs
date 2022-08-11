using Microsoft.EntityFrameworkCore;
using TestApp.Infrastructure.Configurations;

namespace TestApp.Infrastructure
{
    public class TestAppDbContext : DbContext
    {
        public TestAppDbContext( DbContextOptions options ) : base( options )
        {
        }

        protected override void OnModelCreating( ModelBuilder builder )
        {
            builder.ApplyConfiguration( new UserConfiguration() );
        }
    }
}
