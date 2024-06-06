using Assistant.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assistant.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.Property(e => e.Id).HasDefaultValueSql("gen_random_uuid()");

            entity.Property(e => e.Email).IsRequired();

            entity.Property(e => e.Password).IsRequired();

            entity.Property(e => e.Salt).IsRequired();

            entity.Property(e => e.FirstName).IsRequired();

            entity.Property(e => e.LastName).IsRequired();

            entity.Property(e => e.Login).IsRequired();

            entity.Property(e => e.ProfileImage);

            entity.Property(e => e.Right).IsRequired();
        }
    }
}
