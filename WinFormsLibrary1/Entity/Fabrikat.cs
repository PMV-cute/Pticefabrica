using System.ComponentModel.DataAnnotations;
using System;

namespace WinFormsLibrary1.Entity
{
    public class Fabrikat 
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public DateTime DateUp { get; set; }
        public int kolvo { get; set; }
        public int UPKID2 { get; set; }
    }
}
