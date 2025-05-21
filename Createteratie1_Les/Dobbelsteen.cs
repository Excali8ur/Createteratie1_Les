using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Createteratie1_Les
{
    public class Dobbelsteen
    {
        //Attributen / Eigenschappen / Properties
        public string Kleur { get; set; }
        public string KleurOgen { get; set; }
        public string Vorm { get; set; }
        public string Materiaal { get; set; }
        public string Grote { get; set; }
        
        public int AantalZijden { get; set; }
        public int MaxWaarde {  get; set; }
        public int MinWaarde { get; set; }
        //public List<int> WaardePerZijde { get; set; }
        public List<string> WaardePerZijde { get; set; }

        //Deze variabele wordt gebruikt om de dobbelsteen te kunnen Rollen.
        //Private omdat de buitenwereld deze niet hoeft te kennen.
        //(Encapsulation)
        private Random willekeurigeWaarde;

        /// <summary>
        /// Standaard constructor waarmee een normale groene 
        /// dobbelsteen met 6 zijden aangemaakt wordt
        /// </summary>
        public Dobbelsteen()
        {
            Kleur = "Groen";
            KleurOgen = "Zwart";
            Vorm = "Kubus";
            Materiaal = "Plastic";
            Grote = "Normaal";

            AantalZijden = 6;            
            MaxWaarde = 6;
            MinWaarde = 1;
            //WaardePerZijde = new List<int>([1, 2, 3, 4, 5, 6]);
            WaardePerZijde = new List<string>();
            MaakWaardePerZijden();

            willekeurigeWaarde = new Random();
        }

        /// <summary>
        /// Constructor van een Dobbelsteen waarbij alle gegevens meegegeven
        /// worden als parameters.
        /// </summary>
        /// <param name="kleur">Kleur van de dobbelsteen</param>
        /// <param name="kleurOgen">Kleur van de waarden op de dobbelsteen</param>
        /// <param name="vorm">Vorm van de dobbelsteen</param>
        /// <param name="materiaal">Materiaal van de dobbelsteen</param>
        /// <param name="grote">Formaat van de dobbelsteen (Mini, Klein, Normaal, Groot, Extra Groot)</param>
        /// <param name="aantalZijden">Hoeveel vlakken heeft de dobbelsteen</param>
        /// <param name="waardePerZijde">Wat staat er op iedere zijde?</param>
        /// <param name="maxWaarde">Maximale waarde, indien de dobbelsteen cijfers bevat</param>
        /// <param name="minWaarde">Minimale waarde, indien de dobbelsteen cijfers bevat</param>
        public Dobbelsteen(string kleur, string kleurOgen, 
            string vorm, string materiaal, string grote,
            int aantalZijden, int maxWaarde, int minWaarde,
            List<string> waardePerZijde)
        {
            Kleur = kleur;
            KleurOgen = kleurOgen;
            Vorm = vorm;
            Materiaal = materiaal;
            Grote = grote;

            AantalZijden = aantalZijden;
            WaardePerZijde = waardePerZijde;
            MaxWaarde = maxWaarde;
            MinWaarde = minWaarde;

            willekeurigeWaarde = new Random();
        }

        //Hulpfunctie die de lijst "WaardePerZijde" opbouwt
        //op basis van de variabelen MinWaarde en MaxWaarde.
        //Deze is alleen beschikbaar binnen de klasse.
        //Als er geen parameter meegegeven wordt,
        //wordt automatisch stapgrote 1 gebruikt
        private void MaakWaardePerZijden(int stapgrote = 1)
        {
            WaardePerZijde = new List<string>();
            int waarde = MinWaarde;
            while (waarde <= MaxWaarde)
            {
                WaardePerZijde.Add(waarde.ToString());
                waarde+= stapgrote;
            }
        }

        //Methoden / Gedrag van een dobbelsteen

        /// <summary>
        /// 
        /// </summary>
        /// <returns>De gerolde waarde als string</returns>
        public string Rollen()
        {
            //Bepaal een willekeurig getal tussen 0 en de lengte van de lijst (= aantalZijden)
            int geroldeWaarde = willekeurigeWaarde.Next(AantalZijden);
            
            //Geef de waarde terug die op deze index in de lijst staat.
            return WaardePerZijde[geroldeWaarde];
        }

        public string ToonGegevens()
        {
            string tekst = "Dit is een " + Kleur + " dobbelsteen met " + KleurOgen + " waarden en heeft " + AantalZijden;
            tekst += "\nHij is gemaakt van " + Materiaal + " en heeft het formaat " + Grote +".";
            return tekst;
        }

        public string ToonWaarden()
        {
            string tekst = "De volgende waarden kunnen gerold worden:";
            foreach (string waarde in WaardePerZijde)
            {
                tekst += "\n* " + waarde;
            }
            return tekst;
        }
    }
}

