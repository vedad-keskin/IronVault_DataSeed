using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class PrisustvoConfiguration : IEntityTypeConfiguration<Prisustvo>
    {
        public void Configure(EntityTypeBuilder<Prisustvo> builder)
        {
            builder.HasData(
                 new Prisustvo
                 {
                     PrisustvoID = 1,
                     KorisnikID = 1,
                     DatumVrijemeUlaska = new DateTime(2024, 03, 03, 18, 0, 0),
                     DatumVrijemeIzlaska = new DateTime(2024, 03, 03, 19, 0, 0),
                 },
                 new Prisustvo
                 {
                     PrisustvoID = 2,
                     KorisnikID = 1,
                     DatumVrijemeUlaska = new DateTime(2024, 03, 05, 20, 0, 0),
                     DatumVrijemeIzlaska = new DateTime(2024, 03, 05, 21, 0, 0),
                 }
                 , new Prisustvo
                 {
                     PrisustvoID = 3,
                     KorisnikID = 1,
                     DatumVrijemeUlaska = new DateTime(2024, 03, 08, 19, 0, 0),
                     DatumVrijemeIzlaska = new DateTime(2024, 03, 08, 21, 0, 0),
                 }
                 ,
                 new Prisustvo
                 {
                     PrisustvoID = 4,
                     KorisnikID = 1,
                     DatumVrijemeUlaska = new DateTime(2024, 04, 07, 19, 0, 0),
                     DatumVrijemeIzlaska = new DateTime(2024, 04, 07, 21, 0, 0), // 6
                 }
                 ,
                 new Prisustvo
                 {
                     PrisustvoID = 5,
                     KorisnikID = 1,
                     DatumVrijemeUlaska = new DateTime(2024, 04, 09, 19, 0, 0),
                     DatumVrijemeIzlaska = new DateTime(2024, 04, 09, 22, 0, 0), // 9
                 }
                 ,
                 new Prisustvo
                 {
                     PrisustvoID = 6,
                     KorisnikID = 1,
                     DatumVrijemeUlaska = new DateTime(2024, 04, 13, 19, 0, 0),
                     DatumVrijemeIzlaska = new DateTime(2024, 04, 13, 22, 0, 0), // Vedad - 12
                 }
                 ,
                 new Prisustvo
                 {
                     PrisustvoID = 7,
                     KorisnikID = 1,
                     DatumVrijemeUlaska = new DateTime(2024, 04, 16, 19, 0, 0),
                     DatumVrijemeIzlaska = new DateTime(2024, 04, 16, 22, 0, 0), // Vedad - 15
                 }
                 ,
                 new Prisustvo
                 {
                     PrisustvoID = 8,
                     KorisnikID = 1,
                     DatumVrijemeUlaska = new DateTime(2024, 04, 21, 19, 0, 0),
                     DatumVrijemeIzlaska = new DateTime(2024, 04, 21, 22, 0, 0), // Vedad - 18
                 }
                 ,
                 new Prisustvo
                 {
                     PrisustvoID = 9,
                     KorisnikID = 1,
                     DatumVrijemeUlaska = new DateTime(2024, 04, 25, 19, 0, 0),
                     DatumVrijemeIzlaska = new DateTime(2024, 04, 25, 22, 0, 0), // Vedad - 21
                 }
                 ,
                 new Prisustvo
                 {
                     PrisustvoID = 10,
                     KorisnikID = 2,
                     DatumVrijemeUlaska = new DateTime(2024, 04, 26, 19, 0, 0),
                     DatumVrijemeIzlaska = new DateTime(2024, 04, 26, 22, 0, 0), // Amel - 3
                 }
                 ,
                 new Prisustvo
                 {
                     PrisustvoID = 11,
                     KorisnikID = 2,
                     DatumVrijemeUlaska = new DateTime(2024, 04, 29, 19, 0, 0),
                     DatumVrijemeIzlaska = new DateTime(2024, 04, 29, 22, 0, 0), // Amel - 6
                 }
                 ,
                 new Prisustvo
                 {
                     PrisustvoID = 12,
                     KorisnikID = 2,
                     DatumVrijemeUlaska = new DateTime(2024, 05, 03, 19, 0, 0),
                     DatumVrijemeIzlaska = new DateTime(2024, 05, 03, 22, 0, 0), // Amel - 9
                 }
                 ,
                 new Prisustvo
                 {
                     PrisustvoID = 13,
                     KorisnikID = 2,
                     DatumVrijemeUlaska = new DateTime(2024, 05, 09, 19, 0, 0),
                     DatumVrijemeIzlaska = new DateTime(2024, 05, 09, 22, 0, 0), // Amel - 12
                 }
                 ,
                 new Prisustvo
                 {
                     PrisustvoID = 14,
                     KorisnikID = 1,
                     DatumVrijemeUlaska = new DateTime(2024, 09, 22, 20, 52, 0),
                 }
             
                 ,
                 new Prisustvo
                 {
                     PrisustvoID = 15,
                     KorisnikID = 3,
                     DatumVrijemeUlaska = new DateTime(2024, 09, 22, 17, 12, 0),
                 }


                 );

        }
    }
}
