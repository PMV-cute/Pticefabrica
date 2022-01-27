 using System.ComponentModel.DataAnnotations;
using System;

namespace WinFormsLibrary1.Entity
{
    public class PartiyaMolodnyaka
    {
        [Key]
        public int ID { get; set; }
        public DateTime DataForm { get; set; }
        public bool FreeOrNotFree { get; set; }
        [Required]
        public string TypeChicken { get; set; }
        public int Kolvo { get; set; }

        public int? IncID { get; set; }
        public int? PtID { get; set; }
    }
}
