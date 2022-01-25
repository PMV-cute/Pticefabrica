using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace WinFormsLibrary1.Entity
{
    public class Reproductor
    {
        [Key]
        public int RepID { get; set; }

        public int KolvoB { get; set; }
        public int KolvoN { get; set; }
        [Required]
        public string DateP { get; set; }
        [Required]
        public int feed { get; set; }
        [Required]
        public int water { get; set; }

        [ForeignKey("RepID")]
        public ICollection<PartiyaEggsRodClass> PartiyaEggsRodClasses { get; set; }
        [ForeignKey("RepID2")]
        public ICollection<PartiyaRemontnayaVzrosloyChicken> PartiyaRemontnayaVzrosloyChickens { get; set; }
        public string FormirovPartEggs()
        {
            ApplicationContext context = new ApplicationContext();
            var repr = context.Reproductor.ToList();
            var PER = context.PartiyaEggsRodClass.ToList();
            
            return $"Партия №{repr[repr.Count - 1].RepID}: количество произведенных яиц: {PER[PER.Count - 1].Kolvo}. Дата: {repr[repr.Count-1].DateP}";
        }
        public void VipuscPartii() { }

    }
}
