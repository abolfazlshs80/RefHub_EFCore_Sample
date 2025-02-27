using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class BlogConfiguration: IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasKey(a => new { a.BlogId, });


            builder.HasOne(a => a.Category)
                .WithMany(a => a.Blog)
                .HasForeignKey(a => a.CategoryId);


            builder.HasMany(a => a.FileToBlog)
                .WithOne(a => a.Blog)
                .HasForeignKey(a => a.BlogId);

            builder.HasMany(a => a.CommentToBlog)
                .WithOne(a => a.Blog)
                .HasForeignKey(a => a.BlogId);


            builder.HasOne(a => a.Language)
                .WithMany(a => a.Blog)
                .HasForeignKey(a => a.LanguageId);
        }
    }
}
