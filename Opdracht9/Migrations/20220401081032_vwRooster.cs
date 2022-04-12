using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

#nullable disable

namespace Opdracht9.Migrations
{
    public partial class vwRooster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //string view = "CREATE VIEW vwRooster";
            //view += " AS";
            //view += " SELECT k.Klas as [Klas], d.Afkorting as [Docent],";
            //view += "  v.Code as [Vak], r.Lokaal, r.Dag , r.Uur";
            //view += " FROM roosters r";
            //view += " INNER JOIN docenten d ON r.DocentId = d.id";
            //view += " INNER JOIN klassen k ON r.KlasId = k.Id";
            //view += " INNER JOIN vakken v ON r.VakId = v.Id";

            // StringBuilder is een betere oplossing omdat strings unmutable zijn
            StringBuilder sb = new StringBuilder("CREATE VIEW vwRooster");
            sb.Append(" AS");
            sb.Append(" SELECT k.Klas as [Klas], d.Afkorting as [Docent],");
            sb.Append("  v.Code as [Vak], r.Lokaal, r.Dag , r.Uur");
            sb.Append(" FROM roosters r");
            sb.Append(" INNER JOIN docenten d ON r.DocentId = d.id");
            sb.Append(" INNER JOIN klassen k ON r.KlasId = k.Id");
            sb.Append(" INNER JOIN vakken v ON r.VakId = v.Id");
            string view = sb.ToString();

            migrationBuilder.Sql(view);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW vwRooster");
        }
    }
}
