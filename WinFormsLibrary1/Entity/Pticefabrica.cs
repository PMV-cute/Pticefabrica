using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace WinFormsLibrary1.Entity
{
    public class Pticefabrica
    {
        [Key]
        public int Number { get; set; }
        public string Addres { get; set; }
        public string Name { get; set; }
    }
}
