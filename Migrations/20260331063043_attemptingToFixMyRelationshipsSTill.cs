using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class attemptingToFixMyRelationshipsSTill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Supplier_SupplierID",
                table: "Order");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Supplier_SupplierID",
                table: "Order",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Supplier_SupplierID",
                table: "Order");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Supplier_SupplierID",
                table: "Order",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
