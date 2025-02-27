using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class BookToAnotherConfiguration: IEntityTypeConfiguration<BookToAnother>
    {
        public void Configure(EntityTypeBuilder<BookToAnother> builder)
        {
            builder.HasKey(a => new { a.BookId,a.AnotherId });
        }
    }
}
