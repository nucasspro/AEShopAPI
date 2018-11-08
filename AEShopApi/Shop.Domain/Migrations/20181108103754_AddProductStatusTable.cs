using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Domain.Migrations
{
    public partial class AddProductStatusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "Sku",
                table: "Products",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(16)");

            migrationBuilder.AlterColumn<double>(
                name: "RegularPrice",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiscountId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Products",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Products",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Products",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Products",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Length",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductStatusId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "PromotionPrice",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Width",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(200)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiscountId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Categories",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "varchar(20)", nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Phone = table.Column<string>(type: "varchar(15)", nullable: false),
                    AdminImage = table.Column<string>(type: "varchar(100)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    IsActice = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "varchar(20)", nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Phone = table.Column<string>(type: "varchar(15)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UserImage = table.Column<string>(type: "varchar(100)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    IsActice = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProductStatusTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStatusTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingProviders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingProviders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DiscountValue = table.Column<double>(type: "float", nullable: false),
                    MaximumDiscount = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    StartedTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ExpriredTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CouponCode = table.Column<string>(type: "varchar(15)", nullable: false),
                    IsRedeem = table.Column<bool>(type: "bit", nullable: false),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Discounts_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shippings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false),
                    ShippingCode = table.Column<string>(type: "varchar(20)", nullable: false),
                    ShippingPrice = table.Column<double>(type: "float", nullable: false),
                    ShippingStatus = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ProviderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippings", x => x.id);
                    table.ForeignKey(
                        name: "FK_Shippings_ShippingProviders_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "ShippingProviders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false),
                    OrderCode = table.Column<string>(type: "varchar(20)", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: true),
                    GrandTotal = table.Column<double>(type: "float", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IsVerify = table.Column<bool>(type: "bit", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    BillingAddress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ShippingId = table.Column<int>(type: "int", nullable: false),
                    PackageWidth = table.Column<double>(type: "float", nullable: true),
                    PackageHeight = table.Column<double>(type: "float", nullable: true),
                    PackageLength = table.Column<double>(type: "float", nullable: true),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Payments_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "Payments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Shippings_ShippingId",
                        column: x => x.ShippingId,
                        principalTable: "Shippings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductStatusTypes",
                columns: new[] { "id", "InsertedAt", "Name", "UpdatedAt" },
                values: new object[] { 1, 1541673472, "Out of stock", 1541673472 });

            migrationBuilder.InsertData(
                table: "ProductStatusTypes",
                columns: new[] { "id", "InsertedAt", "Name", "UpdatedAt" },
                values: new object[] { 2, 1541673472, "Stock", 1541673472 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AdminId",
                table: "Products",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DiscountId",
                table: "Products",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductStatusId",
                table: "Products",
                column: "ProductStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_AdminId",
                table: "Categories",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DiscountId",
                table: "Categories",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_AdminId",
                table: "Discounts",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentMethodId",
                table: "Orders",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingId",
                table: "Orders",
                column: "ShippingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shippings_ProviderId",
                table: "Shippings",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Admins_AdminId",
                table: "Categories",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Discounts_DiscountId",
                table: "Categories",
                column: "DiscountId",
                principalTable: "Discounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentId",
                table: "Categories",
                column: "ParentId",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Admins_AdminId",
                table: "Products",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Discounts_DiscountId",
                table: "Products",
                column: "DiscountId",
                principalTable: "Discounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductStatusTypes_ProductStatusId",
                table: "Products",
                column: "ProductStatusId",
                principalTable: "ProductStatusTypes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Admins_AdminId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Discounts_DiscountId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Admins_AdminId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Discounts_DiscountId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductStatusTypes_ProductStatusId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductStatusTypes");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Shippings");

            migrationBuilder.DropTable(
                name: "ShippingProviders");

            migrationBuilder.DropIndex(
                name: "IX_Products_AdminId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_DiscountId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductStatusId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Categories_AdminId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_DiscountId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ParentId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DiscountId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductStatusId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PromotionPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DiscountId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Products",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Sku",
                table: "Products",
                type: "varchar(16)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<int>(
                name: "RegularPrice",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiscountPrice",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
