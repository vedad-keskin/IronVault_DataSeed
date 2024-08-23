namespace GMS.Entities.Models
{
    public class Trener
    {
        public int TrenerID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public byte[]? Slika { get; set; }

    }
}
