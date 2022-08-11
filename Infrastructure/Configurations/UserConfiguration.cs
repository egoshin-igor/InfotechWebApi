using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestApp.Application.Models;

namespace TestApp.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure( EntityTypeBuilder<User> builder )
        {
            builder.HasKey( x => x.Id );

            builder.Property( x => x.UserName ).HasMaxLength( 100 );
            builder.Property( x => x.Password ).HasMaxLength( 100 );
            builder.Property( x => x.FirstName ).HasMaxLength( 100 );
            builder.Property( x => x.LastName ).HasMaxLength( 100 );
        }
    }
}
