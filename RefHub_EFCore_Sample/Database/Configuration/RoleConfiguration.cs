using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class RoleConfiguration: IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(a => new { a.RoleId, });

            builder.HasMany(a => a.UserToRole)
                .WithOne(a => a.Role)
                .HasForeignKey(a => a.RoleId);

            builder.HasData(new List<Role>()
            {
                new Role() { RoleId = 1, Name = "ADMIN" },
                new Role() { RoleId = 2, Name = "USER" }
            });
        }
    }
}
