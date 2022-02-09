using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WinFormsLibrary1.Entity
{
    public class PartiyaEggs
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Npart { get; set; }

        public int Kolvo { get; set; }
        public DateTime DateForm { get; set; }

        public int? CoPrID2 { get; set; }
        public int? CehSortID { get; set; }
    }
}
