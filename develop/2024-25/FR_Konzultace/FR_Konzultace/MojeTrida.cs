using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_Konzultace
{
    internal class MojeTrida
    {
        private Color barva;
        private int pocet;
        private string nazev;

        public Color Barva { set {  barva = value; } }
        public MojeTrida(Color clr)
        {
            this.barva = clr;
        }
        public MojeTrida()
        {
            barva = Color.Blue;
        }
        public override string ToString()
        {
            return "asfasf";
        }

        public int Funkce()
        {
            return 5 + 10;
        }
    }
}
