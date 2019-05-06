using Microsoft.EntityFrameworkCore.Migrations;

namespace EPaper.Migrations
{
    public partial class koukos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0b34de09-ceca-4c71-8e34-1c54c12f8280", "cfe4adab-3bc5-4ca7-ab0d-6a6fedf04d64" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2331497e-4be9-4792-8949-f04ffc0a1a97", "16f6d950-270f-4366-953e-71dd606a6ce6" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff6397e4-1e90-4c22-8d6c-025302ada7ac", "eae24e0c-f4ef-4641-84b8-b145e6b938e3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33a8e2fc-8b4d-4d00-bd77-1b359ba52df1", "0acf127f-9ca1-4a26-8e19-78b9896a9908", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "33a8e2fc-8b4d-4d00-bd77-1b359ba52df1", "0acf127f-9ca1-4a26-8e19-78b9896a9908" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ff6397e4-1e90-4c22-8d6c-025302ada7ac", "eae24e0c-f4ef-4641-84b8-b145e6b938e3" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b34de09-ceca-4c71-8e34-1c54c12f8280", "cfe4adab-3bc5-4ca7-ab0d-6a6fedf04d64", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2331497e-4be9-4792-8949-f04ffc0a1a97", "16f6d950-270f-4366-953e-71dd606a6ce6", "User", "USER" });
        }
    }
}
