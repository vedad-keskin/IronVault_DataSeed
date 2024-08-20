using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Entities.Models
{
    public class Prisustvo
    {
        [Key]
        public int PrisustvoID { get; set; }

        [ForeignKey(nameof(Korisnik))]
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }

        public DateTime DatumVrijemeUlaska { get; set; }
        public DateTime? DatumVrijemeIzlaska { get; set; }
    }
}
