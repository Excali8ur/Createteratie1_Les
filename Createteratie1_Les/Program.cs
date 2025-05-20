namespace Createteratie1_Les
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            if (x > 5)
            {
                Console.WriteLine("x groter dan 5");
                Console.WriteLine("PAS DEZE REGEL AAN OF VOEG IETS TOE");
                Console.WriteLine("bryan was here");
            }
            int y = 10;
            int s = 0;
            while (y > 0)
            {
                Console.WriteLine($"hallo + {s}");
                    s += 1;
            }
        }
    }
}
