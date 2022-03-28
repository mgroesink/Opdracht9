using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Opdracht9.Data.Migrations
{
    public partial class Modelscreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Docenten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Afkorting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Voorletters = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Achternaam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Emailadres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geboortedatum = table.Column<DateTime>(type: "Date", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docenten", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Klassen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Klas = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false),
                    Omschrijving = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klassen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roosters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlasId = table.Column<int>(type: "int", nullable: false),
                    DocentId = table.Column<int>(type: "int", nullable: false),
                    Dag = table.Column<int>(type: "int", nullable: false),
                    Uur = table.Column<int>(type: "int", nullable: false),
                    Lokaal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roosters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roosters_Docenten_DocentId",
                        column: x => x.DocentId,
                        principalTable: "Docenten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Roosters_Klassen_KlasId",
                        column: x => x.KlasId,
                        principalTable: "Klassen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Studentnumber = table.Column<string>(type: "char(7)", maxLength: 7, nullable: false),
                    Voornaam = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Achternaam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KlasId = table.Column<int>(type: "int", nullable: false),
                    Geboortedatum = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Klassen_KlasId",
                        column: x => x.KlasId,
                        principalTable: "Klassen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roosters_DocentId",
                table: "Roosters",
                column: "DocentId");

            migrationBuilder.CreateIndex(
                name: "IX_Roosters_KlasId",
                table: "Roosters",
                column: "KlasId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_KlasId",
                table: "Students",
                column: "KlasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roosters");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Docenten");

            migrationBuilder.DropTable(
                name: "Klassen");
        }
    }
}
