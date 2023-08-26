using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class testComplexTypedfdffgyy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyClass_Warehouses_WarehouseId",
                table: "MyClass");

            migrationBuilder.RenameColumn(
                name: "WarehouseId",
                table: "MyClass",
                newName: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyClass_Card_CardId",
                table: "MyClass",
                column: "CardId",
                principalTable: "Card",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyClass_Card_CardId",
                table: "MyClass");

            migrationBuilder.RenameColumn(
                name: "CardId",
                table: "MyClass",
                newName: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyClass_Warehouses_WarehouseId",
                table: "MyClass",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
