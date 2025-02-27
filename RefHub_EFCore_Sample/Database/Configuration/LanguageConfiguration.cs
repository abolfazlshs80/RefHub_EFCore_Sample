using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class LanguageConfiguration: IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(a => new { a.LanguageId, });

            builder.HasMany(a => a.PersonLevel)
                .WithOne(a => a.Language)
                .HasForeignKey(a => a.LanguageId).OnDelete(DeleteBehavior.NoAction); ;

            builder.HasMany(a => a.Category)
                .WithOne(a => a.Language)
                .HasForeignKey(a => a.LanguageId)
                .OnDelete(DeleteBehavior.NoAction); ;
            builder.HasMany(a => a.Tag)
                .WithOne(a => a.Language)
                .HasForeignKey(a => a.LanguageId);

            builder.HasMany(a => a.Blog)
                .WithOne(a => a.Language)
                .HasForeignKey(a => a.LanguageId);
            builder.HasMany(a => a.Book)
                .WithOne(a => a.Language)
                .HasForeignKey(a => a.LanguageId);


            builder.HasData(new List<Language>()
            {
                new Language() { Name = "fa-IR", DisplayName = "Iran" ,LanguageId = 1},
                new Language() { Name = "en-US", DisplayName = "English" ,LanguageId = 2}
            });
        }
    }
}
