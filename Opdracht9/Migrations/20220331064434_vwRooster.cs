using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Opdracht9.Migrations
{
    public partial class vwRooster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string view = "CREATE VIEW vwRooster";
            view += " AS";
            view += " SELECT k.Klas as [Klas], d.Afkorting as [Docent],";
            view += "  v.Code as [Vak], r.Lokaal, r.Dag , r.Uur";
            view += " FROM roosters r";
            view += " INNER JOIN docenten d ON r.DocentId = d.id";
            view += " INNER JOIN klassen k ON r.KlasId = k.Id";
            view += " INNER JOIN vakken v ON r.VakId = v.Id";

            migrationBuilder.Sql(view);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW vwRooster");
        }
    }
}
