using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class TrenerConfiguration : IEntityTypeConfiguration<Trener>
    {
        public void Configure(EntityTypeBuilder<Trener> builder)
        {
            builder.HasData(
                new Trener
                {
                    TrenerID = 1,
                    Ime = "Kadir",
                    Prezime = "Keskin",
                    Email = "ironvault.test@gmail.com",
                    BrojTelefona = "0644076290",
                    Slika = ConvertImageToByteArray("wwwroot", "1tre.jpg")

                },

                new Trener
                {

                    TrenerID = 2,
                    Ime = "Azur",
                    Prezime = "Kahriman",
                    Email = "ironvault.test@gmail.com",
                    BrojTelefona = "0644076290",
                    Slika = ConvertImageToByteArray("wwwroot", "2tre.jpg")
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
