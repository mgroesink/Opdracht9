using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Opdracht9.Migrations
{
    public partial class SLB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Klassen_KlasId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "KlasId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Geboortedatum",
                table: "Students",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AddColumn<int>(
                name: "SlbId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Woonplaats",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_SlbId",
                table: "Students",
                column: "SlbId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Docenten_SlbId",
                table: "Students",
                column: "SlbId",
                principalTable: "Docenten",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Klassen_KlasId",
                table: "Students",
                column: "KlasId",
                principalTable: "Klassen",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Docenten_SlbId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Klassen_KlasId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SlbId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SlbId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Woonplaats",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "KlasId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Geboortedatum",
                table: "Students",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Klassen_KlasId",
                table: "Students",
                column: "KlasId",
                principalTable: "Klassen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
