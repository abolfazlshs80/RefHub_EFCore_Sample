using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class TagToBlogConfiguration: IEntityTypeConfiguration<TagToBlog>
    {
        public void Configure(EntityTypeBuilder<TagToBlog> builder)
        {
            builder.HasKey(a => new { a.BlogId, a.TagId });
        }
    }
}
