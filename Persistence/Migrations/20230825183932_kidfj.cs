using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class kidfj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cell_Rack_RackId",
                table: "Cell");

            migrationBuilder.DropForeignKey(
                name: "FK_Rack_Склад_WarehouseId",
                table: "Rack");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rack",
                table: "Rack");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Склад",
                table: "Склад");

            migrationBuilder.RenameTable(
                name: "Rack",
                newName: "Module");

            migrationBuilder.RenameTable(
                name: "Склад",
                newName: "Warehouses");

            migrationBuilder.RenameIndex(
                name: "IX_Rack_WarehouseId",
                table: "Module",
                newName: "IX_Module_WarehouseId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Module",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Module",
                table: "Module",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cell_Module_RackId",
                table: "Cell",
                column: "RackId",
                principalTable: "Module",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Module_Warehouses_WarehouseId",
                table: "Module",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cell_Module_RackId",
                table: "Cell");

            migrationBuilder.DropForeignKey(
                name: "FK_Module_Warehouses_WarehouseId",
                table: "Module");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Module",
                table: "Module");

            migrationBuilder.RenameTable(
                name: "Warehouses",
                newName: "Склад");

            migrationBuilder.RenameTable(
                name: "Module",
                newName: "Rack");

            migrationBuilder.RenameIndex(
                name: "IX_Module_WarehouseId",
                table: "Rack",
                newName: "IX_Rack_WarehouseId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Rack",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Склад",
                table: "Склад",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rack",
                table: "Rack",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cell_Rack_RackId",
                table: "Cell",
                column: "RackId",
                principalTable: "Rack",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rack_Склад_WarehouseId",
                table: "Rack",
                column: "WarehouseId",
                principalTable: "Склад",
                principalColumn: "Id");
        }
    }
}
