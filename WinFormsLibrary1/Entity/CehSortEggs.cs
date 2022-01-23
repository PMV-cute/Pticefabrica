using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class CehSortEggs
    {
        
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        
        public int Kolvo { get; set; }
        [Required]
        public int Npart { get; set; }
        
        public void Otbracovka() { }
        public void FormPartii() { }
        public void Upacovca() { }
        public void VipuscPartii() { }
    }
}
