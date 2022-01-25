using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("PtID")]
        public ICollection<PartiyaMolodnyaka> PartiyaMolodnyakas { get; set; }
        [ForeignKey("PtID2")]
        public ICollection<PartiyaVzrosloyChicken> PartiyaVzrosloyChickens { get; set; }
        public void TimerGrow() { }

        public void FormPartii() { }

        public void VipuscPartii() { }
    }
}
