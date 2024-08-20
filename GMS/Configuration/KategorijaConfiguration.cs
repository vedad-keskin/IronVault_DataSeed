using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class KateogorijaConfiguration : IEntityTypeConfiguration<Kategorija>
    {
        public void Configure(EntityTypeBuilder<Kategorija> builder)
        {
            builder.HasData(
                new Kategorija
                {
                    KategorijaID = 1,
                    Naziv = "Proteini",
                },
                new Kategorija
                {
                    KategorijaID = 2,
                    Naziv = "Amino kiseline",
                },
                new Kategorija
                {
                    KategorijaID = 3,
                    Naziv = "Preworkout",
                },
                new Kategorija
                {
                    KategorijaID = 4,
                    Naziv = "Mass gaineri",
                });
                
        }
    }
}
