using Microsoft.EntityFrameworkCore;
using WinFormsLibrary1.Entity;
using System;

namespace WinFormsLibrary1
{
    public class ApplicationContext : DbContext
    {
        //public DbSet<Broyler> Broyler { get; set; }
        public DbSet<CehPererabotkiOthodov> CehPererabotkiOthodov { get; set; }
        public DbSet<CehProizvMelanja> CehProizvMelanja { get; set; }
        public DbSet<CehSortEggs> CehSortEggs { get; set; }
        public DbSet<Chicken> Chicken { get; set; }
        public DbSet<ComplexProizvodstvaEggs> ComplexProizvodstvaEggs { get; set; }
        public DbSet<Fabrikat> Fabrikat { get; set; }
        public DbSet<Incubator> Incubator { get; set; }
        public DbSet<Melanj> Melanj { get; set; }
        public DbSet<NegodnayaChicken> NegodnayaChicken { get; set; }
        public DbSet<Otbrakovka> Otbrakovka { get; set; }
        public DbSet<OtbrakovkaEggs> OtbrakovkaEggs { get; set; }
        public DbSet<Othodi> Othodi { get; set; }
        public DbSet<PartiyaEggsRodClass> PartiyaEggsRodClass { get; set; }
        public DbSet<PartiyaMolodnyaka> PartiyaMolodnyaka { get; set; }
        public DbSet<PartiyaRemontnayaVzrosloyChicken> PartiyaRemontnayaVzrosloyChicken { get; set; }
        public DbSet<PartiyaTovarnEggs> PartiyaTovarnEggs { get; set; }
        public DbSet<PartiyaVzrosloyChicken> PartiyaVzrosloyChicken { get; set; }
        public DbSet<Ptichnic> Ptichnic { get; set; }
        public DbSet<Reproductor> Reproductor { get; set; }
        public DbSet<UPK> UPK { get; set; }
        public DbSet<LogPas> LogPas { get; set; } // Логины и пароли для входа в аккаунт
        /*
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //modelBuilder.Entity<Broyler>().HasIndex(s => s.TypeChiсken).IsUnique(); //Работает и делает поля уникальными
            //modelBuilder.Entity<Melanj>().Property(s => s.Ntari).HasDefaultValue(123); // Значение по умолчанию, можно сделать и вызов функции но я хз как (getdate())
        }

        /*
        public static DbContextOptions<ApplicationContext> GetDb()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            return optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Pticefabrica1;Username=postgres;Password=maksimka09").Options;
        }
        */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Pticefabrica1;Username=postgres;Password=maksimka09");
        }
        
    }
}
