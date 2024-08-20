using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class GradConfiguration : IEntityTypeConfiguration<Grad>
    {
        public void Configure(EntityTypeBuilder<Grad> builder)
        {
            builder.HasData(
                new Grad
                {
                    GradID = 1,
                    Naziv = "Banja Luka",
                },
                new Grad
                {
                    GradID = 2,
                    Naziv = "Bihać",
                },
                new Grad
                {
                    GradID = 3,
                    Naziv = "Bijeljina",
                },
                new Grad
                {
                    GradID = 4,
                    Naziv = "Bosnaska Krupa",
                },
                new Grad
                {
                    GradID = 5,
                    Naziv = "Cazin",
                },
                new Grad
                {
                    GradID = 6,
                    Naziv = "Čapljina",
                },
                new Grad
                {
                    GradID = 7,
                    Naziv = "Drventa",
                },
                new Grad
                {
                    GradID = 8,
                    Naziv = "Doboj",
                },
                new Grad
                {
                    GradID = 9,
                    Naziv = "Goražde",
                },
                new Grad
                {
                    GradID = 10,
                    Naziv = "Gračanica",
                },
                new Grad
                {
                    GradID = 11,
                    Naziv = "Gradačac",
                },
                new Grad
                {
                    GradID = 12,
                    Naziv = "Gradiška",
                },
                new Grad
                {
                    GradID = 13,
                    Naziv = "Konjic",
                },
                new Grad
                {
                    GradID = 14,
                    Naziv = "Laktaši",
                },
                new Grad
                {
                    GradID = 15,
                    Naziv = "Livno",
                },
                new Grad
                {
                    GradID = 16,
                    Naziv = "Lukavac",
                },
                new Grad
                {
                    GradID = 17,
                    Naziv = "Ljubuški",
                },
                new Grad
                {
                    GradID = 18,
                    Naziv = "Mostar",
                },
                new Grad
                {
                    GradID = 19,
                    Naziv = "Orašje",
                },
                new Grad
                {
                    GradID = 20,
                    Naziv = "Prijedor",
                },
                new Grad
                {
                    GradID = 21,
                    Naziv = "Prnjavor",
                },
                new Grad
                {
                    GradID = 22,
                    Naziv = "Sarajevo",
                },
                new Grad
                {
                    GradID = 23,
                    Naziv = "Srebrenik",
                },
                new Grad
                {
                    GradID = 24,
                    Naziv = "Stolac",
                },
                new Grad
                {
                    GradID = 25,
                    Naziv = "Široki Brijeg",
                },
                new Grad
                {
                    GradID = 26,
                    Naziv = "Travnik",
                },
                new Grad
                {
                    GradID = 27,
                    Naziv = "Tuzla",
                },
                new Grad
                {
                    GradID = 28,
                    Naziv = "Visoko",
                },
                new Grad
                {
                    GradID = 29,
                    Naziv = "Zavidovići",
                },
                new Grad
                {
                    GradID = 30,
                    Naziv = "Zenica",
                },
                new Grad
                {
                    GradID = 31,
                    Naziv = "Zvornik",
                },
                new Grad
                {
                    GradID = 32,
                    Naziv = "Živinice",
                },
                new Grad
                {
                    GradID = 33,
                    Naziv = "Donji Vakuf",
                },
                new Grad
                {
                    GradID = 34,
                    Naziv = "Zavidovići",
                });
        }
    }
}
