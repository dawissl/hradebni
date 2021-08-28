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
            Kosik novyNakupniKosik = new Kosik(5);
            Zbozi polozka1 = new Zbozi(50, "koberec");
            Zbozi polozka2 = new Zbozi(100, "lampa");
            Zbozi polozka3 = new Zbozi(30, "hrneček");

            novyNakupniKosik.VlozitDoKosiku(2, polozka1);
            novyNakupniKosik.VlozitDoKosiku(3, polozka2);
            novyNakupniKosik.VlozitDoKosiku(0, polozka3);

            novyNakupniKosik.VypisObsahKosiku();
            Console.WriteLine("Zbývá {0}/5 položek",novyNakupniKosik.PocetVolnychPolozekVKosiku());
        }
    }

    class Kosik
    {
        private int kapacita;
        Zbozi[] nakup;

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
            for (int i = 0; i < kapacita; i++)
            {
                if (nakup[i] != null)
                {
                    obsahKosiku += nakup[i].ToString() + "\n";
                }
            }

            Console.WriteLine(obsahKosiku);
        }

        public int PocetVolnychPolozekVKosiku()
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
            return nazev + " stojí " + cena + " Kč";
        }
    }
}
