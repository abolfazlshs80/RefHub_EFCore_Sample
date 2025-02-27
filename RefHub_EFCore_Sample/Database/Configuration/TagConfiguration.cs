using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class TagConfiguration: IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(a => new { a.TagId, });

            builder.HasMany(a => a.TagToBlog)
                .WithOne(a => a.Tag)
                .HasForeignKey(a => a.TagId)
                .OnDelete(DeleteBehavior.NoAction); ;

            builder.HasMany(a => a.TagToBook)
                .WithOne(a => a.Tag)
                .HasForeignKey(a => a.TagId).OnDelete(DeleteBehavior.NoAction); ;
        }
    }
}
