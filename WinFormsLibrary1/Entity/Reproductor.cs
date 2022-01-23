using System.ComponentModel.DataAnnotations;
using System;
namespace WinFormsLibrary1.Entity
{
    public class Reproductor
    {
        [Key]
        public int ID { get; set; }

        public int KolvoB { get; set; }
        public int KolvoN { get; set; }
        [Required]
        public DateTime DateP { get; set; }
        [Required]
        public bool Pfeed { get; set; }
        [Required]
        public bool Pwater { get; set; }
        public void FormirovPartEggs()
        {

        }

        public void VipuscPartii() { }
    }
}
