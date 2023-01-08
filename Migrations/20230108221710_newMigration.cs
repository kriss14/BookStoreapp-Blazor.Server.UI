using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp_Blazor.Server.UI.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                column: "ConcurrencyStamp",
                value: "d209992d-d602-4d5c-9607-7996f6905ed9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af172c47-fde8-44c4-93b8-fe2e623a592f",
                column: "ConcurrencyStamp",
                value: "9bd5c2e5-9f18-4119-8816-faaf57eeb80c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41c6470f-ccb1-42db-954b-c330a72c8b34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25ec8341-5ea2-4342-b1d4-a16f74824d1e", "AQAAAAEAACcQAAAAEPbOSZRrsZwCH/8ZquADTbq33iPOxo+oNyudrliGUK0VZMKyLo3smfCvYSeJTUPiIA==", "525e59dc-6d1a-4ebb-8952-ca89ed887e7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3acaf025-1181-45be-97b5-dc75687c415b", "AQAAAAEAACcQAAAAEI/zekgX9O8DvVZbTtHwn7kCpCQprBBWOHssHbHEnWO+pRe4Rr0UVNoakn42wZYOuw==", "f70d0803-4332-41a7-8b0c-f31599192664" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
