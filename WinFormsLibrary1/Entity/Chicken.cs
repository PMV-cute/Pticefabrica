using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WinFormsLibrary1.Entity
{
    public class Chicken
    {
        [Key] // Первичный ключ
        public int ID { get; set; }
        [Required] // NOT NULL
        [MaxLength(100)] public string TypeChiсken { get; set; } // Максимальная длинна


    }
}
