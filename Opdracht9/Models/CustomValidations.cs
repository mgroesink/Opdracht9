using System.ComponentModel.DataAnnotations;

namespace Opdracht9.Models
{
    public class NoFutureDateAttribute : ValidationAttribute
    {
        /// <summary>
        /// Returns true if ... is valid.
        /// </summary>
        /// <param name="value">The value of the object to validate.</param>
        /// <returns>
        ///   <see langword="true" /> if the specified value is valid; otherwise, <see langword="false" />.
        /// </returns>
        public override bool IsValid(object value)
        {
            if (value == null) return true;
            DateTime date = (DateTime)value;
            if (date < DateTime.Today.AddDays(1))
            {
                return true;
            }
            ErrorMessage = "Date cannot be a futuire date";
            return true;
        }
    }
}
