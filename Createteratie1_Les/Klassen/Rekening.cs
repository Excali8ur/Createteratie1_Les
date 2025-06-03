using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Createteratie1_Les.Klassen
{
    public class Rekening
    {
        public int TafelNummer { get; set; }
        public List<Gerecht> Gerechten { get; set; }
        public double TotaalBedrag  { get; private set; }

        public Rekening(int tafelnummer)
        {
            TafelNummer = tafelnummer;
            Gerechten = new List<Gerecht>();
            TotaalBedrag = 0;
        }

        public void BerekenTotaalbedrag()
        {
            foreach (Gerecht g in Gerechten)
            {
                //Console.WriteLine("Gerecht:" + g.Naam + " Prijs: "+ g.Prijs);
                TotaalBedrag += g.Prijs;
            }            
        }
    }
}
