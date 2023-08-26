using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _99494 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boxes_Warehouses_WarehouseId",
                table: "Boxes");

            migrationBuilder.DropForeignKey(
                name: "FK_Card_Warehouses_WarehouseId",
                table: "Card");

            migrationBuilder.DropIndex(
                name: "IX_Card_WarehouseId",
                table: "Card");

            migrationBuilder.DropIndex(
                name: "IX_Boxes_WarehouseId",
                table: "Boxes");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Boxes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WarehouseId",
                table: "Card",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseId",
                table: "Boxes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Card_WarehouseId",
                table: "Card",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Boxes_WarehouseId",
                table: "Boxes",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boxes_Warehouses_WarehouseId",
                table: "Boxes",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Warehouses_WarehouseId",
                table: "Card",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id");
        }
    }
}
