using Microsoft.Extensions.FileProviders;
using System.ComponentModel.DataAnnotations;

namespace GMS.Entities.Models
{
    public class Nutricionist
    {
        [Key]
        public int NutricionistID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public byte[]? Slika { get; set; }
 
    }
}
