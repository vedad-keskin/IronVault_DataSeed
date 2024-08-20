using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMS.Configuration
{
    public class NarudzbaStavkaConfiguration : IEntityTypeConfiguration<Narudzba_Stavka>
    {
        public void Configure(EntityTypeBuilder<Narudzba_Stavka> builder)
        {
            builder.HasData(
                new Narudzba_Stavka
                {
                    Narudzba_StavkaID = 1,
                    NarudzbaID = 1,
                    SuplementID = 1,
                    Kolicina = 2,

                },
                new Narudzba_Stavka
                {
                    Narudzba_StavkaID = 2,
                    NarudzbaID = 1,
                    SuplementID = 4,
                    Kolicina = 1,
                },
                new Narudzba_Stavka
                {
                    Narudzba_StavkaID = 3,
                    NarudzbaID = 2,
                    SuplementID = 3,
                    Kolicina = 2,
                },
                new Narudzba_Stavka
                {
                    Narudzba_StavkaID = 4,
                    NarudzbaID = 2,
                    SuplementID = 9,
                    Kolicina = 3,
                }
                ,
                new Narudzba_Stavka
                {
                    Narudzba_StavkaID = 5,
                    NarudzbaID = 3,
                    SuplementID = 11,
                    Kolicina = 2,
                }
                ,
                new Narudzba_Stavka
                {
                    Narudzba_StavkaID = 6,
                    NarudzbaID = 4,
                    SuplementID = 16,
                    Kolicina = 1,
                }
                ,
                new Narudzba_Stavka
                {
                    Narudzba_StavkaID = 7,
                    NarudzbaID = 4,
                    SuplementID = 7,
                    Kolicina = 1,
                }
                ,
                new Narudzba_Stavka
                {
                    Narudzba_StavkaID = 8, 
                    NarudzbaID = 5,
                    SuplementID = 2,
                    Kolicina = 2,
                }
                ,
                new Narudzba_Stavka
                {
                    Narudzba_StavkaID = 9,
                    NarudzbaID = 5,
                    SuplementID = 8,
                    Kolicina = 1,
                }
            );
        }
    }
}
