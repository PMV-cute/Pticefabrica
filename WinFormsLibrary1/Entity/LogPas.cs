using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using WinFormsLibrary1;
using System.Linq;
namespace WinFormsLibrary1.Entity
{
    public class LogPas
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string login { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string role { get; set; }
    }
}
