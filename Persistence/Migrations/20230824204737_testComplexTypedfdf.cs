using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class testComplexTypedfdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyClass_Test",
                table: "Warehouses");

            migrationBuilder.CreateTable(
                name: "MyClass",
                columns: table => new
                {
                    WarehouseId = table.Column<int>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Test = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyClass", x => new { x.WarehouseId, x.Id });
                    table.ForeignKey(
                        name: "FK_MyClass_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyClass");

            migrationBuilder.AddColumn<string>(
                name: "MyClass_Test",
                table: "Warehouses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
