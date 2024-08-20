using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Entities.Models
{
    public class Nutricionist_Seminar
    {
        [Key]
        public int Nutricionist_SeminarID { get; set; }

        [ForeignKey(nameof(Nutricionist))]
        public int NutricionistID { get; set; }
        public Nutricionist Nutricionist { get; set; }

        [ForeignKey(nameof(Seminar))]
        public int SeminarID { get; set; }
        public Seminar Seminar { get; set; }
    }
}
