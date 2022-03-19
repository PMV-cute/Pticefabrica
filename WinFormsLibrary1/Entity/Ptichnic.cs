using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace WinFormsLibrary1.Entity
{
    public class Ptichnic
    {
        [Key]
        public int ID { get; set; }
        public int Kolvo { get; set; }
        [Required]
        public string TypeChicken { get; set; }
        [Required]
        public DateTime DatePost { get; set; }
        [Required]
        public DateTime DateGrow { get; set; }
        [Required]
        public bool FreeOrNotFree { get; set; }
        [ForeignKey("PtID")]
        public ICollection<PartiyaMolodnyaka> PartiyaMolodnyakas { get; set; }
        [ForeignKey("PtID2")]
        public ICollection<PartiyaVzrosloyChicken> PartiyaVzrosloyChickens { get; set; }
    }
}
