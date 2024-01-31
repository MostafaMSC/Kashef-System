using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KSHIFSYSTEM.Data.Migrations
{
    public partial class fsv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpecialBlock",
                table: "SpecialestTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2",
                column: "ConcurrencyStamp",
                value: "ed565ed6-15af-4c29-9880-58f60dce6f2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "afb3b1a6-2485-4550-8594-51d0ea2a35ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "74e9f829-8f9c-4083-acf8-19726e4ad8c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "2b1c49f8-e24e-442b-ae5c-3185c3a3af04");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "owner",
                column: "ConcurrencyStamp",
                value: "f1a2bdde-fd50-4165-b1ba-b6c66151aa57");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator",
                column: "ConcurrencyStamp",
                value: "7ece8153-d391-4c69-bbf6-e1eaaba4fe9c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "33d16b5e-7626-4f2c-aa1f-872d6713006c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "893cab24-1ab3-4c24-aa66-f3d07a51a996", "ca972843-6dc8-4800-ad71-3bc47d144cb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecialBlock",
                table: "SpecialestTable");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2",
                column: "ConcurrencyStamp",
                value: "74aa7296-0dae-4619-adc5-e6af3e600f31");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "ead08131-18a3-4a99-9141-a93399d1276d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "caca5ab9-ebb2-4b34-9a3f-8fb4ffba13df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "3626c637-a969-41c7-af7c-e490278a0bc6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "owner",
                column: "ConcurrencyStamp",
                value: "53d0aceb-1929-4bbd-96ff-dd57b552a9f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator",
                column: "ConcurrencyStamp",
                value: "0f71c083-269f-48e5-982b-2a8e1e670545");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "1854c7c8-0d72-44c0-864b-dd9868c7c971");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6fe3e08d-39b3-40fa-9010-f36482bb9629", "a92bc23a-d5b2-4e13-8eca-cbafb50244b9" });
        }
    }
}
