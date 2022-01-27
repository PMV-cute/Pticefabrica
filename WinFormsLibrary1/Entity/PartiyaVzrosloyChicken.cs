﻿using System.ComponentModel.DataAnnotations;
using System;
namespace WinFormsLibrary1.Entity
{
    public class PartiyaVzrosloyChicken
    {
        [Key]
        public int ID { get; set; }
        public string TypeChiсken { get; set; }
        public int Kolvo { get; set; }
        public DateTime DateForm { get; set; }
        public int? PtID2 { get; set; }

        public int? CoPrID { get; set; }
        public int? UPKID { get; set; }

        // public PartiyaRemontnayaVzrosloyChicken PartiyaRemontnayaVzrosloyChicken { get; set; }
        // public PartiyaBr PartiyaBr { get; set; }
        // public PartiyaNes PartiyaNes { get; set; }

    }
}
