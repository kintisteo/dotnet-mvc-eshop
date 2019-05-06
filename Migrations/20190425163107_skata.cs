using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EPaper.Migrations
{
    public partial class skata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "33a8e2fc-8b4d-4d00-bd77-1b359ba52df1", "0acf127f-9ca1-4a26-8e19-78b9896a9908" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ff6397e4-1e90-4c22-8d6c-025302ada7ac", "eae24e0c-f4ef-4641-84b8-b145e6b938e3" });

            migrationBuilder.AddColumn<int>(
                name: "Available",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Comics",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Publisher = table.Column<string>(nullable: false),
                    DatePublished = table.Column<DateTime>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Pages = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comics", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Comics_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1bf943b3-51dc-4a0e-b674-8342275c1b11", "44ac9554-85c0-41dd-a6b8-583d240d99e0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8b5e891-86c4-4629-aefe-ed4fc1947470", "2eb336fe-ceb2-460e-a0fc-5fac1637753b", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comics");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1bf943b3-51dc-4a0e-b674-8342275c1b11", "44ac9554-85c0-41dd-a6b8-583d240d99e0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e8b5e891-86c4-4629-aefe-ed4fc1947470", "2eb336fe-ceb2-460e-a0fc-5fac1637753b" });

            migrationBuilder.DropColumn(
                name: "Available",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff6397e4-1e90-4c22-8d6c-025302ada7ac", "eae24e0c-f4ef-4641-84b8-b145e6b938e3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33a8e2fc-8b4d-4d00-bd77-1b359ba52df1", "0acf127f-9ca1-4a26-8e19-78b9896a9908", "User", "USER" });
        }
    }
}
