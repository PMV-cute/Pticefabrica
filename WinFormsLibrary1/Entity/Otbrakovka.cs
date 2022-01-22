using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class Otbrakovka
    {
        [Key] // Первичный ключ
        public int ID { get; set; }
        [Required]
        public double Weight { get; set; }
    }
}
