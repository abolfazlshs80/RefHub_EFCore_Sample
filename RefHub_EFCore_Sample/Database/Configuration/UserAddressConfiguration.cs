using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class UserAddressConfiguration: IEntityTypeConfiguration<UserAddress>
    {
        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.HasKey(a => new { a.UserAddressId, });

            //builder.HasOne(ua => ua.User)
            //    .WithMany(u => u.UserAddress)
            //    .HasForeignKey(ua => ua.UserId);
        }
    }
}
