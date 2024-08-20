using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Entities.Models
{
    public class Recenzija
    {
        [Key]
        public int RecenzijaID { get; set; }

        [ForeignKey(nameof(Korisnik))]
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }

        [ForeignKey(nameof(Suplement))]
        public int SuplementID { get; set; }
        public Suplement Suplement { get; set; }
        public int Ocjena { get; set; }

        public string Opis { get; set; }


    }
}
