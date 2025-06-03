using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Createteratie1_Les.Klassen
{
    public class Gerecht
    {
        public string Naam {  get; set; }
        public double Prijs { get; private set; }
        //private double Prijs;

        public Gerecht(double prijs) 
        {
            Prijs = prijs;
        }
    }
}
