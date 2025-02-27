using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RefHub_EFCore_Sample.Migrations
{
    /// <inheritdoc />
    public partial class AddRelAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_UserAddress_UserAddressId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_UserAddressId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UserAddressId",
                table: "Order");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserIdAddress",
                table: "Order",
                column: "UserIdAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_UserAddress_UserIdAddress",
                table: "Order",
                column: "UserIdAddress",
                principalTable: "UserAddress",
                principalColumn: "UserAddressId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_UserAddress_UserIdAddress",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_UserIdAddress",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "UserAddressId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserAddressId",
                table: "Order",
                column: "UserAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_UserAddress_UserAddressId",
                table: "Order",
                column: "UserAddressId",
                principalTable: "UserAddress",
                principalColumn: "UserAddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
