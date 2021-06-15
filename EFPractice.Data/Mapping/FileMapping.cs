using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Data.Mapping
{
    public class FileMapping : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder.ToTable("Files", "sch");

            builder.HasKey(x => x.Id)
                .IsClustered();

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Title)
                .HasMaxLength(128)
                .IsUnicode()
                .HasColumnName("Title");

            builder.Property(x => x.Extension)
                .HasMaxLength(128)
                .IsUnicode()
                .HasColumnName("Extention"); ;

            builder.HasOne(x => x.Directory)
                .WithMany()
                .HasForeignKey(x => x.DirectoryId)
                .HasConstraintName("FK_Files_Directories_DirectoryId")
                .IsRequired();

        }
    }
}
