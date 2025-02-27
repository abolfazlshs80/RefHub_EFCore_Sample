using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Database.Configuration
{
    public class FileManagerConfiguration: IEntityTypeConfiguration<FileManager>
    {
        public void Configure(EntityTypeBuilder<FileManager> builder)
        {
            builder.HasKey(a => new { a.FileId, });

            builder.HasMany(a => a.FileToBlog)
                .WithOne(a => a.FileManager)
                .HasForeignKey(a => a.FileId);
            builder.HasMany(a => a.FileToBook)
                .WithOne(a => a.FileManager)
                .HasForeignKey(a => a.FileId);

            builder.HasMany(a => a.FileToUser)
                .WithOne(a => a.FileManager)
                .HasForeignKey(a => a.FileId);
        }
    }
}
