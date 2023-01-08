using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp_Blazor.Server.UI.Migrations
{
    public partial class seededDefaultUsersAndRoles1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                column: "ConcurrencyStamp",
                value: "af3d2bcc-15b4-4480-a8a7-f9cf65f7654a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af172c47-fde8-44c4-93b8-fe2e623a592f",
                column: "ConcurrencyStamp",
                value: "f0316396-59ba-434a-9111-d0346dbc1093");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41c6470f-ccb1-42db-954b-c330a72c8b34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc12212d-f4a6-415d-982d-fd3e1285a5b0", "AQAAAAEAACcQAAAAECdP/g9WmnDaaItvm0zaqe2EDUIOdyWozRqaXJPgKw+CV/FOSzXka0XyE7OUlVzrtw==", "6e8ab0d9-a321-4aba-bd9e-bdba5c055e9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a52f4182-1561-40ce-88df-194866f27cfd", "AQAAAAEAACcQAAAAEC3fOUWhc0v6/wZ7KJF3+N6013h17rdzyK1tDRJ0m9dwyOI2AOaBESw+4PvV9GUqQg==", "25855003-2760-4697-be4f-3414ffe43078" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                column: "ConcurrencyStamp",
                value: "2fb9c907-aae9-49d4-9e01-14ce9121b33b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af172c47-fde8-44c4-93b8-fe2e623a592f",
                column: "ConcurrencyStamp",
                value: "817d9daf-756d-4b3a-a4e0-2922e9acb7f2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41c6470f-ccb1-42db-954b-c330a72c8b34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b4b6226-4bbd-46b5-9b7c-387af91f8456", "AQAAAAEAACcQAAAAEG/zgXKri5YNGxJ8k/PVc4GthR9vj8/V0KBRSrcynDtYzm8FYad6psVERlMkwfgfCg==", "58138a7a-7dde-41da-9171-0201efa5d695" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb202157-ee2e-462e-b2bf-e2a76a6565dd", "AQAAAAEAACcQAAAAEICti57pYvNzhTj6V2PpmMvs2MgldbqT/beMXJTTS5/8CsxVetMunBo0A7618wnbSw==", "e4ade6c1-64c5-447e-88e4-05a86c21a03e" });
        }
    }
}
