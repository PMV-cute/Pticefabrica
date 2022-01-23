using System.ComponentModel.DataAnnotations;
using System;

namespace WinFormsLibrary1.Entity
{
    public class Fabrikat
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string TypeFabr { get; set; }
        [Required]
        public DateTime DateUp { get; set; }
    }
}
