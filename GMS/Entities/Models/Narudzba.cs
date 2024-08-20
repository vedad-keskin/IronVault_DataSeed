using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Entities.Models
{
    public class Narudzba
    {
        [Key]
        public int NarudzbaID { get; set; }

        [ForeignKey(nameof(Korisnik))]
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }

        public string? Sifra { get; set; }

        public DateTime DatumVrijemeNarudzbe { get; set; }
        public bool? Status { get; set; }
        public bool? Otkazano { get; set; }

    }
}
