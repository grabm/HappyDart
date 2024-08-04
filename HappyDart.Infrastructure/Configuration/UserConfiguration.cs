using HappyDart.Domain.Aggregates.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HappyDart.Infrastructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Email);
            builder.Property(u => u.Password);
            builder.Property(u => u.IsActive);
            builder.Property(u => u.ModifyOnUtc);
            builder.Property(u => u.CreatedDateUtc);
        }
    }
}