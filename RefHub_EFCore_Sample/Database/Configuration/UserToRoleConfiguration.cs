using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class UserToRoleConfiguration: IEntityTypeConfiguration<UserToRole>
    {
        public void Configure(EntityTypeBuilder<UserToRole> builder)
        {
            builder.HasKey(a => new { a.RoleId, a.UserId });
            builder.HasData(new List<UserToRole>()
            {
                new UserToRole() { RoleId = 2, UserId = 1 },
                new UserToRole() { RoleId = 1, UserId = 2 },
            });
        }
    }
}
