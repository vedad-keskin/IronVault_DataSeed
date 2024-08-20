using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class UlogaConfiguration : IEntityTypeConfiguration<Uloga>
    {
        public void Configure(EntityTypeBuilder<Uloga> builder)
        {
            builder.HasData(
                 new Uloga
                 {
                     UlogaID = 1,
                     Naziv = "Administrator",
                     Opis = "Administrator ima sve permisije na aplikaciji."
                 },
                 new Uloga
                 {
                     UlogaID = 2,
                     Naziv = "User",
                     Opis = "User ima samo korisničke permisije."
                 });

        }
    }
}
