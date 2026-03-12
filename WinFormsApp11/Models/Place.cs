using System.ComponentModel;
namespace WinFormsApp11.Models
{
    public class Place
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Номер")]
        public int Number { get; set; }
        [DisplayName("Этаж")]
        public int Etazh { get; set; }
        [DisplayName("Категория")]
        public string Category { get; set; } = string.Empty;
        [DisplayName("Описание")]
        public string Desc { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Номер {Number} Этаж {Etazh} Категория{Category}";
        }
    }
}
