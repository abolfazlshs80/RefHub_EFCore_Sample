using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class BookConfiguration: IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
                .Property<DateTime>("CreateDate")
                .HasDefaultValueSql("GETDATE()");

            builder
                .Property<DateTime>("UpdateDate")
                .HasDefaultValueSql("GETDATE()");
            builder.HasKey(a => new { a.BookId, });
            builder
            .Property(p => p.Price)
                .HasConversion(new MoneyConverter()); 
            builder.HasOne(a => a.Category)
                .WithMany(a => a.Book)
                .HasForeignKey(a => a.CategoryId);

            builder.HasOne(a => a.PersonLevel)
                .WithMany(a => a.Book)
                .HasForeignKey(a => a.PersonLevelId);

            builder.HasMany(a => a.FileToBook)
                .WithOne(a => a.Book)
                .HasForeignKey(a => a.BookId);
            builder.HasMany(a => a.CommentToBook)
                .WithOne(a => a.Book)
                .HasForeignKey(a => a.CommentId)
                .OnDelete(DeleteBehavior.NoAction); ;


            builder.HasOne(a => a.Language)
                .WithMany(a => a.Book)
                .HasForeignKey(a => a.LanguageId);


            builder.HasMany(a => a.Another)
                .WithOne(a => a.Book)
                .HasForeignKey(a => a.BookId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(a => a.OrderItem)
                .WithOne(a => a.Book)
                .HasForeignKey(a => a.BookId);
        }
    }
}
