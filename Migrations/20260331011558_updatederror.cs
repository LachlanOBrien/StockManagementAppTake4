using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class updatederror : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemLocation_Supplier_SupplierID",
                table: "ItemLocation");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemLocation_Supplier_SupplierID",
                table: "ItemLocation",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemLocation_Supplier_SupplierID",
                table: "ItemLocation");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemLocation_Supplier_SupplierID",
                table: "ItemLocation",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
