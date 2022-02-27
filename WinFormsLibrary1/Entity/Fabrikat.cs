using System.ComponentModel.DataAnnotations;
using System;

namespace WinFormsLibrary1.Entity
{
    public class Fabrikat : EntityClass
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public DateTime DateUp { get; set; }
        public int Kolvo { get; set; }
        public int UPKID2 { get; set; }
    }
}
