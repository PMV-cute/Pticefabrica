using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class Othodi
    {
        [Key]
        public int ID { get; set; }
        
        public string kolvo { get; set; }

        public int? CehPrMID3 { get; set; }
        public int? CePerOID2 { get; set; }
    }
}
