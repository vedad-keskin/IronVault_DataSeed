using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class Nutricionist_SeminarConfiguration : IEntityTypeConfiguration<Nutricionist_Seminar>
    {
        public void Configure(EntityTypeBuilder<Nutricionist_Seminar> builder)
        {
            builder.HasData(
                new Nutricionist_Seminar
                {
                    Nutricionist_SeminarID = 1,
                    NutricionistID = 1,
                    SeminarID = 2
                },
                new Nutricionist_Seminar
                {
                    Nutricionist_SeminarID = 2,
                    NutricionistID = 1,
                    SeminarID = 3
                },
                new Nutricionist_Seminar
                {
                    Nutricionist_SeminarID = 3,
                    NutricionistID = 2,
                    SeminarID = 1
                },
                new Nutricionist_Seminar
                {
                    Nutricionist_SeminarID = 4,
                    NutricionistID = 2,
                    SeminarID = 3
                });
                
        }
    }
}
