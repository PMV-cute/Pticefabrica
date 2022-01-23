using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class CehProizvMelanja
    {
        [Key]
        [Required]
        public int Nceha { get; set; }
        public void Vskritie() { }
        public void Separation() { }
        public void Rozliv() { }
        public void Vipusc() { }
    }
}
