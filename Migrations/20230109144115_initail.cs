using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp_Blazor.Server.UI.Migrations
{
    public partial class initail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                column: "ConcurrencyStamp",
                value: "e6a33dd4-72b8-4b03-be9d-2e6d36108d2a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af172c47-fde8-44c4-93b8-fe2e623a592f",
                column: "ConcurrencyStamp",
                value: "2d1ea12e-d7c0-4a83-9893-f720a9d21e5b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41c6470f-ccb1-42db-954b-c330a72c8b34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20c34d23-d6fb-471b-9bde-75cefa799402", "AQAAAAEAACcQAAAAEPwgLvkMm2Am02iXWeo2gPJyFAfWvGW9VVyBWghz6gFWg3sgYzROLZZ7EsXUlqvhtQ==", "e3a03974-0547-4104-a6e8-39db4fadfe2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efc400e2-51a1-40b0-bc88-c6583ae7de5b", "AQAAAAEAACcQAAAAEJ5gDUE1eZJeiWwpBUY5hpjMw06UsRndVp+hBChw/ZNiAxAftv7ngCP9f8qx6ypYkw==", "38a895cd-3f2d-41fd-b0b9-e171bfdce4b0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9edf17b8-6278-48c9-8d56-8d3ab1dac6bf", "AQAAAAEAACcQAAAAEPupcu30OnsWzK7RlJ4UeSnlF9RIiysC5Fol8LHnvq83KZISjsKzdTOsPHJdSOumPA==", "1c7e4377-10d7-45d0-a46e-065c3f03c5a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b97397ca-7059-4cea-9730-09bfc347cf6a", "AQAAAAEAACcQAAAAEN67QaRWllCjQxL3sXYDMAfy33PT9rlFd/9ZBuLMpMv0jx8Xup5czTn+eFDA0k0+XQ==", "7abf27cf-1f0f-4b17-9ef8-7650347a186f" });
        }
    }
}
