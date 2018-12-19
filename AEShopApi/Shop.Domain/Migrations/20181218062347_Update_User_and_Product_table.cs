using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Domain.Migrations
{
    public partial class Update_User_and_Product_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545114225, 1545114225 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545114225, 1545114225 });

            migrationBuilder.InsertData(
                table: "ProductStatusTypes",
                columns: new[] { "Id", "InsertedAt", "Name", "UpdatedAt" },
                values: new object[] { 3, 1545114225, "Removed", 1545114225 });

            migrationBuilder.InsertData(
                table: "UserStatusTypes",
                columns: new[] { "Id", "InsertedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1545114225, "Deactivated", 1545114225 },
                    { 2, 1545114225, "Activated", 1545114225 },
                    { 3, 1545114225, "Removed", 1545114225 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1543910290, 1543910290 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1543910290, 1543910290 });
        }
    }
}
