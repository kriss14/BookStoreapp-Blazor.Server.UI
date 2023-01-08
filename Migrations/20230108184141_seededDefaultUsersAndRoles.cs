using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp_Blazor.Server.UI.Migrations
{
    public partial class seededDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8a51b850-3ad5-4998-92dc-581ec43eb234", "2fb9c907-aae9-49d4-9e01-14ce9121b33b", "Administrator", "ADMINISTRATOR" },
                    { "af172c47-fde8-44c4-93b8-fe2e623a592f", "817d9daf-756d-4b3a-a4e0-2922e9acb7f2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "41c6470f-ccb1-42db-954b-c330a72c8b34", 0, "8b4b6226-4bbd-46b5-9b7c-387af91f8456", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", null, "AQAAAAEAACcQAAAAEG/zgXKri5YNGxJ8k/PVc4GthR9vj8/V0KBRSrcynDtYzm8FYad6psVERlMkwfgfCg==", null, false, "58138a7a-7dde-41da-9171-0201efa5d695", false, null },
                    { "8a51b850-3ad5-4998-92dc-581ec43eb234", 0, "cb202157-ee2e-462e-b2bf-e2a76a6565dd", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", null, "AQAAAAEAACcQAAAAEICti57pYvNzhTj6V2PpmMvs2MgldbqT/beMXJTTS5/8CsxVetMunBo0A7618wnbSw==", null, false, "e4ade6c1-64c5-447e-88e4-05a86c21a03e", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8a51b850-3ad5-4998-92dc-581ec43eb234", "41c6470f-ccb1-42db-954b-c330a72c8b34" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "af172c47-fde8-44c4-93b8-fe2e623a592f", "8a51b850-3ad5-4998-92dc-581ec43eb234" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8a51b850-3ad5-4998-92dc-581ec43eb234", "41c6470f-ccb1-42db-954b-c330a72c8b34" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af172c47-fde8-44c4-93b8-fe2e623a592f", "8a51b850-3ad5-4998-92dc-581ec43eb234" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af172c47-fde8-44c4-93b8-fe2e623a592f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41c6470f-ccb1-42db-954b-c330a72c8b34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a51b850-3ad5-4998-92dc-581ec43eb234");
        }
    }
}
