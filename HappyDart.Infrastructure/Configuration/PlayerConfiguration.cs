using HappyDart.Domain.Aggregates.Players;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HappyDart.Infrastructure.Configuration
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Players");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name);
            builder.HasOne(p => p.User).WithMany().HasForeignKey(u => u.UserId);

        }
    }
}