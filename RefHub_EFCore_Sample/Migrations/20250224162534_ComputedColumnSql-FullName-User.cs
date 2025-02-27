using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RefHub_EFCore_Sample.Migrations
{
    /// <inheritdoc />
    public partial class ComputedColumnSqlFullNameUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "Category",
            //    keyColumn: "CategoryId",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Category",
            //    keyColumn: "CategoryId",
            //    keyValue: 2);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[Family]+' '+ [Name]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Desc", "LanguageId", "Name" },
                values: new object[,]
                {
                    { 1, "تمام دسته بندی ها هست", 1, "همه" },
                    { 2, "this is a all category", 2, "ALL" }
                });
        }
    }
}
