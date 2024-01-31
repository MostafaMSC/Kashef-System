using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KSHIFSYSTEM.Data.Migrations
{
    public partial class fsfs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cvfgrtbvdscvfd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookDate",
                table: "TarshehBookTable",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "0d4c59ab-db35-44c6-925e-29cfac31913b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2",
                column: "ConcurrencyStamp",
                value: "31fd88bd-350d-444a-bc71-b92cf17a4adf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "3396feca-754e-41e0-93d0-7a3d5d6a1233");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "28b23036-d26e-4885-9074-518219d09385");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "owner",
                column: "ConcurrencyStamp",
                value: "aeefd5c2-933f-4d2f-86fb-59faf3133cde");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator",
                column: "ConcurrencyStamp",
                value: "9b19ce9a-aee1-4e27-87fc-3f36def78aa2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "4775e438-ffce-40bf-a0fb-c47b01eb4624");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "50edd009-0ba1-4639-a08b-3923fbd0781f", "ADMIN", "04feb8f8-a3d6-4829-ac33-5d26ab220921" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BookDate",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "8070f7f7-6a4b-44d7-a695-2d12ba70e037");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2",
                column: "ConcurrencyStamp",
                value: "6dcb71d8-0808-4015-a5f8-96b2ded9c23f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "31270b02-4098-4e09-8361-7e880a2e1f4f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "ae7f188a-d64d-43a0-8f43-52d34db2b0cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "owner",
                column: "ConcurrencyStamp",
                value: "c19dd57e-224b-449b-8593-96b07c585705");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator",
                column: "ConcurrencyStamp",
                value: "4f04f6a6-380a-4af8-859e-efe3a0e86556");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "5df7ec3c-e290-4598-82e0-9810e6b3d84d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "eeb4e932-ffb5-4ef4-8c5e-4fb782553270", "admin", "a9fea87a-6052-433e-8b90-5bde710b3a35" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cvfgrtbvdscvfd", 0, "59cf0fe7-c379-4714-b6e5-1a2b8315abd9", "admin", true, false, null, "admin", "ADMIN2", "000000", null, false, "e8e8e939-394d-4af4-aec1-128141257f2a", false, "admin2" },
                    { "dASDadadasdasdasdsa", 0, "c1d5be49-d5c4-4420-aac1-c6b2f8fa217c", "owner", true, false, null, "owner", "OWNER", "000000", null, false, "0229b1ae-3fba-4e4f-b828-7c34903efa7f", false, "owner" }
                });
        }
    }
}
