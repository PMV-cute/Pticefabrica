using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class PartiyaEggsRodClass
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Npart { get; set; }

        public int Kolvo { get; set; }
        public int? RepID { get; set; }
        public int? IncID2 { get; set; }

        //public Reproductor Reproductor { get; set; }
        public Incubator Incubator { get; set; }
    }
}
