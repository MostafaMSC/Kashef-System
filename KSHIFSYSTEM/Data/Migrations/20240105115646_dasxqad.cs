using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KSHIFSYSTEM.Data.Migrations
{
    public partial class dasxqad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpecaialName11",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialName12",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialName13",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialName14",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialName15",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialName16",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "32946e2f-8db3-44ab-97ca-1eb2b261c3ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2",
                column: "ConcurrencyStamp",
                value: "b94ec203-ab7f-4a9d-9bc2-e39cb2fb3a81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "b71f4693-e7d0-422a-8721-8f4d2878b520");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "ee7e9ed3-7e22-4e83-97f3-6332ec612553");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "owner",
                column: "ConcurrencyStamp",
                value: "e954420a-99a5-4d23-a001-4a5a04936ce4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator",
                column: "ConcurrencyStamp",
                value: "f1d35f0a-ca3b-49a0-b1d7-718c2bb4812e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "ded1e4d9-3f2c-4309-99bf-fe89edb11f50");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d83edd1-70ff-4842-a597-8e2c215f3b5e", "74ef1366-00ca-4dfb-b77b-ef322416635e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecaialName11",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialName12",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialName13",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialName14",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialName15",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialName16",
                table: "TarshehBookTable");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "32af9bee-d2c2-4297-bc4f-2e57a6f4f32a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2",
                column: "ConcurrencyStamp",
                value: "41b70721-df59-463d-966a-d3423215f8eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "a29fe22b-a1bc-4f9a-a9ad-bafcb342a71c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "2afc4c47-a467-49d2-bec5-2c5f28408f87");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "owner",
                column: "ConcurrencyStamp",
                value: "f104ad72-06f7-4149-8e4f-cb89f671ead3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator",
                column: "ConcurrencyStamp",
                value: "165f1a54-b25e-4833-a0eb-e9ffd7ca3b5d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "189d261e-c05b-4f8a-97ea-35c6a6296aea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "615e1063-4002-41d4-9538-ca4f66c449f0", "15beb53f-5891-4283-a91f-5b6f7718f135" });
        }
    }
}
