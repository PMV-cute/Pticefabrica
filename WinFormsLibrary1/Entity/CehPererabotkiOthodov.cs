using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsLibrary1.Entity
{
    public class CehPererabotkiOthodov
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)] 
        public string NormsPererab { get; set; }
        [ForeignKey("CePerOID")]
        public ICollection<NegodnayaChicken> NegodnayaChickens { get; set; }
        [ForeignKey("CePerOID2")]
        public ICollection<Othodi> Othodis { get; set; }
        [ForeignKey("CePerOID3")]
        public ICollection<Otbrakovka> Otbrakovkas { get; set; }


    }
}
