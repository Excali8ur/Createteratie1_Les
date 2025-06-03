using Createteratie1_Les;
using Createteratie1_Les.Klassen;

namespace Createteratie1_Les
{
    public class Program
    {
        static List<Dobbelsteen> MaakDobbelstenen()
        {
            List<Dobbelsteen> dobbelstenenLijst = new List<Dobbelsteen>();

            //Verschillende objecten van het type dobbelsteen:

            //Hier wordt de standaard constructor aangeroepen
            //Zonder parameters, dus je krijgt een object met standaardwaarden
            Dobbelsteen groeneD6 = new Dobbelsteen();

            Dobbelsteen rodeD6 = new Dobbelsteen();
            //Aanpassing van de dobbelsteen -> Rood ipv de standaard Groen,
            //Rest is gelijk
            rodeD6.Kleur = "Rood";

            List<string> waardenBlauw = new List<string>();
            int waarde = 1;
            while (waarde <= 6)
            {
                waardenBlauw.Add(waarde.ToString());
                waarde++;
            }

            //Hier wordt de tweede constuctor aangeroepen,
            //waarbij alle gegevens meegegeven worden als parameters
            //Ook al zijn onderdelen hetzelfde als de standaard,
            //moeten deze alsnog meegegeven worden.
            Dobbelsteen groteBlauweD6 = new Dobbelsteen(
                "Blauw", "Zwart", "Kubus", "Foam", "Groot", 
                6, 6, 1, waardenBlauw);

            List<string> klusjes = new List<string>();
            klusjes.Add("Koken");
            klusjes.Add("Afwassen");
            klusjes.Add("Onkruid wieden");
            klusjes.Add("Koffie zetten");
            klusjes.Add("Ramen lappen");
            klusjes.Add("Niks doen :)");

            //Dobbelsteen met tekst ipv getallen
            Dobbelsteen activiteitenDobbelsteen = new Dobbelsteen(
                "Zilver", "Meerkleurig", "Kubus", "Metaal", "Normaal",
                6, 0, 0, klusjes);


            //Paarse dobbelsteen met gele ogen.
            Dobbelsteen paarseD100 = new Dobbelsteen();
            paarseD100.AantalZijden = 10;

            List<string> waardePerZijde = new List<string>();
            waarde = 0;
            while (waarde <= 90)
            {
                waardePerZijde.Add(waarde.ToString());
                waarde += 10;
            }
            //Welke waarden heeft deze dobbelsteen?
            paarseD100.WaardePerZijde = waardePerZijde;

            //Oefening: Hoe ziet deze dobbelsteen uit?
            //Welke waarden moeten nog aangepast worden tov de standaard dobbelsteen?

            dobbelstenenLijst.Add(groeneD6);
            dobbelstenenLijst.Add(rodeD6);
            dobbelstenenLijst.Add(groteBlauweD6);
            dobbelstenenLijst.Add(activiteitenDobbelsteen);
            dobbelstenenLijst.Add(paarseD100);
            return dobbelstenenLijst;
        }

        static void ToonDobbelstenen(List<Dobbelsteen> dobbelstenenLijst)
        {
            foreach (Dobbelsteen d in dobbelstenenLijst)
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine(d.ToonGegevens());
                Console.WriteLine(d.ToonWaarden());
            }
        }

        static void Main(string[] args)
        {
            Rekening rekening = new Rekening(8);

            Gerecht gerecht1 = new Gerecht();
            gerecht1.Naam = "SpaghettiStamppot";
            gerecht1.Prijs = 17.50;

            Gerecht gerecht2 = new Gerecht();
            gerecht2.Naam = "ROde mul met groente";
            gerecht2.Prijs = 28.90;

            rekening.Gerechten.Add(gerecht1);
            rekening.Gerechten.Add(gerecht1);
            rekening.Gerechten.Add(gerecht2);

            rekening.BerekenTotaalbedrag();
            Console.WriteLine("Totaalbedrag: " + rekening.TotaalBedrag);
        }

        /*
        //DOBBELSTEEN
        List<Dobbelsteen> dobbelstenenLijst;

        dobbelstenenLijst = MaakDobbelstenen();
        ToonDobbelstenen(dobbelstenenLijst);

        //Rol alle dobbelstenen een aantal keren achter elkaar:            
        int aantalKeerRollen = 10;
        Console.WriteLine(new string ('-', 50));
            Console.WriteLine("Rol alle dobbelstenen "+aantalKeerRollen+"x:");
            
            for (int i = 1; i <= aantalKeerRollen; i++)
            {
                Console.WriteLine(new string ('~', 25));
                Console.WriteLine("Rol " + i.ToString());
                Console.WriteLine(new string ('~', 25));

                foreach (Dobbelsteen d in dobbelstenenLijst)
                {
                    Console.WriteLine(d.Kleur + ": " + d.Rollen());
                }
            }

            //VERZAMELINGENLEER (DE)
            //Is A c= C?
            Verzameling A = new Verzameling(new List<int>([1, 222, 4, 6]));
            Verzameling B = new Verzameling(new List<int>([4, 6, 8]));
            Verzameling C = new Verzameling(new List<int>([4, 36, 8, 6]));

            //Is A c= B?
            Console.WriteLine("A is deelverzameling van B: " + A.isDeelverzamelingVan(B));
            */
    }
}
