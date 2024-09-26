using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class SuplementConfiguration : IEntityTypeConfiguration<Suplement>
    {
        public void Configure(EntityTypeBuilder<Suplement> builder)
        {
            builder.HasData(
                new Suplement
                {
                    SuplementID = 1,
                    Naziv = "100% Whey Protein",
                    Gramaza = 2500,
                    Cijena = 139,
                    Opis = "Muscle Freak 100% Isolate Whey Protein je visokokvalitetni izolat proteina sirutke, koji smo kreirali kako bi zadovoljili potrebe i najzahtjevnijih vježbača. Nakon godina uspješnog rada i distribucije najvećih brendova na tržištu, mi u Muscle Freaku smo odlučili da je vrijeme da i naša linija proizvoda ugleda svjetlo dana i da vam u skladu s našom tradicijom ponudimo najbolje i najkvalitetnije proizvode s predznakom bosanski brend.",
                    KategorijaID = 1,
                    DobavljacID = 1,
                    StateMachine = "active",
                    ProsjecnaOcjena = 4.5,
                    Slika = ConvertImageToByteArray("wwwroot", "1sup.jpg")


                },

                new Suplement
                {

                    SuplementID = 2,
                    Naziv = "Gold 100% Casein",
                    Gramaza = 809,
                    Cijena = 99,
                    Opis = "Korištenjem samo vrhunskog kazeina kao izvora proteina u svom 100% Gold Standard Casein-u, Optimum Nutrition je stvorio formulu koja postavlja standard za sve sporootpuštajuće proteine.",
                    KategorijaID = 1,
                    DobavljacID = 3,
                    StateMachine = "active",
                    ProsjecnaOcjena = 3.5,
                    Slika = ConvertImageToByteArray("wwwroot", "2sup.jpg")


                }
                ,

                new Suplement
                {

                    SuplementID = 3,
                    Naziv = "Nitro-Tech Ripped",
                    Gramaza = 900,
                    Cijena = 89,
                    Opis = "NITRO-TECH RIPPED™ je najnovija inovacija iz MuscleTech-a, branda koji oduševljava svojim proizvodima više od 20 godina. Ova napredna formula kombinuje proteinske peptide najviše kvalitete i izolat sa naučno testiranim sastojcima za gubitak težine. Ova 7 u 1 formula također sadrži CLA, trigliceride srednjeg lanca (MCT), L-carnitine L-tartrate, ekstrakt zelenog čaja, ekstrakt šipka i prah algi. MuscleTech® je napravio ovu jedinstvenu formula s ciljem objedinjavanja ultra-čistog proteina i gubitka težine - ovakvo nešto niste nikad prije vidjeli. Za razliku od konkurencije, svaka mjerica NITRO-TECH RIPPED™ sadrži naučno proučavanu dozu ključnih sastojaka za gubitak težine, C. canephora robusta, koja je potvrđena od strane dvije naučne studije i u čije rezultate ne morate sumnjati! Također, nevjerovatnog je okusa koji će Vas oduševiti!",
                    KategorijaID = 1,
                    DobavljacID = 2,
                    StateMachine = "active",
                    ProsjecnaOcjena = 1,
                    Slika = ConvertImageToByteArray("wwwroot", "3sup.jpg")



                }
            ,

                new Suplement
                {
                    SuplementID = 4,
                    Naziv = "Amino Build",
                    Gramaza = 400,
                    Cijena = 75,
                    Opis = "Napunjene sa gradivnim elementima kako bi podržale brz oporavak. Imajući u vidu da su BCAA kao osnova u sastavu, ubrzat će period oporavka poslije treninga.",
                    KategorijaID = 2,
                    DobavljacID = 2,
                    StateMachine = "active",
                    ProsjecnaOcjena = 4,
                    Slika = ConvertImageToByteArray("wwwroot", "4sup.jpg")
                }
                 ,

                new Suplement
                {
                    SuplementID = 5,
                    Naziv = "Cell Tech Elite",
                    Gramaza = 594,
                    Cijena = 85,
                    Opis = "Cell Tech Elite je visoko potentna formula koja pruža vrhunsku dozu od 5 g kreatinske matrice, koja uključuje kreatin monohidrat i kreatin hidroklorid. Osim toga, ova formula sadrži klinički dokazanu dozu od 400 mg Peak ATP-a, koji omogućava povećanje snage i veći broj ponavljanja u treningu. U kliničkoj studiji je dokazano da su ispitanici koji su koristili Peak ATP izgradili 90% više mišića u poređenju sa placebom, postižući impresivne rezultate u roku od 12 sedmica intenzivnog treninga.",
                    KategorijaID = 2,
                    DobavljacID = 2,
                    StateMachine = "active",
                    ProsjecnaOcjena = 5,
                    Slika = ConvertImageToByteArray("wwwroot", "5sup.jpg")

                }
                 ,


                new Suplement
                {
                    SuplementID = 6,
                    Naziv = "N.O.-Xplode Vaso",
                    Gramaza = 420,
                    Cijena = 85,
                    Opis = "Izgradnja mišića zahtijeva pravilnu ishranu i treninge. Mnogi suplementi prije treninga mogu pružiti energiju i fokus, ali rijetko isporučuju onu pravu \"pumpu\" koju tražite. Ali sada je vaša potraga gotova zahvaljujući N.O.-XPLODE VASO!",
                    KategorijaID = 3,
                    DobavljacID = 2,
                    ProsjecnaOcjena = 4,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "6sup.jpg")

                }
                 ,

                new Suplement
                {
                    SuplementID = 7,
                    Naziv = "C4 Ultimate",
                    Gramaza = 410,
                    Cijena = 85,
                    Opis = "Cellucor C4 Ultimate je dugi niz godina usavršavao pre-workoute, mnogo prije nego neki drugi brendovi u industriji sportskih suplemenata. Gotovo desetljeće brend C4® bio je prvi u kategoriji pre-workouta sa učinkom i eksplozivnom energijom, najboljim okusima, klinički proučenim sastojcima i vrhunskim formulama.",
                    KategorijaID = 3,
                    DobavljacID = 7,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "7sup.jpg")

                }
                
                 ,

                new Suplement
                {
                    SuplementID = 8,
                    Naziv = "C4 Ripped",
                    Gramaza = 180,
                    Cijena = 65,
                    Opis = "C4 Ripped sadrži sličnu energetsku mješavinu kao i klasični C4, s ključnim sastojcima za energiju koji će vam pomoći da prođete kroz najteže vježbe.",
                    KategorijaID = 3,
                    DobavljacID = 7,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "8sup.jpg")

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
