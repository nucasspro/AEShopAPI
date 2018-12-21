using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Domain.Migrations
{
    public partial class Add_CategoryStatusType_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryStatusTypeId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryStatusTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryStatusTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CategoryStatusTypes",
                columns: new[] { "Id", "InsertedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1545273916, "Actived", 1545273916 },
                    { 2, 1545273916, "Removed", 1545273916 }
                });

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
                name: "IX_Categories_CategoryStatusTypeId",
                table: "Categories",
                column: "CategoryStatusTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_CategoryStatusTypes_CategoryStatusTypeId",
                table: "Categories",
                column: "CategoryStatusTypeId",
                principalTable: "CategoryStatusTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_CategoryStatusTypes_CategoryStatusTypeId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "CategoryStatusTypes");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryStatusTypeId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryStatusTypeId",
                table: "Categories");

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

            migrationBuilder.UpdateData(
                table: "ProductStatusTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545114225, 1545114225 });

            migrationBuilder.UpdateData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545114225, 1545114225 });

            migrationBuilder.UpdateData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545114225, 1545114225 });

            migrationBuilder.UpdateData(
                table: "UserStatusTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertedAt", "UpdatedAt" },
                values: new object[] { 1545114225, 1545114225 });
        }
    }
}
