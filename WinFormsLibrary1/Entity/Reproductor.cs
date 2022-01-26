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

        [ForeignKey("RepID")]
        public ICollection<PartiyaEggsRodClass> PartiyaEggsRodClasses { get; set; }
        [ForeignKey("RepID2")]
        public ICollection<PartiyaRemontnayaVzrosloyChicken> PartiyaRemontnayaVzrosloyChickens { get; set; }
        public string FormirovPartEggs()
        {
            ApplicationContext context = new ApplicationContext();
            var repr = context.Reproductor.ToList();
            var PER = context.PartiyaEggsRodClass.ToList();
            
            return $"Количество партий{PER[PER.Count-1].Kolvo/1000}: количество произведенных яиц: {PER[PER.Count - 1].Kolvo}. Дата: {PER[PER.Count-1].DatePostEggs}";
        }

    }
}
