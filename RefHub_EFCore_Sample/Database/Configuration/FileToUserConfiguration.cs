using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class FileToUserConfiguration: IEntityTypeConfiguration<FileToUser>
    {
        public void Configure(EntityTypeBuilder<FileToUser> builder)
        {
                    builder.HasKey(a => new { a.FileId,a.UserId });
        }
    }
}
