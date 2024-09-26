using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class KorisnikConfiguration : IEntityTypeConfiguration<Korisnik>
    {
        public void Configure(EntityTypeBuilder<Korisnik> builder)
        {
            builder.HasData(
                new Korisnik
                {
                    KorisnikID = 1,
                    Ime = "Vedad",
                    Prezime = "Keskin",
                    KorisnickoIme = "desktop",
                    Email = "ironvault.test@gmail.com",
                    LozinkaHash = "/sQWOxvpzqUJK7grzQGsN5yX0LI=",
                    LozinkaSalt = "BmclnyHeY8muqOn8CgWyCQ==",
                    BrojTelefona = "0644076290",
                    Visina = 170,
                    Tezina = 80,
                    Razina = 3,
                    VrijemeUTeretani = "0 dana, 21 sati i 0 minuta",
                    SpolID = 1,
                    GradID = 18,
                    Slika = ConvertImageToByteArray("wwwroot", "1kor.jpg"),
                    SatiUTeretani = 21
                    

                },

                new Korisnik
                {

                    KorisnikID = 2,
                    Ime = "Amel",
                    Prezime = "Musić",
                    KorisnickoIme = "mobile",
                    Email = "ironvault.test@gmail.com",
                    LozinkaHash = "BsBZhuf6khxcsMiKOfkf8i6YCFY=",
                    LozinkaSalt = "MsAOOfOrEjMn6UE18MK0DQ==",
                    BrojTelefona = "062709689",
                    Visina = 185,
                    Tezina = 82,
                    Razina = 2,
                    VrijemeUTeretani = "0 dana, 12 sati i 0 minuta",
                    SpolID = 1,
                    GradID = 33,
                    Slika = ConvertImageToByteArray("wwwroot", "2kor.jpg"),
                    SatiUTeretani = 12

                }
                ,

                new Korisnik
                {

                    KorisnikID = 3,
                    Ime = "Denis",
                    Prezime = "Mušić",
                    KorisnickoIme = "denism",
                    Email = "ironvault.test@gmail.com",
                    LozinkaHash = "2Kfy1C0XBFtOApv4hlUaEQH4aqs=",
                    LozinkaSalt = "QLSAf12F9XkD+4ZLEFZz+w==",
                    BrojTelefona = "061000000",
                    Visina = 186,
                    Tezina = 83,
                    Razina = 1,
                    SpolID = 1,
                    GradID = 18,
                    Slika = ConvertImageToByteArray("wwwroot", "3kor.jpg"),
                    SatiUTeretani = 0


                }
    
              




                );

        }

        private byte[] ConvertImageToByteArray(string folder, string imageName)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string imagePath = Path.Combine(currentDirectory, folder, imageName);


            try
            {
                if (File.Exists(imagePath))
                {
                    return File.ReadAllBytes(imagePath);
                }
                else
                {
                    Console.WriteLine("Image file not found.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading image file: {ex.Message}");
                return null;
            }
        }
    }
}
