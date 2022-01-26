using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class PartiyaMolodnyaka
    {
        [Key]
        public int ID { get; set; }


        public int KolvoB { get; set; }
        public int KolvoN { get; set; }

        public int? IncID { get; set; }
        public int? PtID { get; set; }
    }
}
