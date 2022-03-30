using System.ComponentModel.DataAnnotations;

namespace Opdracht9.Models
{
    public class Vak
    {
        public int Id { get; set; }
        [MaxLength(3,ErrorMessage = "Max. {1} tekens")]
        [MinLength(3, ErrorMessage = "Min. {1} tekens")]
        [RegularExpression("[A-Z]{3}")]
        public string Code { get; set; } = string.Empty;
        [MaxLength(50,ErrorMessage = "Max. {1} tekens")]
        public string Description { get; set; } = string.Empty;
    }
}
