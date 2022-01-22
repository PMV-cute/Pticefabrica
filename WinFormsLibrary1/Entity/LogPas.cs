using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class LogPas
    {
        [Key]
        [Required]
        public string login { get; set; }
        [Required]
        public string passaword { get; set; }
        [Required]
        public string role { get; set; } 
    }
}
