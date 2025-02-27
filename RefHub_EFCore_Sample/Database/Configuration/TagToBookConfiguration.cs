using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class TagToBookConfiguration: IEntityTypeConfiguration<TagToBook>
    {
        public void Configure(EntityTypeBuilder<TagToBook> builder)
        {
            builder.HasKey(a => new { a.TagId, a.BookId });
        }
    }
}
