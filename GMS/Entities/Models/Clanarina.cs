using System.ComponentModel.DataAnnotations;

namespace GMS.Entities.Models
{
    public class Clanarina
    {
        [Key]
        public int ClanarinaID { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public string Opis { get; set; }

    }
}
