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

        public DbSet<Files> Files { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<VideoFiles> VideoFiles { get; set; }
        public DbSet<AudioFiles> AudioFiles { get; set; }
        public DbSet<TextFile> TextFiles { get; set; }
        public DbSet<Directories> Directories { get; set; }
        public DbSet<DirectoryPermission> DirectoryPermissions { get; set; }
        public DbSet<FilePermission> FilePermissions { get; set; }

        public FileDbContext(DbContextOptions<FileDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-IO7I9C50;Database=EFPracticeDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("sch");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<DirectoryPermission>().HasData(
                new DirectoryPermission[]
                {
                    new DirectoryPermission { DirectoryId = 1, UserId = 1, CanRead = true, CanWrite = true },
                    new DirectoryPermission { DirectoryId = 2, UserId = 2, CanRead = true, CanWrite = false }
                });

            modelBuilder.Entity<FilePermission>().HasData(
                new FilePermission[]
                {
                    new FilePermission { FileId = 1, UserId = 1, CanRead = true, CanWrite = false },
                    new FilePermission { FileId = 2, UserId = 2, CanRead = true, CanWrite = true }
                });
        }

    }
}
