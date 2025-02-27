using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class CommentToBookConfiguration: IEntityTypeConfiguration<CommentToBook>
    {
        public void Configure(EntityTypeBuilder<CommentToBook> builder)
        {
            builder.HasKey(a => new { a.CommentId, });
        }
    }
}
