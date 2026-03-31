using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class AttemptedToFixRelationshipsTake4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemLocation_Supplier_SupplierID",
                table: "ItemLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Supplier_SupplierID",
                table: "Order");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemLocation_Supplier_SupplierID",
                table: "ItemLocation",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
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
                name: "FK_ItemLocation_Supplier_SupplierID",
                table: "ItemLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Supplier_SupplierID",
                table: "Order");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemLocation_Supplier_SupplierID",
                table: "ItemLocation",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
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
