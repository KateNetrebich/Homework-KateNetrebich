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

            builder.Property(x => x.Content)
               .HasMaxLength(128)
               .IsUnicode()
               .HasColumnName("Content");

            builder.HasData(
               new TextFile[]
               {
                    new TextFile {Id=3, Content = "TextFileContent1" },
                    new TextFile {Id=4, Content = "TextFileContent2" }
               });
        }
    }
}
