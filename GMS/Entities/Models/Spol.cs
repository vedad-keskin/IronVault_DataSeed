using System.ComponentModel.DataAnnotations;

namespace GMS.Entities.Models
{
    public class Spol
    {
        [Key]
        public int SpolID { get; set; }
        public string Naziv { get; set; } 
    }
}
