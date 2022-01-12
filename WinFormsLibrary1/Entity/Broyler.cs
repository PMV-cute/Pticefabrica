using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class Broyler
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(100)] public string TypeChiсken { get; set; }


    }
}
