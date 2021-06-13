using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Data.Mapping
{
    public class FileMapping : IEntityTypeConfiguration<Files>
    {
        public void Configure(EntityTypeBuilder<Files> builder)
        {
            builder.ToTable("Files", "sch");

            builder.HasKey(x => x.Id)
                .HasName("PK_Files")
                .IsClustered();

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Title)
                .HasMaxLength(128)
                .IsRequired()
                .HasColumnName("Title");

            builder.Property(x => x.Extension)
                .HasMaxLength(128)
                .IsUnicode()
                .HasColumnName("Extention"); ;

            builder.HasAlternateKey(x => x.DirectoryId)
                .HasName("FK_DirectoriesID");

            builder.HasData(
                new Files[]
                {
                    new Files {Id=1, Extension = ".png", DirectoryId = 1, Title = "Image" },
                    new Files {Id=2, Extension = ".pdf", DirectoryId = 2, Title = "Book" }
                });
        }

    }
}
