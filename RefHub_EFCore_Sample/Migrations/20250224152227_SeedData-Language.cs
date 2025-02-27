using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RefHub_EFCore_Sample.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataLanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "LanguageId", "DisplayName", "Name" },
                values: new object[,]
                {
                    { 1, "Iran", "fa-IR" },
                    { 2, "English", "en-US" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "LanguageId",
                keyValue: 2);
        }
    }
}
