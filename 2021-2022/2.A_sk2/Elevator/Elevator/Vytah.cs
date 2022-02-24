using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Vytah
    {
        private int maxPocet;
        private int maxVaha;
        private int aktualniPocet=0;
        private int aktualniVaha = 0;

        public int MaxPocet { get { return maxPocet; } }
        public int MaxVaha { get { return maxVaha; } }
        public int AktualniVaha { get { return aktualniVaha; } }
        public int AktualniPocet { get { return aktualniPocet; } }
        public Vytah(int maxV, int maxP)
        {
            maxVaha = maxV;
            maxPocet = maxP;
        }
        public void pridejOsobu(int vahaOsoby)
        {
            aktualniPocet++;
            aktualniVaha += vahaOsoby;
        }

    }
}
