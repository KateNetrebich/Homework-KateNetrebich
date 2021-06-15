using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Data.Mapping
{
    public class DirectoriesMapping : IEntityTypeConfiguration<Directory>
    {
        public void Configure(EntityTypeBuilder<Directory> builder)
        {
            builder.ToTable("Directories", "sch");
            builder.HasKey(x => x.Id).HasName("PK_DirectoryId").IsClustered();

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Title)
                .HasMaxLength(128)
                .IsRequired()
                .HasColumnName("Title");

            builder.HasData(
               new Directory[]
               {
                    new Directory {Id=1, ParentDirectoryId = 1, Title = "D" },
                    new Directory {Id=2, ParentDirectoryId = 2, Title = "C" }
               });
        }
    }
}
