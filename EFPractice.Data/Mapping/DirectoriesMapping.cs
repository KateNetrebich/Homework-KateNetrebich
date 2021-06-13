using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Data.Mapping
{
    public class DirectoriesMapping : IEntityTypeConfiguration<Directories>
    {
        public void Configure(EntityTypeBuilder<Directories> builder)
        {
            builder.ToTable("Directories", "sch");
            builder.HasKey(x => x.Id).HasName("PK_DirectoriesId").IsClustered();

            builder.HasAlternateKey(x => x.ParentDirectoryId).HasName("AK_DirectoriesParentId");

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Title)
                .HasMaxLength(128)
                .IsRequired()
                .HasColumnName("Title");

            builder.HasData(
               new Directories[]
               {
                    new Directories {Id=1, ParentDirectoryId = 1, Title = "D" },
                    new Directories {Id=2, ParentDirectoryId = 2, Title = "C" }
               });
        }
    }
}
