using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace WinFormsLibrary1.Entity
{
    public class Pticefabrica
    {
        [Key]
        public int Number { get; set; }
        public string Addres { get; set; }
        public string Name { get; set; }
        Reproductor Reproductor = new Reproductor();
        Ptichnic ptichnic = new Ptichnic();
        Incubator Incubator = new Incubator();
        CehSortEggs cehSortEggs = new CehSortEggs();
        ComplexProizvodstvaEggs ComplexProizvodstvaEggs = new ComplexProizvodstvaEggs();
        CehProizvMelanja CehProizvMelanja = new CehProizvMelanja();
        UPK UPK = new UPK();
    }
}
