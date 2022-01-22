using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class Nesushka
    {
        [Key] // Первичный ключ
        public int ID { get; set; }
        [Required] // NOT NULL
        [MaxLength(100)] public string TypeChiсken { get; set; } // Максимальная длинна
    }
}
