using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RefHub_EFCore_Sample.Migrations
{
    /// <inheritdoc />
    public partial class AddRelFileToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileManager_Users_UserId",
                table: "FileManager");

            migrationBuilder.DropForeignKey(
                name: "FK_FileToUser_FileManager_FileId",
                table: "FileToUser");

            migrationBuilder.DropForeignKey(
                name: "FK_FileToUser_Users_UserId",
                table: "FileToUser");

            migrationBuilder.DropIndex(
                name: "IX_FileManager_UserId",
                table: "FileManager");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FileManager");

            migrationBuilder.AddColumn<int>(
                name: "FileManagerFileId",
                table: "FileToUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "IX_FileToUser_FileManagerFileId",
                table: "FileToUser",
                column: "FileManagerFileId");

            migrationBuilder.CreateIndex(
                name: "IX_FileManagerUser_UserId",
                table: "FileManagerUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileToUser_FileManager_FileManagerFileId",
                table: "FileToUser",
                column: "FileManagerFileId",
                principalTable: "FileManager",
                principalColumn: "FileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FileToUser_Users_UserId",
                table: "FileToUser",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileToUser_FileManager_FileManagerFileId",
                table: "FileToUser");

            migrationBuilder.DropForeignKey(
                name: "FK_FileToUser_Users_UserId",
                table: "FileToUser");

            migrationBuilder.DropTable(
                name: "FileManagerUser");

            migrationBuilder.DropIndex(
                name: "IX_FileToUser_FileManagerFileId",
                table: "FileToUser");

            migrationBuilder.DropColumn(
                name: "FileManagerFileId",
                table: "FileToUser");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "FileManager",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FileManager_UserId",
                table: "FileManager",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileManager_Users_UserId",
                table: "FileManager",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FileToUser_FileManager_FileId",
                table: "FileToUser",
                column: "FileId",
                principalTable: "FileManager",
                principalColumn: "FileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FileToUser_Users_UserId",
                table: "FileToUser",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
