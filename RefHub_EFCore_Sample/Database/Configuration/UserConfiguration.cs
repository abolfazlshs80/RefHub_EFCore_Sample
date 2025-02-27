using ErrorOr;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Com;
using RefHub_EFCore_Sample.Database.Model;
using RefHub_EFCore_Sample.Database.ValueConvertor;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    
    public class UserConfiguration: IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(a => new { a.UserId, });

            builder.Property(a => a.Name).ValueGeneratedOnAddOrUpdate();
            builder.Property(p => p.Attributes)
                .HasConversion(
                    new DictionaryConverter(), // اعمال ValueConverter
                    new DictionaryComparer() // اعمال ValueComparer
                );

            builder.HasMany(a => a.UserToRole)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId);

            builder.HasMany(a => a.FileToUser)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(a => a.UserAddress)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId).OnDelete(DeleteBehavior.Restrict ); ;



            builder.HasMany(a => a.Order)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId);



            builder.Property(a => a.FullName).HasComputedColumnSql("[Family]+' '+ [Name]");

            builder.HasData(new List<User>()
            {
                new User(){UserId = 1,UserName = "User",Name = "User",Family = "_User",Email = "User@localhost.com",Password = "123"},
                new User(){UserId = 2,UserName = "Admin",Name = "Admin",Family = "_Admin",Email = "Admin@localhost.com",Password = "123"}
            });
        }
    }
}
