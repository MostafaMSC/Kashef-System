using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KSHIFSYSTEM.Data.Migrations
{
    public partial class RoleMUSEBA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "update");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "View");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "72f4bae8-2011-4f4f-816b-5eaf74d1e8c7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin2", "26ccb44d-28e7-4f55-be06-60a169b079c4", "admin2", "ADMIN2" },
                    { "DawaView", "b0cebf45-f2b9-4980-b397-cb7e8e8e78f6", "DawaView", "DAWAVIEW" },
                    { "eatalaJazaea", "5cbdcd42-2d12-4424-9acc-a05b16a16b18", "eatalaJazaea", "EATALAJAZAEA" },
                    { "owner", "356708e4-bb4d-45c2-a473-8e8aacd29754", "owner", "OWNER" },
                    { "regulator", "e9447cd4-bc37-4907-9a91-bce8ac2fa032", "regulator", "REGULATOR" },
                    { "SuperAdmin", "8e1c1d51-3c2b-4d77-9901-ea40191167ad", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8075e75c-228d-4d03-b230-8025c95816a2", "e1fa8fa9-9555-4e6f-bad2-229176d5582a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cvfgrtbvdscvfd", 0, "64f46bb0-3882-43e0-b55d-318f3ab0dcdd", "admin", true, false, null, "admin", "ADMIN2", "000000", null, false, "3dc3215d-5819-4e31-9f0f-e145e39b1cae", false, "admin2" },
                    { "dASDadadasdasdasdsa", 0, "12006a04-73b6-4f2f-abcd-fc82f151dc74", "owner", true, false, null, "owner", "OWNER", "000000", null, false, "5f17e0b4-f418-48f6-9306-b5a1b0eef49b", false, "owner" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "owner");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cvfgrtbvdscvfd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "e3a51636-4382-417b-babb-1dbad35a34ee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "update", "3209d6d9-6593-4a46-9bff-7bb9d1aa4e6b", "update", "UPDATE" },
                    { "View", "9e4af477-c35d-4441-8689-29f001b9156b", "View", "VIEW" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4a3dc13d-da57-4a69-8279-cfe96477e9e4", "b0aabb2f-adab-47c3-b3a4-3578141f225d" });
        }
    }
}
