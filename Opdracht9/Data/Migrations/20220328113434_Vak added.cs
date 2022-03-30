using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Opdracht9.Data.Migrations
{
    public partial class Vakadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VakId",
                table: "Roosters",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Vakken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vakken", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roosters_VakId",
                table: "Roosters",
                column: "VakId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roosters_Vakken_VakId",
                table: "Roosters",
                column: "VakId",
                principalTable: "Vakken",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roosters_Vakken_VakId",
                table: "Roosters");

            migrationBuilder.DropTable(
                name: "Vakken");

            migrationBuilder.DropIndex(
                name: "IX_Roosters_VakId",
                table: "Roosters");

            migrationBuilder.DropColumn(
                name: "VakId",
                table: "Roosters");
        }
    }
}
