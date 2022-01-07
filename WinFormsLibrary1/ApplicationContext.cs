using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace WinFormsLibrary1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Broyler> Broylers { get; set; }
        //public DbSet<UPK> UPK { get; set; }

        //public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        //{
         //  Database.EnsureCreated();
           //Database.Migrate();
           //Context.AddDb(this);
            //
        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Cleaning;Username=postgres;Password=maksimka09");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Broyler>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.TypeChiсken).IsRequired();
            });
        }
        public static DbContextOptions<ApplicationContext> GetDb()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            return optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Cleaning;Username=postgres;Password=maksimka09").Options;
        }
    }
}
