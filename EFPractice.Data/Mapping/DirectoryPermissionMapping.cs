using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Data.Mapping
{
    public class DirectoryPermissionMapping : IEntityTypeConfiguration<DirectoryPermission>
    {
        public void Configure(EntityTypeBuilder<DirectoryPermission> builder)
        {
            builder.HasKey(x => new { x.DirectoryId, x.UserId });

            builder.HasOne(x => x.Directory)
                .WithMany()
                .HasForeignKey(x => x.DirectoryId)
                .HasConstraintName("FK_DirectoryPermission_DirectoryId")
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .HasConstraintName("FK_DirectoryPermission_UserId")
                .IsRequired();

            builder.HasData(
                new DirectoryPermission[]
                {
                    new DirectoryPermission { DirectoryId = 1, UserId = 1, CanRead = true, CanWrite = true },
                    new DirectoryPermission { DirectoryId = 2, UserId = 2, CanRead = true, CanWrite = false }
                });
        }
    }
}
