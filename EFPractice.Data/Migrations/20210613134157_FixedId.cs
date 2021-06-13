using Microsoft.EntityFrameworkCore.Migrations;

namespace EFPractice.Data.Migrations
{
    public partial class FixedId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "VideoFiles",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "VideoFiles",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.InsertData(
                schema: "sch",
                table: "AudioFiles",
                columns: new[] { "Id", "Bitrate", "ChannelCount", "Duration", "SampleRate" },
                values: new object[,]
                {
                    { 1, 700, 1, "3m", 44100 },
                    { 2, 700, 2, "5m", 44100 }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "ImageFile",
                columns: new[] { "Id", "Height", "Width" },
                values: new object[,]
                {
                    { 1, 100, 100 },
                    { 2, 150, 150 }
                });

            migrationBuilder.InsertData(
                schema: "sch",
                table: "TextFiles",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { 1, "TextFileContent1" },
                    { 2, "TextFileContent2" }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "sch",
                table: "AudioFiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "AudioFiles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "ImageFile",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "ImageFile",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "TextFiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "TextFiles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "VideoFiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "sch",
                table: "VideoFiles",
                keyColumn: "Id",
                keyValue: 2);

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
                table: "VideoFiles",
                columns: new[] { "Id", "Duration", "Height", "Width" },
                values: new object[,]
                {
                    { -1, "1h34m", 1920, 1080 },
                    { -2, "3h20m", 1920, 1080 }
                });
        }
    }
}
