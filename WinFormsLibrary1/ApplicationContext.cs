﻿using Microsoft.EntityFrameworkCore;
using WinFormsLibrary1.Entity;
using System;
namespace WinFormsLibrary1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Broyler> Broyler { get; set; }
        public DbSet<CehPererabotkiOthodov> CehPererabotkiOthodov { get; set; }
        public DbSet<Melanj> Melanj { get; set; }
        public DbSet<LogPas> LogPas { get; set; } // Логины и пароли для входа в аккаунт
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
            Database.Migrate();
            Context.AddDb(this);

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //modelBuilder.Entity<Broyler>().HasIndex(s => s.TypeChiсken).IsUnique(); //Работает и делает поля уникальными
            //modelBuilder.Entity<Melanj>().Property(s => s.Ntari).HasDefaultValue(123); // Значение по умолчанию, можно сделать и вызов функции но я хз как (getdate())
        }

        public static DbContextOptions<ApplicationContext> GetDb()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            return optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Pticefabrica;Username=postgres;Password=maksimka09").Options;
        }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Pticefabrica;Username=postgres;Password=maksimka09");
        }
        */
    }
}
