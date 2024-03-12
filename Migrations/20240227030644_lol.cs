using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZaunShop.Migrations
{
    /// <inheritdoc />
    public partial class lol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cartItems_products_ProductId",
                table: "cartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_paymentDetails_PaymentDetailId",
                table: "orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_users_UserId",
                table: "orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orderItems_orderDetails_OrderDetailId",
                table: "orderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_orderItems_products_ProductId",
                table: "orderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_paymentDetails",
                table: "paymentDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderItems",
                table: "orderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cartItems",
                table: "cartItems");

            migrationBuilder.RenameTable(
                name: "paymentDetails",
                newName: "paymentdetails");

            migrationBuilder.RenameTable(
                name: "orderItems",
                newName: "orderitems");

            migrationBuilder.RenameTable(
                name: "orderDetails",
                newName: "orderdetails");

            migrationBuilder.RenameTable(
                name: "cartItems",
                newName: "cartitems");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "users",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "users",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "users",
                newName: "firstname");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "products",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "products",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "products",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "products",
                newName: "categoryid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "products",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_products_CategoryId",
                table: "products",
                newName: "IX_products_categoryid");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "paymentdetails",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "paymentdetails",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "orderitems",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "orderitems",
                newName: "productid");

            migrationBuilder.RenameColumn(
                name: "OrderItemPrice",
                table: "orderitems",
                newName: "orderitemprice");

            migrationBuilder.RenameColumn(
                name: "OrderDetailId",
                table: "orderitems",
                newName: "orderdetailid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "orderitems",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_orderItems_ProductId",
                table: "orderitems",
                newName: "IX_orderitems_productid");

            migrationBuilder.RenameIndex(
                name: "IX_orderItems_OrderDetailId",
                table: "orderitems",
                newName: "IX_orderitems_orderdetailid");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "orderdetails",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "orderdetails",
                newName: "total");

            migrationBuilder.RenameColumn(
                name: "PaymentDetailId",
                table: "orderdetails",
                newName: "paymentdetailid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "orderdetails",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetails_UserId",
                table: "orderdetails",
                newName: "IX_orderdetails_userid");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetails_PaymentDetailId",
                table: "orderdetails",
                newName: "IX_orderdetails_paymentdetailid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "categories",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_cartItems_ProductId",
                table: "cartitems",
                newName: "IX_cartitems_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_paymentdetails",
                table: "paymentdetails",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderitems",
                table: "orderitems",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderdetails",
                table: "orderdetails",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cartitems",
                table: "cartitems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_cartitems_products_ProductId",
                table: "cartitems",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderdetails_paymentdetails_paymentdetailid",
                table: "orderdetails",
                column: "paymentdetailid",
                principalTable: "paymentdetails",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderdetails_users_userid",
                table: "orderdetails",
                column: "userid",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderitems_orderdetails_orderdetailid",
                table: "orderitems",
                column: "orderdetailid",
                principalTable: "orderdetails",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderitems_products_productid",
                table: "orderitems",
                column: "productid",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_categoryid",
                table: "products",
                column: "categoryid",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cartitems_products_ProductId",
                table: "cartitems");

            migrationBuilder.DropForeignKey(
                name: "FK_orderdetails_paymentdetails_paymentdetailid",
                table: "orderdetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orderdetails_users_userid",
                table: "orderdetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orderitems_orderdetails_orderdetailid",
                table: "orderitems");

            migrationBuilder.DropForeignKey(
                name: "FK_orderitems_products_productid",
                table: "orderitems");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_categoryid",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_paymentdetails",
                table: "paymentdetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderitems",
                table: "orderitems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderdetails",
                table: "orderdetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cartitems",
                table: "cartitems");

            migrationBuilder.RenameTable(
                name: "paymentdetails",
                newName: "paymentDetails");

            migrationBuilder.RenameTable(
                name: "orderitems",
                newName: "orderItems");

            migrationBuilder.RenameTable(
                name: "orderdetails",
                newName: "orderDetails");

            migrationBuilder.RenameTable(
                name: "cartitems",
                newName: "cartItems");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "users",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstname",
                table: "users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "categoryid",
                table: "products",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "products",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_products_categoryid",
                table: "products",
                newName: "IX_products_CategoryId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "paymentDetails",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "paymentDetails",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "orderItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "productid",
                table: "orderItems",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "orderitemprice",
                table: "orderItems",
                newName: "OrderItemPrice");

            migrationBuilder.RenameColumn(
                name: "orderdetailid",
                table: "orderItems",
                newName: "OrderDetailId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "orderItems",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_orderitems_productid",
                table: "orderItems",
                newName: "IX_orderItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_orderitems_orderdetailid",
                table: "orderItems",
                newName: "IX_orderItems_OrderDetailId");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "orderDetails",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "total",
                table: "orderDetails",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "paymentdetailid",
                table: "orderDetails",
                newName: "PaymentDetailId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "orderDetails",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_orderdetails_userid",
                table: "orderDetails",
                newName: "IX_orderDetails_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_orderdetails_paymentdetailid",
                table: "orderDetails",
                newName: "IX_orderDetails_PaymentDetailId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "categories",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_cartitems_ProductId",
                table: "cartItems",
                newName: "IX_cartItems_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_paymentDetails",
                table: "paymentDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderItems",
                table: "orderItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cartItems",
                table: "cartItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_cartItems_products_ProductId",
                table: "cartItems",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_paymentDetails_PaymentDetailId",
                table: "orderDetails",
                column: "PaymentDetailId",
                principalTable: "paymentDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_users_UserId",
                table: "orderDetails",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderItems_orderDetails_OrderDetailId",
                table: "orderItems",
                column: "OrderDetailId",
                principalTable: "orderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderItems_products_ProductId",
                table: "orderItems",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
