using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class FileToBookConfiguration: IEntityTypeConfiguration<FileToBook>
    {
        public void Configure(EntityTypeBuilder<FileToBook> builder)
        {
            builder.HasKey(a => new { a.BookId, a.FileId });
        }
    }
}
