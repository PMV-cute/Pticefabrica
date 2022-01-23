using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class PartiyaVzrosloyChicken
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Npart { get; set; }
        [Required]
        public string TypeChiсken { get; set; }
        public int Kolvo { get; set; }
    }
}
