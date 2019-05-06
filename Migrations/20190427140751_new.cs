using Microsoft.EntityFrameworkCore.Migrations;

namespace EPaper.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1bf943b3-51dc-4a0e-b674-8342275c1b11", "44ac9554-85c0-41dd-a6b8-583d240d99e0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e8b5e891-86c4-4629-aefe-ed4fc1947470", "2eb336fe-ceb2-460e-a0fc-5fac1637753b" });

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f6ec96b-c60b-4be2-864b-9ee907cb706a", "1176c52f-7487-42c6-af21-37ed7a141dd3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f09def87-b286-48e4-b822-dee286a7a26f", "a85246cb-f2e9-4ebf-9f8c-b7256d129945", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9f6ec96b-c60b-4be2-864b-9ee907cb706a", "1176c52f-7487-42c6-af21-37ed7a141dd3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f09def87-b286-48e4-b822-dee286a7a26f", "a85246cb-f2e9-4ebf-9f8c-b7256d129945" });

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Products",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1bf943b3-51dc-4a0e-b674-8342275c1b11", "44ac9554-85c0-41dd-a6b8-583d240d99e0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8b5e891-86c4-4629-aefe-ed4fc1947470", "2eb336fe-ceb2-460e-a0fc-5fac1637753b", "User", "USER" });
        }
    }
}
