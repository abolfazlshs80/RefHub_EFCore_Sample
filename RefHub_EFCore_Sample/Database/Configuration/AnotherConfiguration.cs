using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class AnotherConfiguration: IEntityTypeConfiguration<Another>
    {
        public void Configure(EntityTypeBuilder<Another> builder)
        {
            builder.HasKey(a => new { a.AnotherId });

            builder.HasMany(a => a.BookToAnother)
                .WithOne(a => a.Another)
                .HasForeignKey(a => a.AnotherId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
