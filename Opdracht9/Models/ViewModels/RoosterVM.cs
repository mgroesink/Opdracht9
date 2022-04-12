namespace Opdracht9.Models.ViewModels
{
    public class RoosterVM
    {
        public string Klas { get; set; } = string.Empty;
        public string Docent { get; set; } = string.Empty;
        public string Vak { get; set; } = string.Empty;
        public string Lokaal { get; set; } = string.Empty;
        public DayOfWeek Dag { get; set; }
        public int Uur { get; set; }
    }
}
