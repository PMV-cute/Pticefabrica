using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class NegodnayaChicken
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string TypeChiсken { get; set; }
        [Required]
        public int kolvo { get; set; }
    }
}
