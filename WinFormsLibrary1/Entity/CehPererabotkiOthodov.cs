using System.ComponentModel.DataAnnotations;

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
        
    }
}
