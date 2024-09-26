using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMS.Configuration
{
    public class NarudzbaConfiguration : IEntityTypeConfiguration<Narudzba>
    {
        public void Configure(EntityTypeBuilder<Narudzba> builder)
        {
            builder.HasData(
                new Narudzba
                {
                    NarudzbaID = 1,
                    KorisnikID = 1,
                    Sifra = "SIF-000-001",
                    DatumVrijemeNarudzbe = new DateTime(2023, 09, 01, 9, 15, 0),
                    Otkazano = false,
                    Status = false

                },
                new Narudzba
                {
                    NarudzbaID = 2,
                    KorisnikID = 2,
                    Sifra = "SIF-000-002",
                    DatumVrijemeNarudzbe = new DateTime(2023, 10, 01, 9, 15, 0),
                    Otkazano = false,
                    Status = false
                },
                new Narudzba
                {
                    NarudzbaID = 3,
                    KorisnikID = 1,
                    Sifra = "SIF-000-003",
                    DatumVrijemeNarudzbe = new DateTime(2023, 10, 04, 9, 15, 0),
                    Otkazano = false,
                    Status = false
                },
                new Narudzba
                {
                    NarudzbaID = 4,
                    KorisnikID = 2,
                    Sifra = "SIF-000-004",
                    DatumVrijemeNarudzbe = new DateTime(2023, 10, 09, 9, 15, 0),
                    Otkazano = true,
                    Status = false
                }
                ,
                new Narudzba
                {
                    NarudzbaID = 5,
                    KorisnikID = 1,
                    Sifra = "SIF-000-005",
                    DatumVrijemeNarudzbe = new DateTime(2024, 10, 07, 9, 15, 0),
                    Otkazano = false,
                    Status = false
                }
                ,
        new Narudzba
        {
            NarudzbaID = 6,
            KorisnikID = 3,
            Sifra = "SIF-000-006",
            DatumVrijemeNarudzbe = new DateTime(2024, 10, 08, 9, 15, 0),
            Otkazano = false,
            Status = false
        }

            );
        }
    }
}
