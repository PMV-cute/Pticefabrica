﻿using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class NegodnayaChicken
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public int KolvoB { get; set; }
        public int KolvoN { get; set; }
        public int? CePerOID { get; set; }
        public int? CoPrID3 { get; set; }
    }
}
