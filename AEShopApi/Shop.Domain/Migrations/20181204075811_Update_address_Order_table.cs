using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Domain.Migrations
{
    public partial class Update_address_Order_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingAddress",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "ShippingAddress",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingAddress",
                table: "Orders",
                column: "ShippingAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Wards_ShippingAddress",
                table: "Orders",
                column: "ShippingAddress",
                principalTable: "Wards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Wards_ShippingAddress",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ShippingAddress",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "ShippingAddress",
                table: "Orders",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress",
                table: "Orders",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1543909009, 1543909009 });

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1543909009, 1543909009 });
        }
    }
}
