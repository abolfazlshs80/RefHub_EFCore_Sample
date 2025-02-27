using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RefHub_EFCore_Sample.Migrations
{
    /// <inheritdoc />
    public partial class SaveAllRelFluentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "CommentToBook",
                newName: "CommentIdD");

            migrationBuilder.AddColumn<int>(
                name: "UserAddressId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CommentIdD",
                table: "CommentToBook",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
          //      .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PersonLevelId",
                table: "Blog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserToRole_UserId",
                table: "UserToRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_UserId",
                table: "UserAddress",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TagToBook_BookId",
                table: "TagToBook",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_TagToBlog_TagId",
                table: "TagToBlog",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_LanguageId",
                table: "Tag",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonLevel_LanguageId",
                table: "PersonLevel",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_BookId",
                table: "OrderItem",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserAddressId",
                table: "Order",
                column: "UserAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FileToBook_FileId",
                table: "FileToBook",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_FileToBlog_BlogId",
                table: "FileToBlog",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_FileManager_UserId",
                table: "FileManager",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentToBlog_BlogId",
                table: "CommentToBlog",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_LanguageId",
                table: "Category",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_BookToAnother_AnotherId",
                table: "BookToAnother",
                column: "AnotherId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryId",
                table: "Book",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_LanguageId",
                table: "Book",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PersonLevelId",
                table: "Book",
                column: "PersonLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_CategoryId",
                table: "Blog",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_LanguageId",
                table: "Blog",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_PersonLevelId",
                table: "Blog",
                column: "PersonLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Another_LanguageId",
                table: "Another",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Another_Language_LanguageId",
                table: "Another",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Category_CategoryId",
                table: "Blog",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Language_LanguageId",
                table: "Blog",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_PersonLevel_PersonLevelId",
                table: "Blog",
                column: "PersonLevelId",
                principalTable: "PersonLevel",
                principalColumn: "PersonLevelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Category_CategoryId",
                table: "Book",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Language_LanguageId",
                table: "Book",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_PersonLevel_PersonLevelId",
                table: "Book",
                column: "PersonLevelId",
                principalTable: "PersonLevel",
                principalColumn: "PersonLevelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookToAnother_Another_AnotherId",
                table: "BookToAnother",
                column: "AnotherId",
                principalTable: "Another",
                principalColumn: "AnotherId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookToAnother_Book_BookId",
                table: "BookToAnother",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Language_LanguageId",
                table: "Category",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentToBlog_Blog_BlogId",
                table: "CommentToBlog",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentToBook_Book_CommentIdD",
                table: "CommentToBook",
                column: "CommentIdD",
                principalTable: "Book",
                principalColumn: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileManager_Users_UserId",
                table: "FileManager",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FileToBlog_Blog_BlogId",
                table: "FileToBlog",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FileToBlog_FileManager_FileId",
                table: "FileToBlog",
                column: "FileId",
                principalTable: "FileManager",
                principalColumn: "FileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FileToBook_Book_BookId",
                table: "FileToBook",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FileToBook_FileManager_FileId",
                table: "FileToBook",
                column: "FileId",
                principalTable: "FileManager",
                principalColumn: "FileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_UserAddress_UserAddressId",
                table: "Order",
                column: "UserAddressId",
                principalTable: "UserAddress",
                principalColumn: "UserAddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Users_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Book_BookId",
                table: "OrderItem",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonLevel_Language_LanguageId",
                table: "PersonLevel",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Language_LanguageId",
                table: "Tag",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagToBlog_Blog_BlogId",
                table: "TagToBlog",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagToBlog_Tag_TagId",
                table: "TagToBlog",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_TagToBook_Book_BookId",
                table: "TagToBook",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagToBook_Tag_TagId",
                table: "TagToBook",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddress_Users_UserId",
                table: "UserAddress",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserToRole_Role_RoleId",
                table: "UserToRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToRole_Users_UserId",
                table: "UserToRole",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Another_Language_LanguageId",
                table: "Another");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Category_CategoryId",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Language_LanguageId",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_PersonLevel_PersonLevelId",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Category_CategoryId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Language_LanguageId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_PersonLevel_PersonLevelId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_BookToAnother_Another_AnotherId",
                table: "BookToAnother");

            migrationBuilder.DropForeignKey(
                name: "FK_BookToAnother_Book_BookId",
                table: "BookToAnother");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Language_LanguageId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentToBlog_Blog_BlogId",
                table: "CommentToBlog");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentToBook_Book_CommentIdD",
                table: "CommentToBook");

            migrationBuilder.DropForeignKey(
                name: "FK_FileManager_Users_UserId",
                table: "FileManager");

            migrationBuilder.DropForeignKey(
                name: "FK_FileToBlog_Blog_BlogId",
                table: "FileToBlog");

            migrationBuilder.DropForeignKey(
                name: "FK_FileToBlog_FileManager_FileId",
                table: "FileToBlog");

            migrationBuilder.DropForeignKey(
                name: "FK_FileToBook_Book_BookId",
                table: "FileToBook");

            migrationBuilder.DropForeignKey(
                name: "FK_FileToBook_FileManager_FileId",
                table: "FileToBook");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_UserAddress_UserAddressId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Users_UserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Book_BookId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonLevel_Language_LanguageId",
                table: "PersonLevel");

            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Language_LanguageId",
                table: "Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_TagToBlog_Blog_BlogId",
                table: "TagToBlog");

            migrationBuilder.DropForeignKey(
                name: "FK_TagToBlog_Tag_TagId",
                table: "TagToBlog");

            migrationBuilder.DropForeignKey(
                name: "FK_TagToBook_Book_BookId",
                table: "TagToBook");

            migrationBuilder.DropForeignKey(
                name: "FK_TagToBook_Tag_TagId",
                table: "TagToBook");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddress_Users_UserId",
                table: "UserAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToRole_Role_RoleId",
                table: "UserToRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToRole_Users_UserId",
                table: "UserToRole");

            migrationBuilder.DropIndex(
                name: "IX_UserToRole_UserId",
                table: "UserToRole");

            migrationBuilder.DropIndex(
                name: "IX_UserAddress_UserId",
                table: "UserAddress");

            migrationBuilder.DropIndex(
                name: "IX_TagToBook_BookId",
                table: "TagToBook");

            migrationBuilder.DropIndex(
                name: "IX_TagToBlog_TagId",
                table: "TagToBlog");

            migrationBuilder.DropIndex(
                name: "IX_Tag_LanguageId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_PersonLevel_LanguageId",
                table: "PersonLevel");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_BookId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_Order_UserAddressId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_UserId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_FileToBook_FileId",
                table: "FileToBook");

            migrationBuilder.DropIndex(
                name: "IX_FileToBlog_BlogId",
                table: "FileToBlog");

            migrationBuilder.DropIndex(
                name: "IX_FileManager_UserId",
                table: "FileManager");

            migrationBuilder.DropIndex(
                name: "IX_CommentToBlog_BlogId",
                table: "CommentToBlog");

            migrationBuilder.DropIndex(
                name: "IX_Category_LanguageId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_BookToAnother_AnotherId",
                table: "BookToAnother");

            migrationBuilder.DropIndex(
                name: "IX_Book_CategoryId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_LanguageId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_PersonLevelId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Blog_CategoryId",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Blog_LanguageId",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Blog_PersonLevelId",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Another_LanguageId",
                table: "Another");

            migrationBuilder.DropColumn(
                name: "UserAddressId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "PersonLevelId",
                table: "Blog");

            migrationBuilder.RenameColumn(
                name: "CommentIdD",
                table: "CommentToBook",
                newName: "CommentId");

            migrationBuilder.AlterColumn<int>(
                name: "CommentId",
                table: "CommentToBook",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
