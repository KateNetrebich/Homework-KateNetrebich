using Microsoft.EntityFrameworkCore.Migrations;

namespace EFPractice.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sch");

            migrationBuilder.CreateTable(
                name: "Directories",
                schema: "sch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentDirectoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoryId", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "sch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersId", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                schema: "sch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Extention = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    DirectoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Files_Directories_DirectoryId",
                        column: x => x.DirectoryId,
                        principalSchema: "sch",
                        principalTable: "Directories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DirectoryPermissions",
                schema: "sch",
                columns: table => new
                {
                    DirectoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CanRead = table.Column<bool>(type: "bit", nullable: false),
                    CanWrite = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoryPermissions", x => new { x.DirectoryId, x.UserId });
                    table.ForeignKey(
                        name: "FK_DirectoryPermission_DirectoryId",
                        column: x => x.DirectoryId,
                        principalSchema: "sch",
                        principalTable: "Directories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectoryPermission_UserId",
                        column: x => x.UserId,
                        principalSchema: "sch",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AudioFiles",
                schema: "sch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Bitrate = table.Column<int>(type: "int", nullable: false),
                    SampleRate = table.Column<int>(type: "int", nullable: false),
                    ChannelCount = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioFiles", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_AudioFiles_Files_Id",
                        column: x => x.Id,
                        principalSchema: "sch",
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilePermissions",
                schema: "sch",
                columns: table => new
                {
                    FileId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CanRead = table.Column<bool>(type: "bit", nullable: false),
                    CanWrite = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilePermissions", x => new { x.FileId, x.UserId });
                    table.ForeignKey(
                        name: "FK_FilePermission_FileId",
                        column: x => x.FileId,
                        principalSchema: "sch",
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilePermission_UserId",
                        column: x => x.UserId,
                        principalSchema: "sch",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageFile",
                schema: "sch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageFile", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_ImageFile_Files_Id",
                        column: x => x.Id,
                        principalSchema: "sch",
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TextFiles",
                schema: "sch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextFiles", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_TextFiles_Files_Id",
                        column: x => x.Id,
                        principalSchema: "sch",
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoFiles",
                schema: "sch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoFiles", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_VideoFiles_Files_Id",
                        column: x => x.Id,
                        principalSchema: "sch",
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "Directories",
                columns: new[] { "Id", "ParentDirectoryId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "D" },
                    { 2, 2, "C" }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "Files",
                columns: new[] { "Id", "DirectoryId", "Extention", "Title" },
                values: new object[,]
                {
                    { 7, 0, null, null },
                    { 8, 0, null, null },
                    { 5, 0, null, null },
                    { 6, 0, null, null },
                    { 3, 0, null, null },
                    { 4, 0, null, null },
                    { 1, 0, null, null },
                    { 2, 0, null, null }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { 1, "newEmail1@gmail.com", "User1", "$2a$11$3hhRIl5fwk0D0P5gb8mBhOGOjMbM.YT4RqbA64dPwd6ps5rBCzuYS" },
                    { 2, "newEmail2@gmail.com", "User2", "$2a$11$3hhRIl5fwk0D0P5gb8mBhOGOjMbM.YT4RqbA64dPwd6ps5rBCzuYS" }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "AudioFiles",
                columns: new[] { "Id", "Bitrate", "ChannelCount", "Duration", "SampleRate" },
                values: new object[,]
                {
                    { 7, 700, 1, "3m", 44100 },
                    { 8, 700, 2, "5m", 44100 }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "DirectoryPermissions",
                columns: new[] { "DirectoryId", "UserId", "CanRead", "CanWrite" },
                values: new object[,]
                {
                    { 1, 1, true, true },
                    { 2, 2, true, false }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "FilePermissions",
                columns: new[] { "FileId", "UserId", "CanRead", "CanWrite" },
                values: new object[,]
                {
                    { 1, 1, true, false },
                    { 2, 2, true, true }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "ImageFile",
                columns: new[] { "Id", "Height", "Width" },
                values: new object[,]
                {
                    { 5, 100, 100 },
                    { 6, 150, 150 }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "TextFiles",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { 3, "TextFileContent1" },
                    { 4, "TextFileContent2" }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "VideoFiles",
                columns: new[] { "Id", "Duration", "Height", "Width" },
                values: new object[,]
                {
                    { 1, "1h34m", 1920, 1080 },
                    { 2, "3h20m", 1920, 1080 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DirectoryPermissions_UserId",
                schema: "sch",
                table: "DirectoryPermissions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FilePermissions_UserId",
                schema: "sch",
                table: "FilePermissions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_DirectoryId",
                schema: "sch",
                table: "Files",
                column: "DirectoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AudioFiles",
                schema: "sch");

            migrationBuilder.DropTable(
                name: "DirectoryPermissions",
                schema: "sch");

            migrationBuilder.DropTable(
                name: "FilePermissions",
                schema: "sch");

            migrationBuilder.DropTable(
                name: "ImageFile",
                schema: "sch");

            migrationBuilder.DropTable(
                name: "TextFiles",
                schema: "sch");

            migrationBuilder.DropTable(
                name: "VideoFiles",
                schema: "sch");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "sch");

            migrationBuilder.DropTable(
                name: "Files",
                schema: "sch");

            migrationBuilder.DropTable(
                name: "Directories",
                schema: "sch");
        }
    }
}
