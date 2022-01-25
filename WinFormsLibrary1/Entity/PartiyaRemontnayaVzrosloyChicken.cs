using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsLibrary1.Entity
{
    public class PartiyaRemontnayaVzrosloyChicken
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Npart { get; set; }
        public int KolvoB { get; set; }
        public int KolvoN { get; set; }
        [ForeignKey("PartiyaVzrosloyChicken")]
        public int PaVzChID { get; set; }

        public PartiyaVzrosloyChicken PartiyaVzrosloyChicken { get; set; }

        public int? RepID2 { get; set; }


    }
}
