using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakupniKosik
{
    class Program
    {
        static void Main(string[] args)
        {
            Kosik novyKosik = new Kosik(5);

            Zbozi polozka1 = new Zbozi(50, "stul");
            Zbozi polozka2 = new Zbozi(500, "pohovka");
            Zbozi polozka3 = new Zbozi(70, "lampa");

            novyKosik.VlozitDoKosiku(2, polozka1);
            novyKosik.VlozitDoKosiku(0, polozka2);
          

            novyKosik.VypisObsahKosiku();
            Console.WriteLine("V kosiku je ještě {0}/5 volných míst",novyKosik.PocetZbyvajicichMistVKosiku());

            novyKosik.VlozitDoKosiku(4, polozka3);

            novyKosik.VypisObsahKosiku();
            Console.WriteLine("V kosiku je ještě {0}/5 volných míst", novyKosik.PocetZbyvajicichMistVKosiku());

        }
    }

    class Kosik
    {
        private int kapacita;
        private Zbozi[] nakup;

        public Kosik(int pocetPolozek)
        {
            kapacita = pocetPolozek;
            nakup = new Zbozi[kapacita];
        }

        public Zbozi[] Nakup { get { return nakup; } }

        public void VlozitDoKosiku(int pozice, Zbozi z)
        {
            nakup[pozice] = z;
        }

        public void VypisObsahKosiku()
        {
            string obsahKosiku = "";
            for(int i = 0; i < kapacita; i++)
            {
                if(nakup[i] != null)
                {
                    obsahKosiku += nakup[i].ToString() + "\n";
                }
            }

            Console.WriteLine(obsahKosiku);
        }

        public int PocetZbyvajicichMistVKosiku()
        {
            int tmp = 0;
            for (int i = 0; i < kapacita; i++)
            {
                if (nakup[i] == null)
                {
                    tmp++;
                }
            }

            return tmp;
        }

    }

    class Zbozi
    {
        private int cena;
        private string nazev;

        public Zbozi(int c, string n)
        {
            cena = c;
            nazev = n;
        }

        public override string ToString()
        {
            return nazev + " má cenu " + cena + " Kč";
        }
    }
}
