using GMS.Configuration;
using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace GMS.Data
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }



          


            







            modelBuilder.ApplyConfiguration(new GradConfiguration());
            modelBuilder.ApplyConfiguration(new SpolConfiguration());
            modelBuilder.ApplyConfiguration(new ClanarinaConfiguration());
            modelBuilder.ApplyConfiguration(new KorisnikConfiguration());
            modelBuilder.ApplyConfiguration(new Korisnik_ClanarinaConfiguration());
            modelBuilder.ApplyConfiguration(new DobavljacConfiguration());
            modelBuilder.ApplyConfiguration(new KateogorijaConfiguration());
            modelBuilder.ApplyConfiguration(new SuplementConfiguration());
            modelBuilder.ApplyConfiguration(new RecenzijaConfiguration());
            modelBuilder.ApplyConfiguration(new TrenerConfiguration());
            modelBuilder.ApplyConfiguration(new SeminarConfiguration());
            modelBuilder.ApplyConfiguration(new NutricionistConfiguration());
            modelBuilder.ApplyConfiguration(new Nutricionist_SeminarConfiguration());
            modelBuilder.ApplyConfiguration(new Trener_SeminarConfiguration());
            modelBuilder.ApplyConfiguration(new FAQConfiguration());
            modelBuilder.ApplyConfiguration(new NarudzbaConfiguration());
            modelBuilder.ApplyConfiguration(new NarudzbaStavkaConfiguration());
            modelBuilder.ApplyConfiguration(new UlogaConfiguration());
            modelBuilder.ApplyConfiguration(new Korisnik_UlogaConfiguration());
            modelBuilder.ApplyConfiguration(new PrisustvoConfiguration());
        }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Spol> Spol { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Korisnik_Clanarina> Korisnik_Clanarina { get; set; }
        public DbSet<Clanarina> Clanarina { get; set; }
        public DbSet<FAQ> FAQ { get; set; }
        public DbSet<Trener> Trener { get; set; }
        public DbSet<Korisnik_Trener> Korisnik_Trener { get; set; }
        public DbSet<Seminar> Seminar { get; set; }
        public DbSet<Trener_Seminar> Trener_Seminar { get; set; }
        public DbSet<Nutricionist> Nutricionist { get; set; }
        public DbSet<Korisnik_Nutricionist> Korisnik_Nutricionst { get; set; }
        public DbSet<Nutricionist_Seminar> Nutricionist_Seminar { get; set; }
        public DbSet<Suplement> Suplement { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<Narudzba_Stavka> Narudzba_Stavka { get; set; }
        public DbSet<Recenzija> Recenzija { get; set; }
        public DbSet<Dobavljac> Dobavljac { get; set; }
        public DbSet<Kategorija> Kategorija { get; set; }
        public DbSet<Uloga> Uloga { get; set; }
        public DbSet<Korisnik_Uloga> Korisnik_Uloga { get; set; }
        public DbSet<Prisustvo> Prisustvo { get; set; }



        public ApplicationDbContext(
            DbContextOptions options) : base(options)
        {
        }
    }
}
