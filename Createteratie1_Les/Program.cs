namespace Createteratie1_Les
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dobbelsteen = new Dobbelsteen();
            Dobbelsteen.Kleur = "groen";
            Dobbelsteen.KleurOgen = "zwart";
            Dobbelsteen.Vorm = "kubus";
            Dobbelsteen.AantalZijden = 6;
            Dobbelsteen.WaardePerZijden = new List<int>([1, 2, 3, 4, 5, 6]);
            Dobbelsteen.Maxwaarde = 6;
            Dobbelsteen.Minwaarden = 1;
            Dobbelsteen.Grote = "groot";
        }
    }
}
