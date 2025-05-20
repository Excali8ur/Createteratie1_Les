using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Createteratie1_Les
{
    public class Dobbelsteen
    {
        public string Kleur { get; set; }
        public string KleurOgen { get; set; }
        public string Vorm { get; set; }
        public string Materiaal { get; set; }
        public int AantalZijden { get; set; }
        public List<int> WaardePerZijde { get; set; }
        public int MaxWaarde {  get; set; }
        public int MinWaarde { get; set; }
        public string Grote {  get; set; }
    }
}

