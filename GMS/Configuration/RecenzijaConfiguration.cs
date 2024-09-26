using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class RecenzijaConfiguration : IEntityTypeConfiguration<Recenzija>
    {
        public void Configure(EntityTypeBuilder<Recenzija> builder)
        {
            builder.HasData(
                new Recenzija
                {
                    RecenzijaID = 1,
                    KorisnikID = 1,
                    SuplementID = 1,
                    Ocjena = 5,
                    Opis = "Prozivod mi je mnogo pomogao, tople preporuke."

                },
                new Recenzija
                {
                    RecenzijaID = 2,
                    KorisnikID = 3,
                    SuplementID = 1,
                    Ocjena = 4,
                    Opis = "Dobar proizvod, samo je dostava trajala duže od dogovorenog."

                },
                new Recenzija
                {
                    RecenzijaID = 3,
                    KorisnikID = 1,
                    SuplementID = 2,
                    Ocjena = 5,
                    Opis = "Odličan proizvod."

                }
                ,
                new Recenzija
                {
                    RecenzijaID = 4,
                    KorisnikID = 3,
                    SuplementID = 2,
                    Ocjena = 2,
                    Opis = "Loš ukus."

                },
                new Recenzija
                {
                    RecenzijaID = 5,
                    KorisnikID = 3,
                    SuplementID = 3,
                    Ocjena = 1,
                    Opis = "Katastrofa."

                },
                new Recenzija
                {
                    RecenzijaID = 6,
                    KorisnikID = 1,
                    SuplementID = 4,
                    Ocjena = 4,
                    Opis = "Ukus nije baš najbolji ali je progres očigledan."

                },
                new Recenzija
                {
                    RecenzijaID = 7,
                    KorisnikID = 3,
                    SuplementID = 5,
                    Ocjena = 5,
                    Opis = "Odličan suplement."

                },
                new Recenzija
                {
                    RecenzijaID = 8,
                    KorisnikID = 1,
                    SuplementID = 6,
                    Ocjena = 4,
                    Opis = "Jako dobar."

                }
               




                );

        }
    }
}
