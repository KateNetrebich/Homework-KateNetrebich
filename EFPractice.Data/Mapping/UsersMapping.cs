using EFPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFPractice.Data.Mapping
{
    public class UsersMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", "sch");

            builder.HasKey(x => x.Id)
                .HasName("PK_UsersId")
                .IsClustered();

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
               .HasMaxLength(128)
               .IsRequired()
               .HasColumnName("Name");

            builder.Property(x => x.Email)
                .HasMaxLength(128)
                .IsRequired()
                .HasColumnName("Email");

            builder.Property(x => x.PasswordHash)
                .HasMaxLength(128)
                .IsUnicode()
                .HasColumnName("PasswordHash");

            builder.HasData(
                new User[]
                {
                    new User {Id=1, Name = "User1", PasswordHash = "$2a$11$3hhRIl5fwk0D0P5gb8mBhOGOjMbM.YT4RqbA64dPwd6ps5rBCzuYS",Email = "newEmail1@gmail.com" },
                    new User {Id=2, Name = "User2", PasswordHash = "$2a$11$3hhRIl5fwk0D0P5gb8mBhOGOjMbM.YT4RqbA64dPwd6ps5rBCzuYS", Email = "newEmail2@gmail.com" }
                });
        }
    }
}
