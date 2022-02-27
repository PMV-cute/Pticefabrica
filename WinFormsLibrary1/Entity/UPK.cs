using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace WinFormsLibrary1.Entity
{
    public class UPK
    {
        [Key]
        public int ID { get; set; }
        
        public int KolvoB { get; set; }
        public bool FreeOrNotFree { get; set; }
        public DateTime Dateform { get; set; }
        [ForeignKey("UPKID")]
        public ICollection<PartiyaVzrosloyChicken> PartiyaVzrosloyChickens { get; set; }
        [ForeignKey("UPKID2")]
        public ICollection<Fabrikat> Fabrikats { get; set; }
    }
}
