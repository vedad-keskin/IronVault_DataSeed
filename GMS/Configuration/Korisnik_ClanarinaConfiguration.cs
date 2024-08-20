using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class Korisnik_ClanarinaConfiguration : IEntityTypeConfiguration<Korisnik_Clanarina>
    {
        public void Configure(EntityTypeBuilder<Korisnik_Clanarina> builder)
        {
            builder.HasData(
                new Korisnik_Clanarina
                {
                    Korisnik_ClanarinaID = 1,
                    KorisnikID = 1,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2023, 09, 01, 9, 15, 0),
                    DatumIsteka = new DateTime(2023, 10, 01, 9, 15, 0)
                },
                new Korisnik_Clanarina
                {
                    Korisnik_ClanarinaID = 2,
                    KorisnikID = 1,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2023, 10, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2023, 11, 01, 7, 15, 0)
                },
                new Korisnik_Clanarina
                {
                    Korisnik_ClanarinaID = 3,
                    KorisnikID = 1,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2023, 11, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2023, 12, 01, 7, 15, 0)
                }
                ,
                new Korisnik_Clanarina
                {
                    Korisnik_ClanarinaID = 4,
                    KorisnikID = 1,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2023, 12, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2024, 01, 01, 7, 15, 0)
                }
                ,
                new Korisnik_Clanarina
                {
                    Korisnik_ClanarinaID = 5,
                    KorisnikID = 1,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2024, 01, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2024, 02, 01, 7, 15, 0)
                }
                ,
                new Korisnik_Clanarina
                {
                    Korisnik_ClanarinaID = 6,
                    KorisnikID = 1,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2024, 02, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2024, 03, 01, 7, 15, 0)
                }
                ,
                new Korisnik_Clanarina
                {
                    Korisnik_ClanarinaID = 7,
                    KorisnikID = 1,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2024, 04, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2024, 05, 01, 7, 15, 0)
                }
                 ,
                new Korisnik_Clanarina
                {
                    Korisnik_ClanarinaID = 8,
                    KorisnikID = 1,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2024, 05, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2024, 06, 01, 7, 15, 0)
                }
                 ,
                new Korisnik_Clanarina
                {
                    Korisnik_ClanarinaID = 9,
                    KorisnikID = 1,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2024, 06, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2024, 07, 01, 7, 15, 0)
                }
                 ,
                new Korisnik_Clanarina
                {
                    Korisnik_ClanarinaID = 10,
                    KorisnikID = 1,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2024, 07, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2024, 08, 01, 7, 15, 0)
                }
                 ,
                new Korisnik_Clanarina
                {
                    Korisnik_ClanarinaID = 11,
                    KorisnikID = 2,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2024, 06, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2024, 07, 01, 7, 15, 0)
                }
                 ,
                new Korisnik_Clanarina
                {
                    Korisnik_ClanarinaID = 12,
                    KorisnikID = 2,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2024, 07, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2024, 08, 01, 7, 15, 0)
                }
                ,
                new Korisnik_Clanarina
                {
                    Korisnik_ClanarinaID = 13,
                    KorisnikID = 2,
                    ClanarinaID = 2,
                    DatumUplate = new DateTime(2024, 08, 01, 7, 15, 0),
                    DatumIsteka = new DateTime(2024, 09, 01, 7, 15, 0)
                }


                );
        }
    }
}
