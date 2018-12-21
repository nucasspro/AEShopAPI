using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Domain.Migrations
{
    public partial class Remove_ParentId_of_Category_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ParentId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "CategoryStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545362357, 1545362357 });

            migrationBuilder.UpdateData(
                table: "CategoryStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545362357, 1545362357 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545362357, 1545362357 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545362357, 1545362357 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545362357, 1545362357 });

            migrationBuilder.UpdateData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545362357, 1545362357 });

            migrationBuilder.UpdateData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545362357, 1545362357 });

            migrationBuilder.UpdateData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545362357, 1545362357 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CategoryStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545273916, 1545273916 });

            migrationBuilder.UpdateData(
                table: "CategoryStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545273916, 1545273916 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545273916, 1545273916 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545273916, 1545273916 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545273916, 1545273916 });

            migrationBuilder.UpdateData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545273916, 1545273916 });

            migrationBuilder.UpdateData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545273916, 1545273916 });

            migrationBuilder.UpdateData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545273916, 1545273916 });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentId",
                table: "Categories",
                column: "ParentId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
