using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RefHub_EFCore_Sample.Migrations
{
    /// <inheritdoc />
    public partial class AddRelFileToUserupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileToUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileToUser",
                columns: table => new
                {
                    FileId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FileManagerFileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileToUser", x => new { x.FileId, x.UserId });
                    table.ForeignKey(
                        name: "FK_FileToUser_FileManager_FileManagerFileId",
                        column: x => x.FileManagerFileId,
                        principalTable: "FileManager",
                        principalColumn: "FileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileToUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileToUser_FileManagerFileId",
                table: "FileToUser",
                column: "FileManagerFileId");

            migrationBuilder.CreateIndex(
                name: "IX_FileToUser_UserId",
                table: "FileToUser",
                column: "UserId");
        }
    }
}
