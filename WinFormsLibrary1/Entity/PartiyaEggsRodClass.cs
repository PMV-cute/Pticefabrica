using System.ComponentModel.DataAnnotations;
using System;

namespace WinFormsLibrary1.Entity
{
    public class PartiyaEggsRodClass
    {
        [Key]
        public int ID { get; set; }

        public int Kolvo { get; set; }
        public DateTime DatePostEggs { get; set; }
        public bool FreeOrNotFree { get; set; }
        public int? RepID { get; set; }
        public int? IncID2 { get; set; }

        public Reproductor Reproductor { get; set; }
        public Incubator Incubator { get; set; }
    }
}
