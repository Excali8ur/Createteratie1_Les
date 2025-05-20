namespace Createteratie1_Les
{
    internal class Program
    {
        static void MaakDobbelstenen()
        {
            Dobbelsteen d1 = new Dobbelsteen();
            d1.Kleur = "Groen";
            d1.KleurOgen = "Zwart";
            d1.Vorm = "Kubus";
            d1.Materiaal = "Foam";
            d1.AantalZijden = 6;
            //d1.WaardePerZijde = "1 t/m 6";
            d1.WaardePerZijde = new List<int>([1, 2, 3, 4, 5, 6]);
            d1.MaxWaarde = 6;
            d1.MinWaarde = 1;
            d1.Grote = "Groot";
        }

        static void Main(string[] args)
        {
            MaakDobbelstenen();
        }
    }
}
