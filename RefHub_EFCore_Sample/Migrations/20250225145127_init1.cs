using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RefHub_EFCore_Sample.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileToBlog_FileManager_FileManagerFileId",
                table: "FileToBlog");

            migrationBuilder.DropForeignKey(
                name: "FK_FileToBook_FileManager_FileManagerFileId",
                table: "FileToBook");

            migrationBuilder.DropIndex(
                name: "IX_FileToBook_FileManagerFileId",
                table: "FileToBook");

            migrationBuilder.DropIndex(
                name: "IX_FileToBlog_FileManagerFileId",
                table: "FileToBlog");

            migrationBuilder.DropColumn(
                name: "FileManagerFileId",
                table: "FileToBook");

            migrationBuilder.DropColumn(
                name: "FileManagerFileId",
                table: "FileToBlog");

            migrationBuilder.CreateIndex(
                name: "IX_FileToBook_FileId",
                table: "FileToBook",
                column: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileToBlog_FileManager_FileId",
                table: "FileToBlog",
                column: "FileId",
                principalTable: "FileManager",
                principalColumn: "FileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FileToBook_FileManager_FileId",
                table: "FileToBook",
                column: "FileId",
                principalTable: "FileManager",
                principalColumn: "FileId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileToBlog_FileManager_FileId",
                table: "FileToBlog");

            migrationBuilder.DropForeignKey(
                name: "FK_FileToBook_FileManager_FileId",
                table: "FileToBook");

            migrationBuilder.DropIndex(
                name: "IX_FileToBook_FileId",
                table: "FileToBook");

            migrationBuilder.AddColumn<int>(
                name: "FileManagerFileId",
                table: "FileToBook",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FileManagerFileId",
                table: "FileToBlog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FileToBook_FileManagerFileId",
                table: "FileToBook",
                column: "FileManagerFileId");

            migrationBuilder.CreateIndex(
                name: "IX_FileToBlog_FileManagerFileId",
                table: "FileToBlog",
                column: "FileManagerFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileToBlog_FileManager_FileManagerFileId",
                table: "FileToBlog",
                column: "FileManagerFileId",
                principalTable: "FileManager",
                principalColumn: "FileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FileToBook_FileManager_FileManagerFileId",
                table: "FileToBook",
                column: "FileManagerFileId",
                principalTable: "FileManager",
                principalColumn: "FileId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
