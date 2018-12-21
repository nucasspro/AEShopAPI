using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Domain.Migrations
{
    public partial class Update_Category_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_CategoryStatusTypes_CategoryStatusTypeId",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryStatusTypeId",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CategoryStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545389342, 1545389342 });

            migrationBuilder.UpdateData(
                table: "CategoryStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545389342, 1545389342 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545389343, 1545389343 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545389343, 1545389343 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545389343, 1545389343 });

            migrationBuilder.UpdateData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545389343, 1545389343 });

            migrationBuilder.UpdateData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545389343, 1545389343 });

            migrationBuilder.UpdateData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545389343, 1545389343 });

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_CategoryStatusTypes_CategoryStatusTypeId",
                table: "Categories",
                column: "CategoryStatusTypeId",
                principalTable: "CategoryStatusTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_CategoryStatusTypes_CategoryStatusTypeId",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryStatusTypeId",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_CategoryStatusTypes_CategoryStatusTypeId",
                table: "Categories",
                column: "CategoryStatusTypeId",
                principalTable: "CategoryStatusTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
