using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class ClanarinaConfiguration : IEntityTypeConfiguration<Clanarina>
    {
        public void Configure(EntityTypeBuilder<Clanarina> builder)
        {
            builder.HasData(
                 new Clanarina
                 {
                     ClanarinaID = 1,
                     Naziv = "Fit Plus",
                     Cijena = 50,
                     Opis = "Teretane predstavljaju oazu zdravlja pružajući nam prostor gdje možemo ojačati svoje tijelo i smanjiti stres. Članstvo u teretani nije samo ulaganje u tjelesno zdravlje već i putovanje prema boljoj verziji sebe."
                 },
                 new Clanarina
                 {
                     ClanarinaID = 2,
                     Naziv = "Student Fit Plus",
                     Cijena = 40,
                     Opis = "Studentska članarina u teretani nije samo investicija u tjelesno zdravlje, već i u opću dobrobit studenata. Zahvaljujući ovim povlasticama, teretane postaju pristupačne za studente svih financijskih mogućnosti, čime se stvara zdraviji i sretniji studentski život. Zbog toga mi nudimo popust od čak 20% za sve studente!"
                 },
                 new Clanarina
                 {
                     ClanarinaID = 3,
                     Naziv = "Partner Fit Duo",
                     Cijena = 25,
                     Opis = "Teretane nude posebne članarine za parove koje omogućuju partnerima da zajedno uživaju u prednostima vježbanja. Podijelite iznos jedne članarine i uživajte u jačanju tijela i uma!"
                 });

        }
    }
}
