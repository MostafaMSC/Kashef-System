using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KSHIFSYSTEM.Data.Migrations
{
    public partial class dasdeeaededdddf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddadAlkhobraa",
                table: "TarshehBookTable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AlwasilDate",
                table: "TarshehBookTable",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlwasilNo",
                table: "TarshehBookTable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MokataNO",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "e6b6a12c-ec44-42a8-8ca4-00df69fbdc40");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2",
                column: "ConcurrencyStamp",
                value: "6fb37caa-7014-4f0a-b160-28bbe2cf2c47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "f974c87e-c259-447d-9ba2-d5c65042c867");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "ce26c675-0b44-4aa0-a219-9e97eeb1f711");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "owner",
                column: "ConcurrencyStamp",
                value: "ab7ed736-b8b0-4ee2-99d6-74bd07cd902e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator",
                column: "ConcurrencyStamp",
                value: "fe546126-1901-45b4-96a1-68ca3dc2066c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "6b86c02a-0d4c-48b3-abeb-ac7061b9a077");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ccd268a3-e5f9-4d7d-be48-58b229c53f3c", "5e44d601-d974-4c70-a5ff-3e833fc01ea7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddadAlkhobraa",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "AlwasilDate",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "AlwasilNo",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "MokataNO",
                table: "TarshehBookTable");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "9da5e83f-9730-4c3a-a507-7f4103dcbea2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2",
                column: "ConcurrencyStamp",
                value: "4dae0f55-444b-49c8-a8d9-42de84489c66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "41c93864-41d6-47e4-9d8c-10c74e296708");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "72ca94fa-177f-42b4-8703-4b6e029a8404");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "owner",
                column: "ConcurrencyStamp",
                value: "eaf5ed48-3f47-4baa-b683-03a11bea8f27");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator",
                column: "ConcurrencyStamp",
                value: "432ef50e-351b-44ea-be27-2837f1f53ece");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "cacafab3-2302-4fb2-8fd5-1df377ebe51f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9891e723-ee3d-4016-baab-7cc3d06dc8e2", "48cef87f-d546-4a52-99e4-860b1ac0a395" });
        }
    }
}
