using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class OtbrakovkaEggs
    {
        [Key] // Первичный ключ
        public int ID { get; set; }
        [Required]
        public int kolvo { get; set; }
    }
}
