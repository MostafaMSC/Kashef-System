using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KSHIFSYSTEM.Data.Migrations
{
    public partial class dsxcxzdcczdcdc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookNo = table.Column<int>(type: "int", nullable: false),
                    HayaBookNo = table.Column<int>(type: "int", nullable: false),
                    HayaBookDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceNo = table.Column<int>(type: "int", nullable: false),
                    BookDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KashefType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JahaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KshefDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddadAlkhobraa = table.Column<int>(type: "int", nullable: false),
                    AstmaraNoP = table.Column<int>(type: "int", nullable: false),
                    AstmaraDateP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AstmaraNoM = table.Column<int>(type: "int", nullable: false),
                    AstmaraDateM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlwasilNo = table.Column<int>(type: "int", nullable: false),
                    AlwasilDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookPic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DawwaTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelectDawa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DawaNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DawaSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DawaType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Office = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Court = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Decision1Num = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Decision1ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AstanafNO = table.Column<int>(type: "int", nullable: false),
                    TameezNO = table.Column<int>(type: "int", nullable: false),
                    TashehNO = table.Column<int>(type: "int", nullable: false),
                    qraraadaNO = table.Column<int>(type: "int", nullable: false),
                    AkherALajraaat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DawwaTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "khobraaDawaaTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KshofatNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khobraaDawaaTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "khobraaMahakemTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KshofatNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khobraaMahakemTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SpecialestTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KshifType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KshofatNo = table.Column<int>(type: "int", nullable: false),
                    TotalKSofat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialestTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TarshehBookTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookNo = table.Column<int>(type: "int", nullable: true),
                    JehaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KshefDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlaceNo = table.Column<int>(type: "int", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WasilNoM = table.Column<int>(type: "int", nullable: true),
                    WasilDateM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WasilNoP = table.Column<int>(type: "int", nullable: true),
                    WasilDateP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KshifType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecaialName1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecaialName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecaialName3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecaialName4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecaialName5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecaialName6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KshifResult = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarshehBookTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TotalKshofatTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KshofatNoMahakem = table.Column<int>(type: "int", nullable: false),
                    KshodatNOAqaraat = table.Column<int>(type: "int", nullable: false),
                    TotalKshofat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalKshofatTable", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookTable");

            migrationBuilder.DropTable(
                name: "DawwaTable");

            migrationBuilder.DropTable(
                name: "khobraaDawaaTable");

            migrationBuilder.DropTable(
                name: "khobraaMahakemTable");

            migrationBuilder.DropTable(
                name: "SpecialestTable");

            migrationBuilder.DropTable(
                name: "TarshehBookTable");

            migrationBuilder.DropTable(
                name: "TotalKshofatTable");
        }
    }
}
