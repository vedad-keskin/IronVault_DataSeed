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
                    KorisnickoIme = "vedadke",
                    Email = "vedad.keskin98@gmail.com",
                    LozinkaHash = "g7FHgT4d85m0BouhHe1t0KYM2wA=",
                    LozinkaSalt = "QZ4IoSnKb7hg8L7nDFizTg==",
                    BrojTelefona = "0644076290",
                    Visina = 170,
                    Tezina = 80,
                    Razina = 3,
                    VrijemeUTeretani = "0 dana, 21 sati i 0 minuta",
                    SpolID = 1,
                    GradID = 18,
                    Slika = ConvertImageToByteArray("wwwroot", "1kor.jpg")


                },

                new Korisnik
                {

                    KorisnikID = 2,
                    Ime = "Amel",
                    Prezime = "Musić",
                    KorisnickoIme = "test",
                    Email = "vedad.keskin98@gmail.com",
                    LozinkaHash = "Yya6va1Yoa/gtyLz5Z4IXYfFt5Q=",
                    LozinkaSalt = "tXOzvBnYM/kaUy/CDd7V/g==",
                    BrojTelefona = "062709689",
                    Visina = 185,
                    Tezina = 82,
                    Razina = 2,
                    VrijemeUTeretani = "0 dana, 12 sati i 0 minuta",
                    SpolID = 1,
                    GradID = 33,
                    Slika = ConvertImageToByteArray("wwwroot", "2kor.jpg")


                }
                ,

                new Korisnik
                {

                    KorisnikID = 3,
                    Ime = "Denis",
                    Prezime = "Mušić",
                    KorisnickoIme = "denism",
                    Email = "vedad.keskin98@gmail.com",
                    LozinkaHash = "2Kfy1C0XBFtOApv4hlUaEQH4aqs=",
                    LozinkaSalt = "QLSAf12F9XkD+4ZLEFZz+w==",
                    BrojTelefona = "061000000",
                    Visina = 186,
                    Tezina = 83,
                    Razina = 1,
                    SpolID = 1,
                    GradID = 18,
                    Slika = ConvertImageToByteArray("wwwroot", "3kor.jpg")



                }
                ,

                new Korisnik
                {

                    KorisnikID = 4,
                    Ime = "Elmir",
                    Prezime = "Babović",
                    KorisnickoIme = "elmirb",
                    Email = "vedad.keskin98@gmail.com",
                    LozinkaHash = "1wrfyYURG83rXcpYOK7LxbASzxY=",
                    LozinkaSalt = "gu5g9kJouJlB19/DNtCtaw==",
                    BrojTelefona = "062000000",
                    Visina = 189,
                    Tezina = 86,
                    Razina = 1,
                    SpolID = 1,
                    GradID = 34,
                    Slika = ConvertImageToByteArray("wwwroot", "4kor.jpg")



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
