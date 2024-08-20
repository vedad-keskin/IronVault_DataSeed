using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class DobavljacConfiguration : IEntityTypeConfiguration<Dobavljac>
    {
        public void Configure(EntityTypeBuilder<Dobavljac> builder)
        {
            builder.HasData(
                new Dobavljac
                {
                    DobavljacID = 1,
                    Naziv = "MUSCLE FREAK",
                },
                new Dobavljac
                {
                    DobavljacID = 2,
                    Naziv = "MUSCLETECH",
                },
                new Dobavljac
                {
                    DobavljacID = 3,
                    Naziv = "OPTIMUM NUTRITION",
                },
                new Dobavljac
                {
                    DobavljacID = 4,
                    Naziv = "SELF OMNINUTRITION",
                },
                new Dobavljac
                {
                    DobavljacID = 5,
                    Naziv = "CW-CHEMICAL WARFARE",
                },
                new Dobavljac
                {
                    DobavljacID = 6,
                    Naziv = "BSN",
                },
                new Dobavljac
                {
                    DobavljacID = 7,
                    Naziv = "CELLUCOR",
                },
                new Dobavljac
                {
                    DobavljacID = 8,
                    Naziv = "EVOLITE",
                },
                new Dobavljac
                {
                    DobavljacID = 9,
                    Naziv = "SUPERIOR",
                },
                new Dobavljac
                {
                    DobavljacID = 10,
                    Naziv = "TESLA",
                });
                
        }
    }
}
