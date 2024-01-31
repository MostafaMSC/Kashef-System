using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KSHIFSYSTEM.Data.Migrations
{
    public partial class Updaterole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "56ff4f16-aba1-4584-8db4-6f3f99d7d892");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "update",
                column: "ConcurrencyStamp",
                value: "564d8e1b-bd28-4a83-95b8-f4c1b8b83b71");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "View",
                column: "ConcurrencyStamp",
                value: "f9b7adf7-cc29-4edf-8aac-1c4f2a3f91e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d472c4d0-f6c3-4d72-b5fb-c100482f3e11", "067baae3-cfb3-49d6-a62c-21cbe81c0c70" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "3a5cca5e-d834-4959-b654-d12e5eb7e04c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "update",
                column: "ConcurrencyStamp",
                value: "cf24d683-3afa-4bfe-904f-f7b17b72fa8a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "View",
                column: "ConcurrencyStamp",
                value: "0728e647-87a2-4cf8-a654-3868d9a7b6b2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2aca68de-90fb-4738-a2c4-4cbbb5f2caa9", "c50c5c88-699a-49b0-ab32-244f2cb4e926" });
        }
    }
}
