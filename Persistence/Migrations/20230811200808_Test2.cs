using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoxProduct");

            migrationBuilder.AddColumn<int>(
                name: "BoxId",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BoxId",
                table: "Products",
                column: "BoxId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Boxes_BoxId",
                table: "Products",
                column: "BoxId",
                principalTable: "Boxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Boxes_BoxId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BoxId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BoxId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "BoxProduct",
                columns: table => new
                {
                    BoxesId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxProduct", x => new { x.BoxesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_BoxProduct_Boxes_BoxesId",
                        column: x => x.BoxesId,
                        principalTable: "Boxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoxProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoxProduct_ProductsId",
                table: "BoxProduct",
                column: "ProductsId");
        }
    }
}
