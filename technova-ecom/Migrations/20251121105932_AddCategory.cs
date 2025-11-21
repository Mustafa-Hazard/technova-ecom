using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace technova_ecom.Migrations
{
    /// <inheritdoc />
    public partial class AddCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "product_id");

            migrationBuilder.RenameColumn(
                name: "StockQuantity",
                table: "Products",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Products",
                newName: "category_id");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "stock_price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "product_name");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    display_order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.category_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_category_id",
                table: "Products",
                column: "category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_category_id",
                table: "Products",
                column: "category_id",
                principalTable: "Category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_category_id",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Products_category_id",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "stock_price",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Products",
                newName: "StockQuantity");

            migrationBuilder.RenameColumn(
                name: "product_name",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "Products",
                newName: "Rating");
        }
    }
}
