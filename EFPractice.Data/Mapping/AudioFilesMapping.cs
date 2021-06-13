using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EFPractice.Data.Mapping
{
    public class AudioFilesMapping : IEntityTypeConfiguration<AudioFiles>
    {
        public void Configure(EntityTypeBuilder<AudioFiles> builder)
        {
            builder.ToTable("AudioFiles", "sch");

            builder.HasKey(x => x.Id)
                .HasName("PK_AudioFilesId")
                .IsClustered();

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Duration)
                .HasMaxLength(128)
                .IsUnicode()
                .HasColumnName("Duration");

            builder.HasAlternateKey(x => x.Id)
                .HasName("FK_AudioFilesId");

            builder.HasData(
                new AudioFiles[]
                {
                    new AudioFiles {Id=1, Duration = "3m", Bitrate = 700, ChannelCount = 1, SampleRate = 44100 },
                    new AudioFiles {Id=2, Duration = "5m", Bitrate = 700, ChannelCount = 2, SampleRate = 44100 }
                });
        }
    }
}
