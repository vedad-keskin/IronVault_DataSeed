using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class Korisnik_UlogaConfiguration : IEntityTypeConfiguration<Korisnik_Uloga>
    {
        public void Configure(EntityTypeBuilder<Korisnik_Uloga> builder)
        {
            builder.HasData(
                new Korisnik_Uloga
                {
                    Korisnik_UlogaID = 1,
                    KorisnikID = 1,
                    UlogaID = 1,
                    DatumIzmjene = new DateTime(2023, 10, 01, 7, 15, 0),
                },
                new Korisnik_Uloga
                {
                    Korisnik_UlogaID = 2,
                    KorisnikID = 1,
                    UlogaID = 2,
                    DatumIzmjene = new DateTime(2023, 10, 01, 7, 15, 0),
                },
                new Korisnik_Uloga
                {
                    Korisnik_UlogaID = 3,
                    KorisnikID = 2,
                    UlogaID = 1,
                    DatumIzmjene = new DateTime(2023, 10, 01, 7, 15, 0),
                },
                new Korisnik_Uloga
                {
                    Korisnik_UlogaID = 4,
                    KorisnikID = 2,
                    UlogaID = 2,
                    DatumIzmjene = new DateTime(2023, 10, 01, 7, 15, 0),
                },
                new Korisnik_Uloga
                {
                    Korisnik_UlogaID = 5,
                    KorisnikID = 3,
                    UlogaID = 2,
                    DatumIzmjene = new DateTime(2023, 10, 01, 7, 15, 0),
                },
                new Korisnik_Uloga
                {
                    Korisnik_UlogaID = 6,
                    KorisnikID = 4,
                    UlogaID = 2,
                    DatumIzmjene = new DateTime(2023, 10, 01, 7, 15, 0),
                }


                );
        }
    }
}
