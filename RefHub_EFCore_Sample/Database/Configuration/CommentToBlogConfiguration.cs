using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class CommentToBlogConfiguration: IEntityTypeConfiguration<CommentToBlog>
    {
        public void Configure(EntityTypeBuilder<CommentToBlog> builder)
        {
            builder.HasKey(a => new { a.CommentId, });
        }
    }
}
