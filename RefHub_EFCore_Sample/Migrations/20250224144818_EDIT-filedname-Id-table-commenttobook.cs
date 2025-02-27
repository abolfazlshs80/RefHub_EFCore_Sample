using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RefHub_EFCore_Sample.Migrations
{
    /// <inheritdoc />
    public partial class EDITfilednameIdtablecommenttobook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentToBook_Book_CommentIdD",
                table: "CommentToBook");

            migrationBuilder.RenameColumn(
                name: "CommentIdD",
                table: "CommentToBook",
                newName: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentToBook_Book_CommentId",
                table: "CommentToBook",
                column: "CommentId",
                principalTable: "Book",
                principalColumn: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentToBook_Book_CommentId",
                table: "CommentToBook");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "CommentToBook",
                newName: "CommentIdD");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentToBook_Book_CommentIdD",
                table: "CommentToBook",
                column: "CommentIdD",
                principalTable: "Book",
                principalColumn: "BookId");
        }
    }
}
