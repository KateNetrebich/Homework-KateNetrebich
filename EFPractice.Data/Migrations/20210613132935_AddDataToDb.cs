using Microsoft.EntityFrameworkCore.Migrations;

namespace EFPractice.Data.Migrations
{
    public partial class AddDataToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VideoFiles",
                table: "VideoFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TextFiles",
                table: "TextFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                table: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directories",
                table: "Directories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AudioFiles",
                table: "AudioFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageFiles",
                table: "ImageFiles");

            migrationBuilder.EnsureSchema(
                name: "sch");

            migrationBuilder.RenameTable(
                name: "VideoFiles",
                newName: "VideoFiles",
                newSchema: "sch");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Users",
                newSchema: "sch");

            migrationBuilder.RenameTable(
                name: "TextFiles",
                newName: "TextFiles",
                newSchema: "sch");

            migrationBuilder.RenameTable(
                name: "Files",
                newName: "Files",
                newSchema: "sch");

            migrationBuilder.RenameTable(
                name: "FilePermissions",
                newName: "FilePermissions",
                newSchema: "sch");

            migrationBuilder.RenameTable(
                name: "DirectoryPermissions",
                newName: "DirectoryPermissions",
                newSchema: "sch");

            migrationBuilder.RenameTable(
                name: "Directories",
                newName: "Directories",
                newSchema: "sch");

            migrationBuilder.RenameTable(
                name: "AudioFiles",
                newName: "AudioFiles",
                newSchema: "sch");

            migrationBuilder.RenameTable(
                name: "ImageFiles",
                newName: "ImageFile",
                newSchema: "sch");

            migrationBuilder.RenameColumn(
                name: "Extension",
                schema: "sch",
                table: "Files",
                newName: "Extention");

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                schema: "sch",
                table: "VideoFiles",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                schema: "sch",
                table: "Users",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "sch",
                table: "Users",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "sch",
                table: "Users",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "sch",
                table: "TextFiles",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "sch",
                table: "Files",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Extention",
                schema: "sch",
                table: "Files",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "sch",
                table: "Directories",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                schema: "sch",
                table: "AudioFiles",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "FK_VideoFilesId",
                schema: "sch",
                table: "VideoFiles",
                column: "Id")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersId",
                schema: "sch",
                table: "Users",
                column: "Id")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.AddPrimaryKey(
                name: "FK_TextFilesId",
                schema: "sch",
                table: "TextFiles",
                column: "Id")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.AddUniqueConstraint(
                name: "FK_DirectoriesID",
                schema: "sch",
                table: "Files",
                column: "DirectoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Files",
                schema: "sch",
                table: "Files",
                column: "Id")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_DirectoriesParentId",
                schema: "sch",
                table: "Directories",
                column: "ParentDirectoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DirectoriesId",
                schema: "sch",
                table: "Directories",
                column: "Id")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.AddPrimaryKey(
                name: "FK_AudioFilesId",
                schema: "sch",
                table: "AudioFiles",
                column: "Id")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.AddPrimaryKey(
                name: "FK_ImageFilesId",
                schema: "sch",
                table: "ImageFile",
                column: "Id")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.InsertData(
                schema: "sch",
                table: "AudioFiles",
                columns: new[] { "Id", "Bitrate", "ChannelCount", "Duration", "SampleRate" },
                values: new object[,]
                {
                    { -1, 700, 1, "3m", 44100 },
                    { -2, 700, 2, "5m", 44100 }
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
                table: "DirectoryPermissions",
                columns: new[] { "DirectoryId", "CanRead", "CanWrite", "UserId" },
                values: new object[,]
                {
                    { 1, true, true, 1 },
                    { 2, true, false, 2 }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "FilePermissions",
                columns: new[] { "FileId", "CanRead", "CanWrite", "UserId" },
                values: new object[,]
                {
                    { 1, true, false, 1 },
                    { 2, true, true, 2 }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "Files",
                columns: new[] { "Id", "DirectoryId", "Extention", "Title" },
                values: new object[,]
                {
                    { 2, 2, ".pdf", "Book" },
                    { 1, 1, ".png", "Image" }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "ImageFile",
                columns: new[] { "Id", "Height", "Width" },
                values: new object[,]
                {
                    { -1, 100, 100 },
                    { -2, 150, 150 }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "TextFiles",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { -1, "TextFileContent1" },
                    { -2, "TextFileContent2" }
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
                table: "VideoFiles",
                columns: new[] { "Id", "Duration", "Height", "Width" },
                values: new object[,]
                {
                    { -1, "1h34m", 1920, 1080 },
                    { -2, "3h20m", 1920, 1080 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "FK_VideoFilesId",
                schema: "sch",
                table: "VideoFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersId",
                schema: "sch",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "FK_TextFilesId",
                schema: "sch",
                table: "TextFiles");

            migrationBuilder.DropUniqueConstraint(
                name: "FK_DirectoriesID",
                schema: "sch",
                table: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                schema: "sch",
                table: "Files");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_DirectoriesParentId",
                schema: "sch",
                table: "Directories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DirectoriesId",
                schema: "sch",
                table: "Directories");

            migrationBuilder.DropPrimaryKey(
                name: "FK_AudioFilesId",
                schema: "sch",
                table: "AudioFiles");

            migrationBuilder.DropPrimaryKey(
                name: "FK_ImageFilesId",
                schema: "sch",
                table: "ImageFile");

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "AudioFiles",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "AudioFiles",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "Directories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "Directories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "DirectoryPermissions",
                keyColumn: "DirectoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "DirectoryPermissions",
                keyColumn: "DirectoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "FilePermissions",
                keyColumn: "FileId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "FilePermissions",
                keyColumn: "FileId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "Files",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "Files",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "ImageFile",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "ImageFile",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "TextFiles",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "TextFiles",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "VideoFiles",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "VideoFiles",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.RenameTable(
                name: "VideoFiles",
                schema: "sch",
                newName: "VideoFiles");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "sch",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "TextFiles",
                schema: "sch",
                newName: "TextFiles");

            migrationBuilder.RenameTable(
                name: "Files",
                schema: "sch",
                newName: "Files");

            migrationBuilder.RenameTable(
                name: "FilePermissions",
                schema: "sch",
                newName: "FilePermissions");

            migrationBuilder.RenameTable(
                name: "DirectoryPermissions",
                schema: "sch",
                newName: "DirectoryPermissions");

            migrationBuilder.RenameTable(
                name: "Directories",
                schema: "sch",
                newName: "Directories");

            migrationBuilder.RenameTable(
                name: "AudioFiles",
                schema: "sch",
                newName: "AudioFiles");

            migrationBuilder.RenameTable(
                name: "ImageFile",
                schema: "sch",
                newName: "ImageFiles");

            migrationBuilder.RenameColumn(
                name: "Extention",
                table: "Files",
                newName: "Extension");

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "VideoFiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "TextFiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Extension",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Directories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "AudioFiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideoFiles",
                table: "VideoFiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TextFiles",
                table: "TextFiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Files",
                table: "Files",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directories",
                table: "Directories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AudioFiles",
                table: "AudioFiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageFiles",
                table: "ImageFiles",
                column: "Id");
        }
    }
}
