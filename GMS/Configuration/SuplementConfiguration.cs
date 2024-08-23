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
                    Slika = ConvertImageToByteArray("wwwroot", "1sup.webp")


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
                    Slika = ConvertImageToByteArray("wwwroot", "2sup.webp")


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
                    Slika = ConvertImageToByteArray("wwwroot", "3sup.webp")



                }
                ,

                new Suplement
                {

                    SuplementID = 4,
                    Naziv = "Nitro-Tech Whey Protein",
                    Gramaza = 1800,
                    Cijena = 139,
                    Opis = "NITRO-TECH® je naučno istražena, pojačana proteinska formula kreirana za sve sportiste koji žele veću mišićnu masu, više snage i bolje performanse. NITRO-TECH® sadrži protein čiji primarni izvor su peptidi i izolat sirutke – dva najčistija i najkvalitetnija dostupna izvora proteina, za razliku od ostalih proteinskih suplemenata koji možda sadrže tek par gama ovih lako probavljivih i visoke biološke vrijednosti proteina. NITRO-TECH® je takođe poboljšan i sa 3g kreatin monohidrata, najistraženijim oblikom kreatina, namjenjenim za još veću mišićnu masu i snagu.",
                    KategorijaID = 1,
                    DobavljacID = 2,
                    StateMachine = "active",
                    ProsjecnaOcjena = 4,
                    Slika = ConvertImageToByteArray("wwwroot", "4sup.webp")

                }
                 ,

                new Suplement
                {

                    SuplementID = 5,
                    Naziv = "Nitro-Tech 100% Whey",
                    Gramaza = 908,
                    Cijena = 89,
                    Opis = "Preko 20 godina NITRO-TECH® je vodeći proteinski brend, izgrađen na temelju naučnih istraživanja i korištenja najmodernije tehnologija. Sada je isti istraživački i razvojni tim stvorio novu formulu whey proteina baziranu na superiornim izvorima proteina, kvaliteti i tehnici proizvodnje. Predstavljamo vam NITRO-TECH® 100% WHEY GOLD – čistu proteinsku formulu koja sadrži peptide i izolat sirutke.",
                    KategorijaID = 1,
                    DobavljacID = 2,
                    StateMachine = "active",
                    ProsjecnaOcjena = 5,
                    Slika = ConvertImageToByteArray("wwwroot", "5sup.webp")

                }
                 ,

                new Suplement
                {
                    SuplementID = 6,
                    Naziv = "Platinum 8",
                    Gramaza = 2000,
                    Cijena = 119,
                    Opis = "Vrhunska proteinska mješavina za sve namjene u bilo koje vrijeme posebno formulirana za sportiste koji žele biti na vrhuncu svoje igre. Dizajniran s visokokvalitetnom, višefaznom mješavinom proteina, može se uzimati kad god je potrebno - nakon treninga, između obroka ili prije spavanja.",
                    KategorijaID = 1,
                    DobavljacID = 2,
                    StateMachine = "active",
                    ProsjecnaOcjena = 4,
                    Slika = ConvertImageToByteArray("wwwroot", "6sup.webp")

                }
                 ,

                new Suplement
                {
                    SuplementID = 7,
                    Naziv = "BCAA 2:1:1",
                    Gramaza = 250,
                    Cijena = 35,
                    Opis = "Vrhunski ukusan spoj esencijalnih aminokiselina. Ovaj proizvod ne samo da pruža izvanredan ukus, već je i obogaćen esencijalnim hranjivim sastojcima poput vitamina C i vitamina B6. BCAA je kritičan faktor koji vam može pomoći da postignete najbolje iz svojih treninga.",
                    KategorijaID = 2,
                    DobavljacID = 4,
                    StateMachine = "active",
                    ProsjecnaOcjena = 4.5,
                    Slika = ConvertImageToByteArray("wwwroot", "7sup.webp")

                }
                 ,

                new Suplement
                {
                    SuplementID = 8,
                    Naziv = "HMB",
                    Gramaza = 900,
                    Cijena = 45,
                    Opis = "Self Omninutrition HMB (beta-hidroksi-beta-metilbutirat) je metabolit leucina koji sprečava razgradnju proteina i promoviše hipertrofiju mišića (povećanje ćelija koje grade tkivo); također smanjuje moguće povrede mišića nakon treninga visokog intenziteta, čime se smanjuje postotak masnoće u tijelu. Nedavna istraživanja su također pokazala da uzimanje HMB povećava mišićnu snagu, smanjuje simptome prekomjernog treninga te pozitivno utiče na VO2max (maksimalna potrošnja kiseonika). Neki stručnjaci smatraju da je VO2max ključni faktor u sportskim takmičenjima sportista. HMB je vrijedan dodatak ishrani za snagu, performanse i izdržljivost.",
                    KategorijaID = 2,
                    DobavljacID = 4,
                    StateMachine = "active",
                    ProsjecnaOcjena = 3.5,
                    Slika = ConvertImageToByteArray("wwwroot", "8sup.webp")

                }
                 ,

                new Suplement
                {
                    SuplementID = 9,
                    Naziv = "Amino Build",
                    Gramaza = 400,
                    Cijena = 75,
                    Opis = "Napunjene sa gradivnim elementima kako bi podržale brz oporavak. Imajući u vidu da su BCAA kao osnova u sastavu, ubrzat će period oporavka poslije treninga.",
                    KategorijaID = 2,
                    DobavljacID = 2,
                    StateMachine = "active",
                    ProsjecnaOcjena = 5,
                    Slika = ConvertImageToByteArray("wwwroot", "9sup.webp")
                }
                 ,

                new Suplement
                {
                    SuplementID = 10,
                    Naziv = "Cell Tech Elite",
                    Gramaza = 594,
                    Cijena = 85,
                    Opis = "Cell Tech Elite je visoko potentna formula koja pruža vrhunsku dozu od 5 g kreatinske matrice, koja uključuje kreatin monohidrat i kreatin hidroklorid. Osim toga, ova formula sadrži klinički dokazanu dozu od 400 mg Peak ATP-a, koji omogućava povećanje snage i veći broj ponavljanja u treningu. U kliničkoj studiji je dokazano da su ispitanici koji su koristili Peak ATP izgradili 90% više mišića u poređenju sa placebom, postižući impresivne rezultate u roku od 12 sedmica intenzivnog treninga.",
                    KategorijaID = 2,
                    DobavljacID = 2,
                    StateMachine = "active",
                    ProsjecnaOcjena = 5,
                    Slika = ConvertImageToByteArray("wwwroot", "10sup.webp")

                }
                 ,

                new Suplement
                {
                    SuplementID = 11,
                    Naziv = "CW Intra Surgence",
                    Gramaza = 480,
                    Cijena = 85,
                    Opis = "CW Intra Surgence je naučno formuliran Intra-Workout dodatak koji pruža visoko doziranu mješavinu punog spektra esencijalnih aminokiselina (EAA) i razgranatih lanaca aminokiselina (BCAA), zajedno s najnovijim hidratacijskim sastojcima i patentiranim dodacima za povećanje energije.",
                    KategorijaID = 2,
                    DobavljacID = 5,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "11sup.webp")
                }
                 ,

                new Suplement
                {
                    SuplementID = 12,
                    Naziv = "Amino X",
                    Gramaza = 433,
                    Cijena = 65,
                    Opis = "Amino X je specijalna aminokiselinska formula dizajnirana da pomogne tijelu u povećanju izdržljivosti tokom treninga i mišićnom oporavku nakon treninga. Sadrži kvalitetnu anaboličku mješavinu, koja spriječava katabolizam (propadanje mišićnih vlakna) te se brine za obnovu i rast mišića.",
                    KategorijaID = 2,
                    DobavljacID = 6,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "12sup.webp")

                }
                 ,

                new Suplement
                {
                    SuplementID = 13,
                    Naziv = "Power Reactor",
                    Gramaza = 300,
                    Cijena = 65,
                    Opis = "Muscle Freak Power Reactor je visokokvalitetni pre-workout, koji smo kreirali kako bi zadovoljili potrebe i najzahtjevnijih vježbača. Nakon godina uspješnog rada i distribucije najvećih brendova na tržištu, mi u Muscle Freaku smo odlučili da je vrijeme da i naša linija proizvoda ugleda svjetlo dana i da vam u skladu s našom tradicijom ponudimo najbolje i najkvalitetnije proizvode s predznakom bosanski brend.",
                    KategorijaID = 3,
                    DobavljacID = 1,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "13sup.webp")

                }
                 ,

                new Suplement
                {
                    SuplementID = 14,
                    Naziv = "N.O.-Xplode Vaso",
                    Gramaza = 420,
                    Cijena = 85,
                    Opis = "Izgradnja mišića zahtijeva pravilnu ishranu i treninge. Mnogi suplementi prije treninga mogu pružiti energiju i fokus, ali rijetko isporučuju onu pravu \"pumpu\" koju tražite. Ali sada je vaša potraga gotova zahvaljujući N.O.-XPLODE VASO!",
                    KategorijaID = 3,
                    DobavljacID = 2,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "14sup.webp")

                }
                 ,

                new Suplement
                {
                    SuplementID = 15,
                    Naziv = "C4 Ultimate",
                    Gramaza = 410,
                    Cijena = 85,
                    Opis = "Cellucor C4 Ultimate je dugi niz godina usavršavao pre-workoute, mnogo prije nego neki drugi brendovi u industriji sportskih suplemenata. Gotovo desetljeće brend C4® bio je prvi u kategoriji pre-workouta sa učinkom i eksplozivnom energijom, najboljim okusima, klinički proučenim sastojcima i vrhunskim formulama.",
                    KategorijaID = 3,
                    DobavljacID = 7,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "15sup.webp")

                }
                
                 ,

                new Suplement
                {
                    SuplementID = 16,
                    Naziv = "C4 Ripped",
                    Gramaza = 180,
                    Cijena = 65,
                    Opis = "C4 Ripped sadrži sličnu energetsku mješavinu kao i klasični C4, s ključnim sastojcima za energiju koji će vam pomoći da prođete kroz najteže vježbe.",
                    KategorijaID = 3,
                    DobavljacID = 7,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "16sup.webp")

                }
                
                 ,

                new Suplement
                {
                    SuplementID = 17,
                    Naziv = "N.O.-Xplode",
                    Gramaza = 390,
                    Cijena = 69,
                    Opis = "N.O.-XPLODE pomaže u održavanju mentalne budnosti i mišićne snage, donosi energiju i izdržljivost te pomaže sportistima poboljšati kapacitet na svim razinama.",
                    KategorijaID = 3,
                    DobavljacID = 6,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "17sup.webp")

                }
                
                 ,

                new Suplement
                {
                    SuplementID = 18,
                    Naziv = "Shatter",
                    Gramaza = 363,
                    Cijena = 69,
                    Opis = "MuscleTech Shatter™ je iznimno snažan i naučno osmišljen pre-workout suplement koji će Vam doslovno razderati majicu i poboljšati vaše performanse snage i izdržljivosti. Ova vrhunska formula pruža i snažnu energiju i kompleks koji će Vas potaknuti kroz svaki trening.",
                    KategorijaID = 3,
                    DobavljacID = 2,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "18sup.webp")

                }
                ,

                new Suplement
                {
                    SuplementID = 19,
                    Naziv = "Mega Mass",
                    Gramaza = 1200,
                    Cijena = 79,
                    Opis = "Muscle Freak Mega Mass je visokokvalitetni gainer, koji smo kreirali kako bi zadovoljili potrebe i najzahtjevnijih vježbača. Nakon godina uspješnog rada i distribucije najvećih brendova na tržištu, mi u Muscle Freaku smo odlučili da je vrijeme da i naša linija proizvoda ugleda svjetlo dana i da vam u skladu s našom tradicijom ponudimo najbolje i najkvalitetnije proizvode s predznakom bosanski brend.",
                    KategorijaID = 4,
                    DobavljacID = 1,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "19sup.webp")

                }
                ,

                new Suplement
                {
                    SuplementID = 20,
                    Naziv = "Mass Tech ELITE",
                    Gramaza = 3200,
                    Cijena = 119,
                    Opis = "Mass-Tech Elite je napredni mass gainer za one koji imaju problemasa povećanjem veličine ili žele da probiju svoje platoe snage...",
                    KategorijaID = 4,
                    DobavljacID = 2,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "20sup.webp")

                }
                ,

                new Suplement
                {
                    SuplementID = 21,
                    Naziv = "100% Mass Gainer",
                    Gramaza = 2300,
                    Cijena = 89,
                    Opis = "Iz najbolje američke kompanije za prodaju suplemenata, MuscleTech predstavlja Vam 100% Mass Gainer - visokoproteinski suplement za povećanje mišične mase. Ovaj dodatak, obogaćen prirodnim i umjetnim aromama, pruža Vam sve što je potrebno da unaprijedite mišiće, snagu i performanse, uz brži oporavak mišića.",
                    KategorijaID = 4,
                    DobavljacID = 2,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "21sup.webp")

                }
                ,

                new Suplement
                {
                    SuplementID = 22,
                    Naziv = "Mass Super Charger",
                    Gramaza = 2270,
                    Cijena = 75,
                    Opis = "Tesla Mass Super Charger može pomoći vašim mišićima da rastu, zahvaljujući  ugljikohidratima iz više izvora, visokom sadržaju proteina i dodatku aminokiselina u optimalnom omjeru 2:1:1 za pomoć u iskorištavanju proteina. Kreatin je također dodat kako bi pomogao da se mišići napune vodom i potakne daljnji rast, zajedno s pažljivo odabranim vitaminskim kompleksom koji podržava sposobnost vašeg tijela da koristi proteine ​​i ugljikohidrate za energiju i čistu mišićnu masu.",
                    KategorijaID = 4,
                    DobavljacID = 10,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "22sup.webp")

                }
                ,

                new Suplement
                {
                    SuplementID = 23,
                    Naziv = "IsoGainz",
                    Gramaza = 1000,
                    Cijena = 119,
                    Opis = "Evolite IsoGainz je ugljikohidratno-proteinski suplement visoke kvalitete namijenjen prvenstveno aktivnim osobama koji se sastoji od: odabrani ugljikohidrati (maltodextrin sa jako malim sadržajem šećera) proteina (izolat I koncentrat koji ne sadrže laktozu) .Proizvod se može koristiti kao dodatak svakodnevnoj prehrani. Idealno prikladan za korištenje nakon treninga kako bi se nadoknadile zalihe energije u mišićima. Protein doprinosi rastu mišične mase I pomaže u njenom održavanju.",
                    KategorijaID = 4,
                    DobavljacID = 8,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "23sup.png")

                }
                ,

                new Suplement
                {
                    SuplementID = 24,
                    Naziv = "Hyper Mass",
                    Gramaza = 8000,
                    Cijena = 159,
                    Opis = "Hyper Mass Professional je izuzetno moćan suplement s bogatim vitaminskim kompleksom, namijenjen da vam pomogne postići vaše ciljeve u izgradnji mišića! Ovaj preparat Hyper Mass, sa svojom vrhunskom kombinacijom sastojaka, idealan je izbor za sve koji žele dodati mišićnu masu, povećati snagu i izdržljivost tokom treninga.",
                    KategorijaID = 4,
                    DobavljacID = 9,
                    StateMachine = "active",
                    Slika = ConvertImageToByteArray("wwwroot", "24sup.webp")

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
