using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Entities.Models
{
    public class Narudzba_Stavka
    {
        [Key]
        public int Narudzba_StavkaID { get; set; }

        [ForeignKey(nameof(Narudzba))]
        public int NarudzbaID { get; set; }
        public Narudzba Narudzba { get; set; }

        [ForeignKey(nameof(Suplement))]
        public int SuplementID { get; set; }
        public Suplement Suplement { get; set; }
        public int Kolicina { get; set; }
    }
}
