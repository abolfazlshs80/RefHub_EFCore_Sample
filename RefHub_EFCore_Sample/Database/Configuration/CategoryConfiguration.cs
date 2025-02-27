using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .Property<DateTime>("CreateDate")
                .HasDefaultValueSql("GETDATE()");

            builder
                .Property<DateTime>("UpdateDate")
                .HasDefaultValueSql("GETDATE()");
            builder.HasKey(a => new { a.CategoryId, });
            //builder.HasData(new List<Category>()
            //{
            //    new Category() {CategoryId = 1, LanguageId = 1, Name = "همه", Desc = "تمام دسته بندی ها هست" },
            //    new Category() {CategoryId = 2, LanguageId = 2, Name = "ALL", Desc = "this is a all category" }
            //});
            builder
              .Property(p => p.Name)
             .HasField("_name");
            // معرفی backing field به EF



            //builder
            //    .Property<string>("CreateBy")
            //    .ValueGeneratedOnUpdate();

        }
    }
}
