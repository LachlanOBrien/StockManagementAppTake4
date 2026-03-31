using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class changedmyrelationshipsforItemModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemItem");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ItemID",
                table: "Order",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemLocation_ItemID",
                table: "ItemLocation",
                column: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemLocation_Item_ItemID",
                table: "ItemLocation",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Item_ItemID",
                table: "Order",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemLocation_Item_ItemID",
                table: "ItemLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Item_ItemID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ItemID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_ItemLocation_ItemID",
                table: "ItemLocation");

            migrationBuilder.CreateTable(
                name: "ItemItem",
                columns: table => new
                {
                    ItemLocationItemID = table.Column<int>(type: "int", nullable: false),
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemItem", x => new { x.ItemLocationItemID, x.OrderItemID });
                    table.ForeignKey(
                        name: "FK_ItemItem_Item_ItemLocationItemID",
                        column: x => x.ItemLocationItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemItem_Item_OrderItemID",
                        column: x => x.OrderItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemItem_OrderItemID",
                table: "ItemItem",
                column: "OrderItemID");
        }
    }
}
