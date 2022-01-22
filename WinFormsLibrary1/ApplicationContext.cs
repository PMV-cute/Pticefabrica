using Microsoft.EntityFrameworkCore;
using WinFormsLibrary1.Entity;

namespace WinFormsLibrary1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Broyler> Broyler { get; set; }
        public DbSet<CehPererabotkiOthodov> CehPererabotkiOthodov { get; set; }
        public DbSet<LogPas> LogPas { get; set; } // Логины и пароли для входа в аккаунт
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
            Database.Migrate();
            Context.AddDb(this);

        }
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder) // Работает и делает поля уникальными
        {
            modelBuilder.Entity<Broyler>().HasIndex(s => s.TypeChiсken).IsUnique();
        }
        */
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
