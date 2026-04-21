using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedTheOrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Item_ItemID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Location_LocationID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Supplier_SupplierID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderName",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "QuantityOrdered",
                table: "Order");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierID",
                table: "Order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LocationID",
                table: "Order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ItemID",
                table: "Order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    OrderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    QuantityOrdered = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.OrderItemID);
                    table.ForeignKey(
                        name: "FK_OrderItem_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ItemID",
                table: "OrderItem",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Item_ItemID",
                table: "Order",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Location_LocationID",
                table: "Order",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Supplier_SupplierID",
                table: "Order",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Item_ItemID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Location_LocationID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Supplier_SupplierID",
                table: "Order");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierID",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocationID",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemID",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderName",
                table: "Order",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "QuantityOrdered",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Item_ItemID",
                table: "Order",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Location_LocationID",
                table: "Order",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Supplier_SupplierID",
                table: "Order",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
