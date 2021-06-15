using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Data.Mapping
{
    public class FilePermissionMapping : IEntityTypeConfiguration<FilePermission>
    {
        public void Configure(EntityTypeBuilder<FilePermission> builder)
        {
            builder.HasKey(x => new { x.FileId, x.UserId });

            builder.HasOne(x => x.File)
                .WithMany()
                .HasForeignKey(x => x.FileId)
                .HasConstraintName("FK_FilePermission_FileId")
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .HasConstraintName("FK_FilePermission_UserId")
                .IsRequired();

            builder.HasData(new FilePermission[]
            {
                new FilePermission { FileId = 1, UserId = 1, CanRead = true, CanWrite = false },
                new FilePermission { FileId = 2, UserId = 2, CanRead = true, CanWrite = true }
            });
        }
    }
}
