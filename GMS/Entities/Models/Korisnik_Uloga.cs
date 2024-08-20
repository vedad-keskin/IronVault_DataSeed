using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Entities.Models
{
    public class Korisnik_Uloga
    {
        [Key]
        public int Korisnik_UlogaID { get; set; }

        [ForeignKey(nameof(Korisnik))]
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }

        [ForeignKey(nameof(Uloga))]
        public int UlogaID { get; set; }
        public Uloga Uloga { get; set; }
        public DateTime DatumIzmjene { get; set; }
    }
}
