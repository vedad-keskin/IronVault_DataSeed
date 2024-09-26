using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class FAQConfiguration : IEntityTypeConfiguration<FAQ>
    {
        public void Configure(EntityTypeBuilder<FAQ> builder)
        {
            builder.HasData(
                new FAQ
                {
                    FAQID = 1,
                    Pitanje = "Kako mogu zakazati termin kod trenera ili nutricioniste?",
                    Odgovor = "Zakazivanje termina vršite klikom 'Zakaži termin' u sekciji trenera ili nutricionista. Nakon zakazivanja termina trenera/nutricioniste isti će biti obavješten mail-om nakon čega će vam se on/ona javiti na prijavljeni e-mail ili broj telefona."
                },
                new FAQ
                {
                    FAQID = 2,
                    Pitanje = "Kako mogu naručiti suplement sa vaše aplikacije?",
                    Odgovor = "Naručivanje suplemenata vrište klikom 'Dodaj u korpu' u sekciji suplementi gdje se odabrani proizvodi prebacuju u sekciju korpa, nakon dodavanja odabranih suplemenata klikom na 'Kupi' u sekciji korpa ćete biti prebačeni u stripe servis gdje možete izvršiti kupovinu."
                },
                new FAQ
                {
                    FAQID = 3,
                    Pitanje = "Kako mogu ocjeniti suplement?",
                    Odgovor = "Recenzije suplemenata možete izvršiti samo nakon kupovine istog suplementa. Nakon kupovine suplementa, isti možete naći u sekciji 'Uplate' pod 'Kupljeni suplementi', gdje vam se nudi mogućnost ocjenjivanja suplementa ocjenom od 1 do 5, zajedno sa mogućnošću ostavljanja komentara na svoju ocjenu."
                },
                new FAQ
                {
                    FAQID = 4,
                    Pitanje = "Kako mogu povećati razinu svog profila?",
                    Odgovor = "Razinu povećavate svakih 10 sati provednih u teretani. Veća razina ne samo da govori o većem ličnom progresu nego povećavate svoje šanse za ostvarivanjem bonus nagrada poput besplatnih suplemenata, personalnih termina kod naših trenera i sl."
                },
                new FAQ
                {
                    FAQID = 5,
                    Pitanje = "Gdje mogu viditi podatke o personalnom napretku?",
                    Odgovor = "Sve informacije o svom profilu, zajedno sa razinom, vremenom provedenom u teretani, listi uplaćenih članarina, kupovina možete naći u sekciji 'Profil'."
                });
                
        }
    }
}
