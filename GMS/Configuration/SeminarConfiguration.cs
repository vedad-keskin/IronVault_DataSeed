using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class SeminarConfiguration : IEntityTypeConfiguration<Seminar>
    {
        public void Configure(EntityTypeBuilder<Seminar> builder)
        {
            builder.HasData(
                new Seminar
                {
                    SeminarID = 1,
                    Tema = "Metabolički Sindrom",
                    Predavac = "Maja Gradinjan",
                    Datum = new DateTime(2022, 12, 10, 9, 15, 0)
                },
                new Seminar
                {
                    SeminarID = 2,
                    Tema = "Pravilna prehrana u službi zdravlja i sportskog razvoja",
                    Predavac = "Darija Topić",
                    Datum = new DateTime(2023, 04, 12, 9, 15, 0)
                },
                new Seminar
                {
                    SeminarID = 3,
                    Tema = "Snaga u vama",
                    Predavac = "Tatjana Popović",
                    Datum = new DateTime(2020, 01, 10, 9, 15, 0)
                },
                new Seminar
                {
                    SeminarID = 4,
                    Tema = "CrossFit Level 3",
                    Predavac = "Ivan Račić",
                    Datum = new DateTime(2019, 12, 10, 9, 15, 0)
                },
                new Seminar
                {
                    SeminarID = 5,
                    Tema = "Pro Bodybuilding",
                    Predavac = "Petar Klančir",
                    Datum = new DateTime(2017, 06, 10, 9, 15, 0)
                },
                new Seminar
                {
                    SeminarID = 6,
                    Tema = "Samoodbrana",
                    Predavac = "Almir Tunić",
                    Datum = new DateTime(2022, 01, 01, 12, 15, 0)

                }) ; 
                
        }
    }
}
