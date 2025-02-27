using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class PersonLevelConfiguration: IEntityTypeConfiguration<PersonLevel>
    {
        public void Configure(EntityTypeBuilder<PersonLevel> builder)
        {
            builder.HasKey(a => new { a.PersonLevelId, });
        }
    }
}
