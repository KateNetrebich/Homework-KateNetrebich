using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Data.Mapping
{
    public class VideoFilesMapping : IEntityTypeConfiguration<VideoFiles>
    {
        public void Configure(EntityTypeBuilder<VideoFiles> builder)
        {
            builder.ToTable("VideoFiles", "sch");

            builder.HasKey(x => x.Id)
            .HasName("PK_VideoFilesId").IsClustered();

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Duration)
                .HasMaxLength(128)
                .IsUnicode()
                .HasColumnName("Duration");

            builder.HasAlternateKey(x => x.Id)
               .HasName("FK_VideoFilesId");

            builder.HasData(
                new VideoFiles[]
                {
                    new VideoFiles {Id=1, Width = 1080, Height = 1920, Duration = "1h34m" },
                    new VideoFiles {Id=2, Width = 1080, Height = 1920, Duration = "3h20m" }
                });
        }
    }
}
