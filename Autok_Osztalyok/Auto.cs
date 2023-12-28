using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autok_Osztalyok
{
    internal class Auto
    {
        string marka;
        string tipus;
        int kivitel;
        int evjarat;

        public Auto(string marka, string tipus, int kivitel, int evjarat)
        {
            this.marka = marka;
            this.tipus = tipus;
            this.kivitel = kivitel;
            this.evjarat = evjarat;
        }

        public string GetMarka()
        {
            return marka;
        }
        public string GetTipus()
        {
            return tipus;
        }
        public string GetKivitel()
        {
            switch (kivitel)
            {
                case 0: return "Nem személygépjármű";
                case 1: return "Sedan";
                case 2: return "SUV";
                case 3: return "Hatchback";
                case 4: return "Kombi";
                case 5: return "Terepjáró";
                case 6: return "Egyterű";
            }
            return "Ismeretlen";
        }
        public int GetEvjarat()
        {
            return evjarat;
        }
        public override string ToString()
        {
            return $"{marka};{tipus};{kivitel};{evjarat}";
        }
    }
}
