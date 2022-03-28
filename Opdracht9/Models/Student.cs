using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Opdracht9.Models
{
    public class Student
    {
        #region Fields and properties
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets the studentnumber.
        /// </summary>
        /// <value>
        /// The studentnumber.
        /// </value>
        [MaxLength(7, ErrorMessage = "Studentnummer bestaat uit exact 7 cijfers")]
        [MinLength(7, ErrorMessage = "Studentnummer bestaat uit exact 7 cijfers")]
        [Column("Studentnumber", TypeName = "char")]
        public string Studentnummer { get; set; }

        /// <summary>
        /// Gets the fullname.
        /// </summary>
        /// <value>
        /// The fullname.
        /// </value>
        public string Naam
        {
            get { return Voornaam + " " + Achternaam; }
        }

        /// <summary>
        /// Gets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public int Leeftijd
        {
            get
            {
                int age = DateTime.Now.Year - Geboortedatum.Year;
                if (DateTime.Now.Month > Geboortedatum.Month) age--;
                else if (DateTime.Now.Month == Geboortedatum.Month &&
                    DateTime.Now.Day > Geboortedatum.Day) age--;
                return age;
            }
        }

        [MaxLength(25, ErrorMessage = "{0} mag maximaal {1} tekens zijn"), Required]
        public string Voornaam { get; set; } = string.Empty;
        [MaxLength(50, ErrorMessage = "{0} mag maximaal {1} tekens zijn"), Required]
        public string Achternaam { get; set; } = string.Empty;
        [ForeignKey(nameof(Klas))]
        public int KlasId { get; set; }
        [NoFutureDate(ErrorMessage = "Geboortedatum kan niet in de toekomst liggen")]
        [Column("Geboortedatum", TypeName = "Date")]
        [DataType(DataType.Date)]
        public DateTime Geboortedatum { get; set; }

        public Klas Klas { get; set; }
        #endregion

        #region Constructors
        public Student()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="studentnummer">The studentnumber.</param>
        public Student(string studentnummer)
        {
            Studentnummer = studentnummer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="studentnummer">The studentnumber.</param>
        /// <param name="voornaam">The firstname.</param>
        /// <param name="achternaam">The lastname.</param>
        public Student(string studentnummer, string voornaam, string achternaam)
        {
            Studentnummer = studentnummer;
            Voornaam = voornaam;
            Achternaam = achternaam;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="studentnummer">The studentnumber.</param>
        /// <param name="voornaam">The firstname.</param>
        /// <param name="achternaam">The lastname.</param>
        /// <param name="klas">The class.</param>
        /// <param name="geboortedatum">The birthdate.</param>
        public Student(string studentnummer, string voornaam, string achternaam, int klas, DateTime geboortedatum)
        {
            Studentnummer = studentnummer;
            Voornaam = voornaam;
            Achternaam = achternaam;
            KlasId = klas;
            Geboortedatum = geboortedatum;
        }

        #endregion

    }

}
