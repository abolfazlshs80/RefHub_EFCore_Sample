using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class FileToBlogConfiguration: IEntityTypeConfiguration<FileToBlog>
    {
        public void Configure(EntityTypeBuilder<FileToBlog> builder)
        {
                    builder.HasKey(a => new { a.FileId,a.BlogId });
        }
    }
}
