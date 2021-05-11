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
            Zbozi polozka1 = new Zbozi(50, "hrnec");
            Zbozi polozka2 = new Zbozi(150, "židle");
            Zbozi polozka3 = new Zbozi(80, "stůl");

            Console.WriteLine("#" + novyKosik.Nakup[3]);
            Console.WriteLine("Kapacita {0}/5", novyKosik.PocetVolnychMistVKosiku());
            novyKosik.VlozitDoKosiku(3, polozka3);
            novyKosik.VlozitDoKosiku(4, polozka1);
            novyKosik.VlozitDoKosiku(1, polozka2);

            novyKosik.ObsahKosiku();

            Console.WriteLine("Kapacita {0}/5", novyKosik.PocetVolnychMistVKosiku());
        }


    }

    class Kosik
    {
        private Zbozi[] nakup;
        private int kapacita;

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

        public void ObsahKosiku()
        {
            string obsah = "";
            for (int i = 0; i < kapacita; i++)
            {
                if (nakup[i] != null)
                {
                    obsah = obsah + nakup[i].ToString() + "\n";
                }
            }
            Console.WriteLine(obsah);
        }

        public int PocetVolnychMistVKosiku()
        {
            int tmp = kapacita;

            for (int i = 0; i < kapacita; i++)
            {
                if (nakup[i] != null)
                {
                    tmp--;
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
