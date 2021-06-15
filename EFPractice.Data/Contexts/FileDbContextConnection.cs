using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection;

namespace EFPractice.Data.Contexts
{
    internal class FileDbContextConnection : IDesignTimeDbContextFactory<FileDbContext>
    {
        public FileDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FileDbContext>()
                .UseSqlServer(@"Server=LAPTOP-IO7I9C50;Database=EFPractice;Trusted_Connection=True;",
                    o =>
                    {
                        o.MigrationsHistoryTable("Migrations", "sch");
                        o.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                    }).EnableSensitiveDataLogging();

            return new FileDbContext(optionsBuilder.Options);
        }
    }
}
