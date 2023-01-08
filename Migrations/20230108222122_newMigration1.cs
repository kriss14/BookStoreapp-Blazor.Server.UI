using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp_Blazor.Server.UI.Migrations
{
    public partial class newMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                column: "ConcurrencyStamp",
                value: "db79799b-0d8d-45f6-b171-075fd98b5640");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af172c47-fde8-44c4-93b8-fe2e623a592f",
                column: "ConcurrencyStamp",
                value: "e98f1701-c463-43ab-8c40-a5f3ef85c4cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41c6470f-ccb1-42db-954b-c330a72c8b34",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9edf17b8-6278-48c9-8d56-8d3ab1dac6bf", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEPupcu30OnsWzK7RlJ4UeSnlF9RIiysC5Fol8LHnvq83KZISjsKzdTOsPHJdSOumPA==", "1c7e4377-10d7-45d0-a46e-065c3f03c5a2", "admin@bookstore.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b97397ca-7059-4cea-9730-09bfc347cf6a", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEN67QaRWllCjQxL3sXYDMAfy33PT9rlFd/9ZBuLMpMv0jx8Xup5czTn+eFDA0k0+XQ==", "7abf27cf-1f0f-4b17-9ef8-7650347a186f", "user@bookstore.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "25ec8341-5ea2-4342-b1d4-a16f74824d1e", null, "AQAAAAEAACcQAAAAEPbOSZRrsZwCH/8ZquADTbq33iPOxo+oNyudrliGUK0VZMKyLo3smfCvYSeJTUPiIA==", "525e59dc-6d1a-4ebb-8952-ca89ed887e7f", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3acaf025-1181-45be-97b5-dc75687c415b", null, "AQAAAAEAACcQAAAAEI/zekgX9O8DvVZbTtHwn7kCpCQprBBWOHssHbHEnWO+pRe4Rr0UVNoakn42wZYOuw==", "f70d0803-4332-41a7-8b0c-f31599192664", null });
        }
    }
}
