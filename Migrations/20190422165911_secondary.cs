using Microsoft.EntityFrameworkCore.Migrations;

namespace EPaper.Migrations
{
    public partial class secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4a6f5e1a-4a39-476a-b2f2-d5dce028c320", "7373b497-053e-4c89-8e0a-ab3ac3b0986e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7bcb0d2c-d6be-4f04-9835-764c96c0016a", "7292fd4a-c86a-4684-93f6-b546d019e601" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c75df0d-83b0-4db0-b318-2902246d989d", "51d56f22-8ac6-4391-a6cb-10ac0f0cb03e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f5181fd-3f54-4056-b550-ad04e50c63de", "929dd502-edcb-4be3-875d-5ecbe1b323fb", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0f5181fd-3f54-4056-b550-ad04e50c63de", "929dd502-edcb-4be3-875d-5ecbe1b323fb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3c75df0d-83b0-4db0-b318-2902246d989d", "51d56f22-8ac6-4391-a6cb-10ac0f0cb03e" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a6f5e1a-4a39-476a-b2f2-d5dce028c320", "7373b497-053e-4c89-8e0a-ab3ac3b0986e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bcb0d2c-d6be-4f04-9835-764c96c0016a", "7292fd4a-c86a-4684-93f6-b546d019e601", "User", "USER" });
        }
    }
}
