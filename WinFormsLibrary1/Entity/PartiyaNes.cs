using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WinFormsLibrary1.Entity
{
    public class PartiyaNes
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Npart { get; set; }
        [Required]
        public string TypeChiсken { get; set; }
        public int Kolvo { get; set; }
    }
}
