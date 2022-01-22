using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class ComplexProizvodstvaEggs
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        [MaxLength(10)]
        public int NIncubator { get; set; }
        [Required]
        public string Kolvo { get; set; }
        [Required]
        public bool Pfeed { get; set; }
        [Required]
        public bool Pwater { get; set; }
        public void OtbracovcaPartii() { }
    }
}
