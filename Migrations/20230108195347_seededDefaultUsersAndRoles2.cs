using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp_Blazor.Server.UI.Migrations
{
    public partial class seededDefaultUsersAndRoles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                column: "ConcurrencyStamp",
                value: "e5d8974f-e3e1-4b7f-9412-861da997190a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af172c47-fde8-44c4-93b8-fe2e623a592f",
                column: "ConcurrencyStamp",
                value: "5da89e73-78e3-4ef2-b1ef-9b197210227e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41c6470f-ccb1-42db-954b-c330a72c8b34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "393b6da7-38f2-4fdf-8bc7-5e2af718ab10", "AQAAAAEAACcQAAAAEKQZv5J3FLRYmgEPm5y1g/hs1NSKYpz778v/oumBV/l96FEyGxLZQxU41DlFmwG3oA==", "890d624c-5738-4737-aecd-903864f83b7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2af48f14-2ba7-4e60-b042-761d5b42d900", "AQAAAAEAACcQAAAAEL+Yeyq+/u6rtBQDY7pMcfYmvHVxYCTETbglgRBHD4YI93Kyo1BNi9dCJg9+6n53vw==", "d163a70c-d54e-4487-95fb-b70db0463c87" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
