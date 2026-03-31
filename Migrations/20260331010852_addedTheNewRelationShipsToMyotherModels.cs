using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class addedTheNewRelationShipsToMyotherModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationLocation");

            migrationBuilder.CreateIndex(
                name: "IX_Order_LocationID",
                table: "Order",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_SupplierID",
                table: "Order",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemLocation_LocationID",
                table: "ItemLocation",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemLocation_SupplierID",
                table: "ItemLocation",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SupplierID",
                table: "Item",
                column: "SupplierID");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Supplier_SupplierID",
                table: "Item",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemLocation_Location_LocationID",
                table: "ItemLocation",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemLocation_Supplier_SupplierID",
                table: "ItemLocation",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Location_LocationID",
                table: "Order",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Supplier_SupplierID",
                table: "Order",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Supplier_SupplierID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemLocation_Location_LocationID",
                table: "ItemLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemLocation_Supplier_SupplierID",
                table: "ItemLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Location_LocationID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Supplier_SupplierID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_LocationID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_SupplierID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_ItemLocation_LocationID",
                table: "ItemLocation");

            migrationBuilder.DropIndex(
                name: "IX_ItemLocation_SupplierID",
                table: "ItemLocation");

            migrationBuilder.DropIndex(
                name: "IX_Item_SupplierID",
                table: "Item");

            migrationBuilder.CreateTable(
                name: "LocationLocation",
                columns: table => new
                {
                    ItemLocationsLocationID = table.Column<int>(type: "int", nullable: false),
                    OrdersLocationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationLocation", x => new { x.ItemLocationsLocationID, x.OrdersLocationID });
                    table.ForeignKey(
                        name: "FK_LocationLocation_Location_ItemLocationsLocationID",
                        column: x => x.ItemLocationsLocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationLocation_Location_OrdersLocationID",
                        column: x => x.OrdersLocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocationLocation_OrdersLocationID",
                table: "LocationLocation",
                column: "OrdersLocationID");
        }
    }
}
