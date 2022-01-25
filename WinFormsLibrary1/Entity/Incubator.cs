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
        public double max { get; set; } = 10000;
        public int KolvoEggs { get; set; }
        [Required]
        public string DatePostupleniya { get; set; }
        //public int Temp; //Не нада метод
        //public int vlagnost; //Не нада метод
        
        public int time { get; set; } //Не нада метод
        public void Perecladka() 
        {
            
        }
        public void Viderjka() { }
        public void OtborzdorovChiken() { }
        public void Vakcinaciya() { }
        public void VipuscPartii() { }
        [ForeignKey("IncID2")]
        //public int PartiyaEggsRodID { get; set;}
        public ICollection<PartiyaEggsRodClass> PartiyaEggsRodClass { get; set; }

        [ForeignKey("IncID")]
        public ICollection<PartiyaMolodnyaka> PartiyaMolodnyakas { get; set; }
    }
}
