using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Opdracht9.Models
{
    public class Docent
    {
        #region Fields and properties
        public int Id { get; set; }
        [RegularExpression("[A-Z]{3}[0-9]{2}",
            ErrorMessage = "Docentcode moet bestaan uit 3 hoofdletters en 2 cijfers")]
        public string Afkorting { get; set; } = string.Empty;
        [MaxLength(10)]
        public string Voorletters { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Achternaam { get; set; } = string.Empty;
        [EmailAddress]
        public string Emailadres { get; set; } = string.Empty;
        [NoFutureDate(ErrorMessage = "Geboortedatum kan niet in de toekomst liggen")]
        [Column("Geboortedatum", TypeName = "Date")]
        [DataType(DataType.Date)]
        public DateTime Geboortedatum { get; set; }
        [RegularExpression("[1-9][0-9]{3}[A-Z]{2}",
            ErrorMessage = "Postcode moet bestaan uit 4 cijfers en 2 hoofdletters")]
        // 4 cijfers en 2 hoofdlettersletters. Eerste cijfer mag geen 0 zijn.
        public string Postcode { get; set; } = string.Empty;

        public List<Student>? Studenten { get; set; }
        #endregion

    }
}
