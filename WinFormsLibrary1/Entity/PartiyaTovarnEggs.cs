using System.ComponentModel.DataAnnotations;
using System;
namespace WinFormsLibrary1.Entity
{
    public class PartiyaTovarnEggs
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Npart { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public DateTime DateUp { get; set; }
        public int? CehSortID2 { get; set; }
    }
}
