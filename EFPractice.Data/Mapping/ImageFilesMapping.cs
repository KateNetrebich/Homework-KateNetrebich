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

            builder.HasData(
                new ImageFile[]
                {
                     new ImageFile {Id=5, Height = 100, Width = 100 },
                    new ImageFile {Id=6,Height = 150, Width = 150 }
                });
        }
    }
}
