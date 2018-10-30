using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Domain.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    InsertedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sku = table.Column<string>(type: "varchar(16)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    RegularPrice = table.Column<int>(type: "int", nullable: false),
                    DiscountPrice = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "InsertedAt", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1540884043, "Category001", 1, 1540884043 },
                    { 2, 1540884043, "Category002", 1, 1540884043 },
                    { 3, 1540884043, "Category003", 2, 1540884043 },
                    { 4, 1540884043, "Category004", 2, 1540884043 },
                    { 5, 1540884043, "Category005", 1, 1540884043 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DiscountPrice", "InsertedAt", "Name", "Quantity", "RegularPrice", "Sku", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "DescriptionDescriptionDescriptionDescription", 100000, 1540884043, "Product001", 10, 100000, "PD001", 1540884043 },
                    { 2, "DescriptionDescriptionDescriptionDescription", 10000, 1540884043, "Product002", 10, 10000, "PD002", 1540884043 },
                    { 3, "DescriptionDescriptionDescriptionDescription", 1000, 1540884043, "Product003", 10, 1000, "PD003", 1540884043 },
                    { 4, "DescriptionDescriptionDescriptionDescription", 100, 1540884043, "Product004", 10, 100, "PD004", 1540884043 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductId", "CategoryId", "InsertedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, 1540884043, 1540884043 },
                    { 2, 1, 1540884043, 1540884043 },
                    { 3, 2, 1540884043, 1540884043 },
                    { 4, 4, 1540884043, 1540884043 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
