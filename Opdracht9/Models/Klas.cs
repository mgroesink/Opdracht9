using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Opdracht9.Models
{
    public class Klas
    {
        #region Fields and properties
        public int Id { get; set; }
        [MaxLength(5, ErrorMessage = "Klas bestaat uit exact 5 tekens")]
        [MinLength(5, ErrorMessage = "Klas bestaat uit exact 5 tekens")]
        [RegularExpression("[A-Z][0-9][A-Z]{3}")] // One letter, one digits and three letters
        [Column("Klas", TypeName = "char")]
        public string Code { get; set; }
        /// <summary>Gets or sets the omschrijving.</summary>
        /// <value>The omschrijving.</value>
        [MaxLength(255, ErrorMessage = "Maximaal 255 tekens toegestaan")]
        public string Omschrijving { get; set; } = string.Empty;

        // Navigation property
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Rooster> Roosters { get; set; } = new List<Rooster>();
        #endregion
    }
}