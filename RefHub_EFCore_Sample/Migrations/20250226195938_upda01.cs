using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RefHub_EFCore_Sample.Migrations
{
    /// <inheritdoc />
    public partial class upda01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_UserAddress_UserIdAddress",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "UserIdAddress",
                table: "Order",
                newName: "UserAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserIdAddress",
                table: "Order",
                newName: "IX_Order_UserAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_UserAddress_UserAddressId",
                table: "Order",
                column: "UserAddressId",
                principalTable: "UserAddress",
                principalColumn: "UserAddressId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_UserAddress_UserAddressId",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "UserAddressId",
                table: "Order",
                newName: "UserIdAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserAddressId",
                table: "Order",
                newName: "IX_Order_UserIdAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_UserAddress_UserIdAddress",
                table: "Order",
                column: "UserIdAddress",
                principalTable: "UserAddress",
                principalColumn: "UserAddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
