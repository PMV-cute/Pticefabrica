using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class PartiyaVzrosloyChicken
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Npart { get; set; }
        [Required]
        public string TypeChiсken { get; set; }
        public int KolvoB { get; set; }
        public int KolvoN { get; set; }
        public int? PtID2 { get; set; }

        // public PartiyaRemontnayaVzrosloyChicken PartiyaRemontnayaVzrosloyChicken { get; set; }
        // public PartiyaBr PartiyaBr { get; set; }
        // public PartiyaNes PartiyaNes { get; set; }

    }
}
