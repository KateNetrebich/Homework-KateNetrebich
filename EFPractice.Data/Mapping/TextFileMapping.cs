using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Data.Mapping
{
    public class TextFileMapping : IEntityTypeConfiguration<TextFile>
    {
        public void Configure(EntityTypeBuilder<TextFile> builder)
        {
            builder.ToTable("TextFiles", "sch");

            builder.HasKey(x => x.Id)
                .HasName("PK_TextFilesId")
                .IsClustered();

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Content)
               .HasMaxLength(128)
               .IsUnicode()
               .HasColumnName("Content");

            builder.HasAlternateKey(x => x.Id)
               .HasName("FK_TextFilesId");

            builder.HasData(
               new TextFile[]
               {
                    new TextFile {Id=1, Content = "TextFileContent1" },
                    new TextFile {Id=2, Content = "TextFileContent2" }
               });
        }
    }
}
