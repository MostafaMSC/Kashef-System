using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KSHIFSYSTEM.Data.Migrations
{
    public partial class dasdadddf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "80cf58ad-e19c-43a0-9ddc-ce6b463a48c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2",
                column: "ConcurrencyStamp",
                value: "ae866eac-63f0-493a-99cc-36c4fe1c23df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "327c90b5-bb9a-4981-b221-5fe20dbcd7ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "75364f30-fb5a-486b-9d0a-ffcd3d84bd6e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "owner",
                column: "ConcurrencyStamp",
                value: "b5dfe43c-1ecd-4f68-bfc2-42b8dda6eb9f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator",
                column: "ConcurrencyStamp",
                value: "37b1d226-6f39-4e92-bda7-2472d5cd8ff0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "31ae8b16-2f03-4843-8dfe-20a6a3a5803e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34ccb1ba-9bde-4a85-9400-3e2327776a0d", "2cea6f02-2092-4938-88da-19b2d2d88494" });
        }
    }
}
