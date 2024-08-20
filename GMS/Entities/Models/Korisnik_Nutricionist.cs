using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Entities.Models
{
    public class Korisnik_Nutricionist
    {
        [Key]
        public int Korisnik_NutricionistID { get; set; }

        [ForeignKey(nameof(Korisnik))]
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }

        [ForeignKey(nameof(Nutricionist))]
        public int NutricionistID { get; set; }
        public Nutricionist Nutricionist { get; set; }
        public DateTime DatumTermina { get; set; }
        public int ZakazanoSati { get; internal set; }
    }
}
