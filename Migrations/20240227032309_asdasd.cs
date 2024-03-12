using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZaunShop.Migrations
{
    /// <inheritdoc />
    public partial class asdasd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cartitems_products_ProductId",
                table: "cartitems");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "cartitems",
                newName: "sessionid");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "cartitems",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "cartitems",
                newName: "productid");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "cartitems",
                newName: "datecreated");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "cartitems",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_cartitems_ProductId",
                table: "cartitems",
                newName: "IX_cartitems_productid");

            migrationBuilder.AddForeignKey(
                name: "FK_cartitems_products_productid",
                table: "cartitems",
                column: "productid",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cartitems_products_productid",
                table: "cartitems");

            migrationBuilder.RenameColumn(
                name: "sessionid",
                table: "cartitems",
                newName: "SessionId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "cartitems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "productid",
                table: "cartitems",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "datecreated",
                table: "cartitems",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "cartitems",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_cartitems_productid",
                table: "cartitems",
                newName: "IX_cartitems_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_cartitems_products_ProductId",
                table: "cartitems",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
