using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class kiddfdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CellId",
                table: "Cell");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Cell");

            migrationBuilder.DropColumn(
                name: "Line",
                table: "Cell");

            migrationBuilder.DropColumn(
                name: "Rack",
                table: "Cell");

            migrationBuilder.DropColumn(
                name: "Zone",
                table: "Cell");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Rack",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "CellId",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CellId",
                table: "Boxes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CellId",
                table: "Products",
                column: "CellId");

            migrationBuilder.CreateIndex(
                name: "IX_Boxes_CellId",
                table: "Boxes",
                column: "CellId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boxes_Cell_CellId",
                table: "Boxes",
                column: "CellId",
                principalTable: "Cell",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Cell_CellId",
                table: "Products",
                column: "CellId",
                principalTable: "Cell",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boxes_Cell_CellId",
                table: "Boxes");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Cell_CellId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CellId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Boxes_CellId",
                table: "Boxes");

            migrationBuilder.DropColumn(
                name: "CellId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CellId",
                table: "Boxes");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Rack",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "CellId",
                table: "Cell",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Cell",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Line",
                table: "Cell",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rack",
                table: "Cell",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Zone",
                table: "Cell",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
