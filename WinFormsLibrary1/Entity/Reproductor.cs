using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsLibrary1.Entity
{
    public class Reproductor
    {
        [Key]
        public int RepID { get; set; }

        public int KolvoB { get; set; }
        public int KolvoN { get; set; }
        [Required]
        public DateTime DateP { get; set; }
        [Required]
        public bool Pfeed { get; set; }
        [Required]
        public bool Pwater { get; set; }

        [ForeignKey("RepID")]
        public ICollection<PartiyaEggsRodClass> PartiyaEggsRodClasses { get; set; }
        [ForeignKey("RepID2")]
        public ICollection<PartiyaRemontnayaVzrosloyChicken> PartiyaRemontnayaVzrosloyChickens { get; set; }
        public void FormirovPartEggs(){}
        public void VipuscPartii() { }

    }
}
