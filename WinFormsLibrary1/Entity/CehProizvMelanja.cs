using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsLibrary1.Entity
{
    public class CehProizvMelanja
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [ForeignKey("CehPrMID")]
        public ICollection<Melanj> Melanjs { get; set; }
        [ForeignKey("CehPrMID2")]
        public ICollection<OtbrakovkaEggs> OtbrakovkaEggses { get; set; }
        [ForeignKey("CehPrMID3")]
        public ICollection<Othodi> Othodis { get; set; }
    }
}
