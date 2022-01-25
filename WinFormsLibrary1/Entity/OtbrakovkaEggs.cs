using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class OtbrakovkaEggs
    {
        [Key] // Первичный ключ
        public int ID { get; set; }
        [Required]
        public int kolvo { get; set; }
        public int? CehSortID3 { get; set; }
        public int? CehPrMID2 { get; set; }

    }
}
