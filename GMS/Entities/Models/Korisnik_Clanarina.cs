using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Entities.Models
{
    public class Korisnik_Clanarina
    {
        [Key]
        public int Korisnik_ClanarinaID { get; set; }

        [ForeignKey(nameof(Korisnik))]
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }

        [ForeignKey(nameof(Clanarina))]
        public int ClanarinaID { get; set; }
        public Clanarina Clanarina { get; set; }

        public DateTime DatumUplate { get; set; }     
        public DateTime DatumIsteka { get; set; }     
    }
}
