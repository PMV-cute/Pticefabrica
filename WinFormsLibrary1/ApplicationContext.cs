using Microsoft.EntityFrameworkCore;
using WinFormsLibrary1.Entity;
using System;

namespace WinFormsLibrary1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<CehProizvMelanja> CehProizvMelanja { get; set; }
        public DbSet<CehSortEggs> CehSortEggs { get; set; }
        public DbSet<Chicken> Chicken { get; set; }
        public DbSet<ComplexProizvodstvaEggs> ComplexProizvodstvaEggs { get; set; }
        public DbSet<Fabrikat> Fabrikat { get; set; }
        public DbSet<Incubator> Incubator { get; set; }
        public DbSet<Melanj> Melanj { get; set; }
        public DbSet<OtbrakovkaEggs> OtbrakovkaEggs { get; set; }
        public DbSet<PartiyaEggsRodClass> PartiyaEggsRodClass { get; set; }
        public DbSet<PartiyaMolodnyaka> PartiyaMolodnyaka { get; set; }
        public DbSet<PartiyaTovarnEggs> PartiyaTovarnEggs { get; set; }
        public DbSet<PartiyaVzrosloyChicken> PartiyaVzrosloyChicken { get; set; }
        public DbSet<PartiyaEggs> PartiyaEggs { get; set; }
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
            // Значение по умолчанию, можно сделать и вызов функции но я хз как (getdate())
            modelBuilder.Entity<Incubator>().Property(s => s.FreeOrNotFree).HasDefaultValue(true);

            modelBuilder.Entity<PartiyaEggsRodClass>().Property(s => s.FreeOrNotFree).HasDefaultValue(true);

            modelBuilder.Entity<Reproductor>().Property(s => s.KolvoB).HasDefaultValue(0);
            modelBuilder.Entity<Reproductor>().Property(s => s.KolvoN).HasDefaultValue(0);
            modelBuilder.Entity<Reproductor>().Property(s => s.maxB).HasDefaultValue(200);
            modelBuilder.Entity<Reproductor>().Property(s => s.maxN).HasDefaultValue(1000);



            modelBuilder.Entity<PartiyaMolodnyaka>().Property(s => s.FreeOrNotFree).HasDefaultValue(true);

            modelBuilder.Entity<Ptichnic>().Property(s => s.FreeOrNotFree).HasDefaultValue(true);

            modelBuilder.Entity<PartiyaVzrosloyChicken>().Property(s => s.FreeOrNotFree).HasDefaultValue(true);

            modelBuilder.Entity<UPK>().Property(s => s.FreeOrNotFree).HasDefaultValue(true);

            modelBuilder.Entity<ComplexProizvodstvaEggs>().Property(s => s.FreeOrNotFree).HasDefaultValue(true);
            modelBuilder.Entity<ComplexProizvodstvaEggs>().Property(s => s.Pfeed).HasDefaultValue(false);
            modelBuilder.Entity<ComplexProizvodstvaEggs>().Property(s => s.Pwater).HasDefaultValue(false);
            modelBuilder.Entity<ComplexProizvodstvaEggs>().Property(s => s.Cikl).HasDefaultValue(0);
            modelBuilder.Entity<ComplexProizvodstvaEggs>().Property(s => s.CiklMax).HasDefaultValue(10);

            modelBuilder.Entity<PartiyaEggs>().Property(s => s.FreeOrNotFree).HasDefaultValue(true);

            modelBuilder.Entity<OtbrakovkaEggs>().Property(s => s.FreeOrNotFree).HasDefaultValue(true);

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
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Pticefabrica;Username=postgres;Password=maksimka09");
        }
        
    }
}
