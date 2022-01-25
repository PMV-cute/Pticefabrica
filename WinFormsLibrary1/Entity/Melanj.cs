using System.ComponentModel.DataAnnotations;
using System;

namespace WinFormsLibrary1.Entity
{
    public class Melanj
    {
        [Key]
        [Required]
        public int Ntari { get; set; }
        [Required]
        public string TypeMelanga { get; set; }
        [Required]
        public DateTime DateRosliva { get; set; }
        public int? CehPrMID { get; set; }
    }
}
