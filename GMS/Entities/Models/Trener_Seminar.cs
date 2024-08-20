using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Entities.Models
{
    public class Trener_Seminar
    {
        [Key]
        public int Trener_SeminarID { get; set; }

        [ForeignKey(nameof(Trener))]
        public int TrenerID { get; set; }
        public Trener Trener { get; set; }

        [ForeignKey(nameof(Seminar))]
        public int SeminarID { get; set; }
        public Seminar Seminar { get; set; }

    }
}
