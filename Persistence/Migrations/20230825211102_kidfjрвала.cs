using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class kidfjрвала : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cell_Module_RackId",
                table: "Cell");

            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.RenameColumn(
                name: "RackId",
                table: "Cell",
                newName: "StorageRackId");

            migrationBuilder.RenameIndex(
                name: "IX_Cell_RackId",
                table: "Cell",
                newName: "IX_Cell_StorageRackId");

            migrationBuilder.CreateTable(
                name: "StorageRack",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    WarehouseId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageRack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorageRack_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StorageRack_WarehouseId",
                table: "StorageRack",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cell_StorageRack_StorageRackId",
                table: "Cell",
                column: "StorageRackId",
                principalTable: "StorageRack",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cell_StorageRack_StorageRackId",
                table: "Cell");

            migrationBuilder.DropTable(
                name: "StorageRack");

            migrationBuilder.RenameColumn(
                name: "StorageRackId",
                table: "Cell",
                newName: "RackId");

            migrationBuilder.RenameIndex(
                name: "IX_Cell_StorageRackId",
                table: "Cell",
                newName: "IX_Cell_RackId");

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    WarehouseId = table.Column<int>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Module_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Module_WarehouseId",
                table: "Module",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cell_Module_RackId",
                table: "Cell",
                column: "RackId",
                principalTable: "Module",
                principalColumn: "Id");
        }
    }
}
