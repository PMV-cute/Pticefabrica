using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace WinFormsLibrary1.Entity
{
    public class ComplexProizvodstvaEggs
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public int KolvoN { get; set; }
        public bool FreeOrNotFree { get; set; }
        public DateTime DateForm { get; set; }
        public int Cikl { get; set; }
        public int CiklMax { get; set; }
        [Required]
        public bool Pfeed { get; set; }
        [Required]
        public bool Pwater { get; set; }
        [ForeignKey("CoPrID")]
        public ICollection<PartiyaVzrosloyChicken> PartiyaVzrosloyChickens { get; set; }
        [ForeignKey("CoPrID2")]
        public ICollection<PartiyaEggs> PartiyaEggses { get; set; }
        [ForeignKey("CoPrID3")]
        public ICollection<NegodnayaChicken> NegodnayaChickens { get; set; }
    }
}
