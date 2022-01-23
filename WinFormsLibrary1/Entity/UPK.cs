using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class UPK
    {
        [Key]
        public int ID { get; set; }
        
        public int KolvoB { get; set; }
        public void Uboy() { }

        public void Podgotovca() { }//вмете с обдиркой

        public void SortAndRubka() { }

        public void Upacovca() { }

        public void VipuscPartii() { }
    }
}
