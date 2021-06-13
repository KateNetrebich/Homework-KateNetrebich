using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Data.Mapping
{
    public class ImageFilesMapping : IEntityTypeConfiguration<ImageFile>
    {
        public void Configure(EntityTypeBuilder<ImageFile> builder)
        {
            builder.ToTable("ImageFile", "sch");

            builder.HasKey(x => x.Id)
                .HasName("PK_ImageFileId")
                .IsClustered();

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasAlternateKey(x => x.Id)
               .HasName("FK_ImageFilesId");

            builder.HasData(
                new ImageFile[]
                {
                     new ImageFile {Id=1, Height = 100, Width = 100 },
                    new ImageFile {Id=2,Height = 150, Width = 150 }
                });
        }
    }
}
