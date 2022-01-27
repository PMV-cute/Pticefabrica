using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsLibrary1.Entity
{
    public class PartiyaRemontnayaVzrosloyChicken
    {
        [Key]
        public int ID { get; set; }
        public string TypeChiсken { get; set; }
        public int Kolvo { get; set; }
        [ForeignKey("PartiyaVzrosloyChicken")]
        public int PaVzChID { get; set; }

        public PartiyaVzrosloyChicken PartiyaVzrosloyChicken { get; set; }

        public int? RepID2 { get; set; }


    }
}
