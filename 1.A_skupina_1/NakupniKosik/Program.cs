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
            NakupniKosik mujNakupniKosik = new NakupniKosik(5);

            Zbozi polozka1 = new Zbozi("stul", 100);
            Zbozi polozka2 = new Zbozi("židle", 50);
            Zbozi polozka3 = new Zbozi("lampa", 35);

            mujNakupniKosik.VlozitDoKosiku(3, polozka1);
            mujNakupniKosik.VlozitDoKosiku(0, polozka2);

            mujNakupniKosik.VypisPolozky();
            Console.WriteLine("Počet volných míst v košíku je {0}/5",mujNakupniKosik.PocetVolnychPolozekVKosiku());

            mujNakupniKosik.VlozitDoKosiku(4, polozka3);
            mujNakupniKosik.VypisPolozky();
            Console.WriteLine("Počet volných míst v košíku je {0}/5", mujNakupniKosik.PocetVolnychPolozekVKosiku());



        }
    }

    class Zbozi
    {
        private string name;
        private double price;

        public string Name { get { return name; } }
        public double Price { get { return price; } }

        public Zbozi(string n, double p)
        {
            name = n;
            price = p;
        }

        public override string ToString()
        {
            return name + " stojí " + price + " Kč";
        }
    }

    class NakupniKosik
    {
        private int kapacita;
        private Zbozi[] kosik;

        public Zbozi[] Kosik { get { return kosik; } }

        public NakupniKosik(int k)
        {
            kapacita = k;
            kosik = new Zbozi[kapacita];
        }

        public void VlozitDoKosiku(int pozice, Zbozi z)
        {
            if (pozice >= kapacita || pozice < 0)
            {
                Console.WriteLine("Vkládání položky mimo pole");
                return;
            }

            kosik[pozice] = z;
        }

        public void VypisPolozky()
        {
            string vystup = "";

            for(int i = 0; i < kapacita; i++)
            {
                if(kosik[i] != null)
                {
                    vystup += kosik[i].ToString() + ",\n";
                }
            }

            Console.WriteLine(vystup);
        }

        public int PocetVolnychPolozekVKosiku()
        {
            int tmp = 0;
            for (int i = 0; i < kapacita; i++)
            {
                if(kosik[i] == null)
                {
                    tmp++;
                }
            }

            return tmp;
        }
    }
}
