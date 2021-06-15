using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Data.Mapping
{
    public class AudioFilesMapping : IEntityTypeConfiguration<AudioFile>
    {
        public void Configure(EntityTypeBuilder<AudioFile> builder)
        {
            builder.ToTable("AudioFiles", "sch");

            builder.Property(x => x.Duration)
                .HasMaxLength(128)
                .IsUnicode()
                .HasColumnName("Duration");

            builder.HasOne(x => x.Directory)
                .WithMany()
                .HasForeignKey(x => x.DirectoryId)
                .HasConstraintName("FK_AudioFiles_Directories_DirectoryId");

            builder.HasData(
                new AudioFile[]
                {
                    new AudioFile {Id=7, Duration = "3m", Bitrate = 700, ChannelCount = 1, SampleRate = 44100 },
                    new AudioFile {Id=8, Duration = "5m", Bitrate = 700, ChannelCount = 2, SampleRate = 44100 }
                });
        }
    }
}
