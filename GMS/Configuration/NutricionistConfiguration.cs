using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class NutricionistConfiguration : IEntityTypeConfiguration<Nutricionist>
    {
        public void Configure(EntityTypeBuilder<Nutricionist> builder)
        {
            builder.HasData(
                new Nutricionist
                {
                  NutricionistID = 1,
                  Ime = "Marijana",
                  Prezime = "Zubac",
                  Email = "vedad.keskin98@gmail.com",
                  BrojTelefona = "062709689",
                  Slika = ConvertImageToByteArray("wwwroot", "1nut.jpg")

                },

                new Nutricionist
                {

                    NutricionistID = 2,
                    Ime = "Amela",
                    Prezime = "Ivković",
                    Email = "vedad.keskin98@gmail.com",
                    BrojTelefona = "062709689",
                    Slika = ConvertImageToByteArray("wwwroot", "2nut.jpg")

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
