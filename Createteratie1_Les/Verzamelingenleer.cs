using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Createteratie1_Les
{
    public class Verzameling
    {
        public List<int> Verzameling { get; set; }

        //Constructor
        public Verzameling(List<int> verzameling)
        {
            Verzameling = verzameling;
        }

        public bool isDeelverzamelingVan(Verzameling V2)
        {
            return this.isDeelverzamelingVan(V2.Verzameling);
        }

        /// <summary>
        /// V1 is een deelverzameling van V2,
        /// Als ALLE elementen van V1 ook in V2 voorkomen
        /// Bijvoorbeeld: 
        /// V1 = {4, 6, 8}; V2 = {4, 36, 8, 6} -> Uitkomst = True
        /// </summary>
        /// <param name="V2"></param>
        /// <returns></returns>
        public bool isDeelverzamelingVan(List<int> V2)
        {
            //In het begin ervan uit gaan dat V1 een deelverzameling is van V2,
            //totdat het tegendeel bewezen is
            bool isDeelverzameling = true;

            

            //Globaal idee:
            //Voor ieder element in V1 gaan kijken of deze ook in V2 is.
            foreach (int v1 in V1)
            {
                bool zitElementInV2 = false;
                for (int i = 0; i < B.Count; i++)
                {
                    if (a == B[i])
                    {
                        zitElementInV2 = true;
                    }
                }
                //Als het element NIET in V2 zit:
                if (!zitElementInV2) 
                {
                    isDeelverzameling = false;
                }
            }
            


            //Is B c= C?
            isDeelverzameling = true;
            foreach (int b in B)
            {
                bool zitBinC = false;
                for (int i = 0; i < C.Count; i++)
                {
                    if (b == C[i])
                    {
                        zitBinC = true;
                    }
                }
                if (!zitBinC)
                {
                    isDeelverzameling = false;
                }
            }
            Console.WriteLine("B is deelverzameling van C: " + isDeelverzameling);
        }
    }
}
*/
