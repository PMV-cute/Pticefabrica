using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace WinFormsLibrary1.Entity
{
    public class Reproductor
    {
        [Key]
        public int RepID { get; set; }

        public int KolvoB { get; set; }
        public int KolvoN { get; set; }
        public int maxB { get; set; }
        public int maxN { get; set; }

        [ForeignKey("RepID")]
        public ICollection<PartiyaEggsRodClass> PartiyaEggsRodClasses { get; set; }

    }
}
