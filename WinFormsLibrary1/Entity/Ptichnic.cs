using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class Ptichnic
    {
        [Key]
        public int ID { get; set; }
        public int KolvoB { get; set; }
        public int KolvoN { get; set; }
        [Required]
        public bool Pfeed { get; set; }
        [Required]
        public bool Pwater { get; set; }
        public void TimerGrow() { }

        public void FormPartii() { }

        public void VipuscPartii() { }
    }
}
