using System.ComponentModel.DataAnnotations;
using System;

namespace WinFormsLibrary1.Entity
{
    public class Incubator
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        [MaxLength(10)]
        public int NIncubator { get; set; }
        [Required]
        public string TypeChiсken { get; set; }
        [Required]
        public DateTime DatePostupleniya { get; set; }
        public int Temp; //Не нада метод
        public int vlagnost; //Не нада метод
        public int time; //Не нада метод
        public void Perecladka() { }
        public void Viderjka() { }
        public void OtborzdorovChiken() { }
        public void Vakcinaciya() { }
        public void VipuscPartii() { }
    }
}
