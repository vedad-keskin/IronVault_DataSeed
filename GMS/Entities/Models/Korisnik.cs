using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Entities.Models
{
    [Table("Korisnik")]
    public class Korisnik 
    {
        [Key]
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; } 

        public string? Slika { get; set; }

        public string BrojTelefona { get; set; }
        public float Visina { get; set; }
        public float Tezina { get; set; }

        public int? Razina { get; set; }

        public string? VrijemeUTeretani { get; set; }


        [ForeignKey(nameof(Grad))]
        public int GradID { get; set; }
        public Grad Grad { get; set; }

        [ForeignKey(nameof(Spol))]
        public int SpolID { get; set; }
        public Spol Spol { get; set; }




    }
}
