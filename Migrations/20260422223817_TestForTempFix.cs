using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class TestForTempFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Location_LocationID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Order_OrderID1",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_LocationID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_OrderID1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderID1",
                table: "Order");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderID1",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_LocationID",
                table: "Order",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderID1",
                table: "Order",
                column: "OrderID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Location_LocationID",
                table: "Order",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Order_OrderID1",
                table: "Order",
                column: "OrderID1",
                principalTable: "Order",
                principalColumn: "OrderID");
        }
    }
}
