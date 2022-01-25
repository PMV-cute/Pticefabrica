using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsLibrary1.Entity
{
    public class CehSortEggs
    {
        
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        
        public int Kolvo { get; set; }
        [Required]
        public int Npart { get; set; }
        [ForeignKey("CehSortID")]
        public ICollection<PartiyaEggs> PartiyaEggses { get; set; }
        [ForeignKey("CehSortID2")]
        public ICollection<PartiyaTovarnEggs> PartiyaTovarnEggses { get; set; }
        [ForeignKey("CehSortID3")]
        public ICollection<OtbrakovkaEggs> OtbrakovkaEggses { get; set; }

        public void Otbracovka() { }
        public void FormPartii() { }
        public void Upacovca() { }
        public void VipuscPartii() { }
    }
}
