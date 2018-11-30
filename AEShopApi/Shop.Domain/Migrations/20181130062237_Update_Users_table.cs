using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Domain.Migrations
{
    public partial class Update_Users_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Tags",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Shippings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ShippingProviders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ProductStatusTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ProductCategories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PostTags",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Posts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PostCategories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Payments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "OrderDetails",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "MenuTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Menus",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Footers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Feedbacks",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Discounts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Contacts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Abouts",
                newName: "Id");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "binary(64)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "binary(128)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1543558956, 1543558956 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1543558956, 1543558956 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tags",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Shippings",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ShippingProviders",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductStatusTypes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductCategories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PostTags",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Posts",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PostCategories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Payments",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OrderDetails",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MenuTypes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Menus",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Footers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Feedbacks",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Discounts",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Contacts",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Abouts",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1542879138, 1542879138 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1542879138, 1542879138 });
        }
    }
}
