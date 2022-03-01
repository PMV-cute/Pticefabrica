using System.ComponentModel.DataAnnotations;
using System;
namespace WinFormsLibrary1.Entity
{
    public class PartiyaTovarnEggs 
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public int Categori { get; set; }
        [Required]
        public DateTime DateUp { get; set; }
        public int Kolvo { get; set; }
        public int? CehSortID2 { get; set; }
    }
}
