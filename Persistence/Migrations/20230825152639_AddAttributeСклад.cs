using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddAttributeСклад : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rack_Warehouses_WarehouseId",
                table: "Rack");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses");

            migrationBuilder.RenameTable(
                name: "Warehouses",
                newName: "Склад");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Rack",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Склад",
                table: "Склад",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rack_Склад_WarehouseId",
                table: "Rack",
                column: "WarehouseId",
                principalTable: "Склад",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rack_Склад_WarehouseId",
                table: "Rack");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Склад",
                table: "Склад");

            migrationBuilder.RenameTable(
                name: "Склад",
                newName: "Warehouses");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Rack",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rack_Warehouses_WarehouseId",
                table: "Rack",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id");
        }
    }
}
