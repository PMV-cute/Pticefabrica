using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsLibrary1.Entity
{
    public class UPK
    {
        [Key]
        public int ID { get; set; }
        
        public int KolvoB { get; set; }
        [ForeignKey("UPKID")]
        public ICollection<PartiyaBr> PartiyaBres { get; set; }
        [ForeignKey("UPKID2")]
        public ICollection<Fabrikat> Fabrikats { get; set; }
        [ForeignKey("UPKID3")]
        public ICollection<Otbrakovka> Otbrakovkas { get; set; }
        public void Uboy() { }

        public void Podgotovca() { }//вмете с обдиркой

        public void SortAndRubka() { }

        public void Upacovca() { }

        public void VipuscPartii() { }
    }
}
