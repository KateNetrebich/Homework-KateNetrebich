﻿// <auto-generated />
using EFPractice.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFPractice.Data.Migrations
{
    [DbContext(typeof(FileDbContext))]
    [Migration("20210615135908_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("sch")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFPractice.Core.Entities.Directory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParentDirectoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("Title");

                    b.HasKey("Id")
                        .HasName("PK_DirectoryId")
                        .IsClustered();

                    b.ToTable("Directories", "sch");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ParentDirectoryId = 1,
                            Title = "D"
                        },
                        new
                        {
                            Id = 2,
                            ParentDirectoryId = 2,
                            Title = "C"
                        });
                });

            modelBuilder.Entity("EFPractice.Core.Entities.DirectoryPermission", b =>
                {
                    b.Property<int>("DirectoryId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("CanRead")
                        .HasColumnType("bit");

                    b.Property<bool>("CanWrite")
                        .HasColumnType("bit");

                    b.HasKey("DirectoryId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("DirectoryPermissions");

                    b.HasData(
                        new
                        {
                            DirectoryId = 1,
                            UserId = 1,
                            CanRead = true,
                            CanWrite = true
                        },
                        new
                        {
                            DirectoryId = 2,
                            UserId = 2,
                            CanRead = true,
                            CanWrite = false
                        });
                });

            modelBuilder.Entity("EFPractice.Core.Entities.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DirectoryId")
                        .HasColumnType("int");

                    b.Property<string>("Extension")
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("Extention");

                    b.Property<string>("Title")
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("Title");

                    b.HasKey("Id")
                        .IsClustered();

                    b.HasIndex("DirectoryId");

                    b.ToTable("Files", "sch");
                });

            modelBuilder.Entity("EFPractice.Core.Entities.FilePermission", b =>
                {
                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("CanRead")
                        .HasColumnType("bit");

                    b.Property<bool>("CanWrite")
                        .HasColumnType("bit");

                    b.HasKey("FileId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("FilePermissions");

                    b.HasData(
                        new
                        {
                            FileId = 1,
                            UserId = 1,
                            CanRead = true,
                            CanWrite = false
                        },
                        new
                        {
                            FileId = 2,
                            UserId = 2,
                            CanRead = true,
                            CanWrite = true
                        });
                });

            modelBuilder.Entity("EFPractice.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("Name");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("PasswordHash");

                    b.HasKey("Id")
                        .HasName("PK_UsersId")
                        .IsClustered();

                    b.ToTable("Users", "sch");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "newEmail1@gmail.com",
                            Name = "User1",
                            PasswordHash = "$2a$11$3hhRIl5fwk0D0P5gb8mBhOGOjMbM.YT4RqbA64dPwd6ps5rBCzuYS"
                        },
                        new
                        {
                            Id = 2,
                            Email = "newEmail2@gmail.com",
                            Name = "User2",
                            PasswordHash = "$2a$11$3hhRIl5fwk0D0P5gb8mBhOGOjMbM.YT4RqbA64dPwd6ps5rBCzuYS"
                        });
                });

            modelBuilder.Entity("EFPractice.Core.Entities.AudioFile", b =>
                {
                    b.HasBaseType("EFPractice.Core.Entities.File");

                    b.Property<int>("Bitrate")
                        .HasColumnType("int");

                    b.Property<int>("ChannelCount")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("Duration");

                    b.Property<int>("SampleRate")
                        .HasColumnType("int");

                    b.ToTable("AudioFiles", "sch");

                    b.HasData(
                        new
                        {
                            Id = 7,
                            DirectoryId = 0,
                            Bitrate = 700,
                            ChannelCount = 1,
                            Duration = "3m",
                            SampleRate = 44100
                        },
                        new
                        {
                            Id = 8,
                            DirectoryId = 0,
                            Bitrate = 700,
                            ChannelCount = 2,
                            Duration = "5m",
                            SampleRate = 44100
                        });
                });

            modelBuilder.Entity("EFPractice.Core.Entities.ImageFile", b =>
                {
                    b.HasBaseType("EFPractice.Core.Entities.File");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.ToTable("ImageFile", "sch");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            DirectoryId = 0,
                            Height = 100,
                            Width = 100
                        },
                        new
                        {
                            Id = 6,
                            DirectoryId = 0,
                            Height = 150,
                            Width = 150
                        });
                });

            modelBuilder.Entity("EFPractice.Core.Entities.TextFile", b =>
                {
                    b.HasBaseType("EFPractice.Core.Entities.File");

                    b.Property<string>("Content")
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("Content");

                    b.ToTable("TextFiles", "sch");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            DirectoryId = 0,
                            Content = "TextFileContent1"
                        },
                        new
                        {
                            Id = 4,
                            DirectoryId = 0,
                            Content = "TextFileContent2"
                        });
                });

            modelBuilder.Entity("EFPractice.Core.Entities.VideoFile", b =>
                {
                    b.HasBaseType("EFPractice.Core.Entities.File");

                    b.Property<string>("Duration")
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("Duration");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.ToTable("VideoFiles", "sch");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DirectoryId = 0,
                            Duration = "1h34m",
                            Height = 1920,
                            Width = 1080
                        },
                        new
                        {
                            Id = 2,
                            DirectoryId = 0,
                            Duration = "3h20m",
                            Height = 1920,
                            Width = 1080
                        });
                });

            modelBuilder.Entity("EFPractice.Core.Entities.DirectoryPermission", b =>
                {
                    b.HasOne("EFPractice.Core.Entities.Directory", "Directory")
                        .WithMany()
                        .HasForeignKey("DirectoryId")
                        .HasConstraintName("FK_DirectoryPermission_DirectoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFPractice.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_DirectoryPermission_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Directory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EFPractice.Core.Entities.File", b =>
                {
                    b.HasOne("EFPractice.Core.Entities.Directory", "Directory")
                        .WithMany()
                        .HasForeignKey("DirectoryId")
                        .HasConstraintName("FK_Files_Directories_DirectoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Directory");
                });

            modelBuilder.Entity("EFPractice.Core.Entities.FilePermission", b =>
                {
                    b.HasOne("EFPractice.Core.Entities.File", "File")
                        .WithMany()
                        .HasForeignKey("FileId")
                        .HasConstraintName("FK_FilePermission_FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFPractice.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_FilePermission_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("File");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EFPractice.Core.Entities.AudioFile", b =>
                {
                    b.HasOne("EFPractice.Core.Entities.File", null)
                        .WithOne()
                        .HasForeignKey("EFPractice.Core.Entities.AudioFile", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFPractice.Core.Entities.ImageFile", b =>
                {
                    b.HasOne("EFPractice.Core.Entities.File", null)
                        .WithOne()
                        .HasForeignKey("EFPractice.Core.Entities.ImageFile", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFPractice.Core.Entities.TextFile", b =>
                {
                    b.HasOne("EFPractice.Core.Entities.File", null)
                        .WithOne()
                        .HasForeignKey("EFPractice.Core.Entities.TextFile", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFPractice.Core.Entities.VideoFile", b =>
                {
                    b.HasOne("EFPractice.Core.Entities.File", null)
                        .WithOne()
                        .HasForeignKey("EFPractice.Core.Entities.VideoFile", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
