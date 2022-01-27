using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WinFormsLibrary1.Entity
{
    public class Incubator
    {
        [Key]
        [Required]
        public int ID { get; set; }
        
        public int KolvoEggs { get; set; }
        [Required]
        public DateTime DatePost { get; set; }
        public DateTime DayOfBorn { get; set; }
        public bool FreeOrNotFree { get; set; }
        
        //public int Temp; //Не нада метод
        //public int vlagnost; //Не нада метод
        
        [ForeignKey("IncID2")]
        //public int PartiyaEggsRodID { get; set;}
        public ICollection<PartiyaEggsRodClass> PartiyaEggsRodClass { get; set; }

        [ForeignKey("IncID")]
        public ICollection<PartiyaMolodnyaka> PartiyaMolodnyakas { get; set; }
    }
}
