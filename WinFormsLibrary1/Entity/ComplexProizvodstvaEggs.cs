using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsLibrary1.Entity
{
    public class ComplexProizvodstvaEggs
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Kolvo { get; set; }
        [Required]
        public bool Pfeed { get; set; }
        [Required]
        public bool Pwater { get; set; }
        [ForeignKey("CoPrID")]
        public ICollection<PartiyaNes> PartiyaNeses { get; set; }
        [ForeignKey("CoPrID2")]
        public ICollection<PartiyaEggs> PartiyaEggses { get; set; }
        [ForeignKey("CoPrID3")]
        public ICollection<NegodnayaChicken> NegodnayaChickens { get; set; }
        public void OtbracovcaPartii() { }
    }
}
