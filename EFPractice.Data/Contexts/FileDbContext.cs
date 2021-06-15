using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFPractice.Data.Contexts
{
    public class FileDbContext : DbContext
    {
        public FileDbContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<VideoFile> VideoFiles { get; set; }
        public DbSet<AudioFile> AudioFiles { get; set; }
        public DbSet<TextFile> TextFiles { get; set; }
        public DbSet<Directory> Directories { get; set; }
        public DbSet<DirectoryPermission> DirectoryPermissions { get; set; }
        public DbSet<FilePermission> FilePermissions { get; set; }

        public FileDbContext(DbContextOptions<FileDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("sch");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
