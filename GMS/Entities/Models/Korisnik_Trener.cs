using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Entities.Models
{
    public class Korisnik_Trener
    {
        [Key]
        public int Korisnik_TrenerID { get; set; }

        [ForeignKey(nameof(Korisnik))]
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }

        [ForeignKey(nameof(Trener))]
        public int TrenerID { get; set; }
        public Trener Trener { get; set; }
        public DateTime DatumTermina { get; set; }
        public int ZakazanoSati { get; set; }
    }
}
