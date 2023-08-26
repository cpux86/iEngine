using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class djhfis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cell_Warehouses_WarehouseId",
                table: "Cell");

            migrationBuilder.RenameColumn(
                name: "WarehouseId",
                table: "Cell",
                newName: "RackId");

            migrationBuilder.RenameIndex(
                name: "IX_Cell_WarehouseId",
                table: "Cell",
                newName: "IX_Cell_RackId");

            migrationBuilder.CreateTable(
                name: "Rack",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    WarehouseId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rack_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rack_WarehouseId",
                table: "Rack",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cell_Rack_RackId",
                table: "Cell",
                column: "RackId",
                principalTable: "Rack",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cell_Rack_RackId",
                table: "Cell");

            migrationBuilder.DropTable(
                name: "Rack");

            migrationBuilder.RenameColumn(
                name: "RackId",
                table: "Cell",
                newName: "WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Cell_RackId",
                table: "Cell",
                newName: "IX_Cell_WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cell_Warehouses_WarehouseId",
                table: "Cell",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id");
        }
    }
}
