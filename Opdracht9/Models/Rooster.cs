using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Opdracht9.Models
{
    public class Rooster
    {
        #region Fields and properties
        public int Id { get; set; }
        [ForeignKey(nameof(Klas))]
        public int KlasId { get; set; }
        [ForeignKey(nameof(Docent))]
        public int DocentId { get; set; }
        [Range(1, 5, ErrorMessage = "Alleen werkdagen zijn toegestaan")]
        [ForeignKey(nameof(Vak))]
        public int VakId { get; set; }
        public DayOfWeek Dag { get; set; }
        [Range(1, 8)]
        public int Uur { get; set; }
        [RegularExpression("[0-9]{4}")]
        public string Lokaal { get; set; } = string.Empty;
        public Klas Klas { get; set; }
        public Docent Docent { get; set; }
        public Vak Vak { get; set; }
        #endregion
    }
}
