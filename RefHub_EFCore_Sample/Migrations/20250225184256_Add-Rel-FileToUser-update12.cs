using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RefHub_EFCore_Sample.Migrations
{
    /// <inheritdoc />
    public partial class AddRelFileToUserupdate12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileManagerUser");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "FileManager",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FileToUser",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileToUser", x => new { x.FileId, x.UserId });
                    table.ForeignKey(
                        name: "FK_FileToUser_FileManager_FileId",
                        column: x => x.FileId,
                        principalTable: "FileManager",
                        principalColumn: "FileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileToUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileManager_UserId",
                table: "FileManager",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FileToUser_UserId",
                table: "FileToUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileManager_Users_UserId",
                table: "FileManager",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileManager_Users_UserId",
                table: "FileManager");

            migrationBuilder.DropTable(
                name: "FileToUser");

            migrationBuilder.DropIndex(
                name: "IX_FileManager_UserId",
                table: "FileManager");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FileManager");

            migrationBuilder.CreateTable(
                name: "FileManagerUser",
                columns: table => new
                {
                    FileManagerFileId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileManagerUser", x => new { x.FileManagerFileId, x.UserId });
                    table.ForeignKey(
                        name: "FK_FileManagerUser_FileManager_FileManagerFileId",
                        column: x => x.FileManagerFileId,
                        principalTable: "FileManager",
                        principalColumn: "FileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileManagerUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileManagerUser_UserId",
                table: "FileManagerUser",
                column: "UserId");
        }
    }
}
