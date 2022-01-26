﻿using System.ComponentModel.DataAnnotations;
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
        [Required]
        public double max { get; set; }
        public int DaysBeforeHatching { get; set; }
        //public int Temp; //Не нада метод
        //public int vlagnost; //Не нада метод
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
