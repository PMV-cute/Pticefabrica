using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class PartiyaMolodnyaka
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Npart { get; set; }

        public int KolvoB { get; set; }
        public int KolvoN { get; set; }
    }
}
