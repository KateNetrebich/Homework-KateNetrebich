using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Data.Mapping
{
    public class VideoFilesMapping : IEntityTypeConfiguration<VideoFile>
    {
        public void Configure(EntityTypeBuilder<VideoFile> builder)
        {
            builder.ToTable("VideoFiles", "sch");

            builder.Property(x => x.Duration)
                .HasMaxLength(128)
                .IsUnicode()
                .HasColumnName("Duration");

            builder.HasOne(x => x.Directory)
                .WithMany()
                .HasForeignKey(x => x.DirectoryId)
                .HasConstraintName("FK_VideoFiles_Directories_DirectoryId");

            builder.HasData(
                new VideoFile[]
                {
                    new VideoFile {Id=1, Width = 1080, Height = 1920, Duration = "1h34m" },
                    new VideoFile {Id=2, Width = 1080, Height = 1920, Duration = "3h20m" }
                });
        }
    }
}
