using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// @author = David Sládeček
/// @editor = Nekdo Jiny
/// </summary>
namespace OOP_sk2
{
    class Program
    {
        static void Main(string[] args)
        {
            Potravina syr = new Potravina("syrova");
            Potravina rizek = new Potravina("smetanova");

            Ovoce jablko = new Ovoce("jablkova", "jablon");
            Zelenina mrkev = new Zelenina("mrkvova","černozem");

            // demonstrace polymorfismu
            Potravina hruska = new Ovoce("hruskova", "hruska");
            Potravina[] nakupniSeznam = { syr, rizek, jablko, mrkev, hruska };


            syr.JakChutnas();
            rizek.Chut = "masova";
            rizek.JakChutnas();

            jablko.JakChutnas();
            mrkev.JakChutnas();

            Console.WriteLine(syr.Chut);

            Console.WriteLine("Jablko roste na {0}", jablko.Strom);
            Console.WriteLine("Mrkev roste v {0}", mrkev.TypPudy);

            int salat = syr.Krajeni() + rizek.Krajeni() + jablko.Krajeni() + mrkev.Krajeni();

            Console.WriteLine("V salatu máme {0} dílků potravin ", salat);

            if (syr.JeTohoVic(mrkev))
            {
                Console.WriteLine("Syru je vice");
            }
            else
            {
                Console.WriteLine("Mrkve je vice");
            }


        }
    }
    /// <summary>
    /// Zakladni trida ze ktere odovzujeme dalsi
    /// </summary>
    class Potravina
    {
        // atribut je privatni
        private string chut;

        public Potravina(string ch)
        {
            chut = ch;
        }

        // field skrze ktery můžeme přistupovat na atributy třídy
        public string Chut { get { return chut; } set { chut = value; } }

        public void JakChutnas()
        {
            Console.WriteLine("Moje chuť je {0}", chut);
        }

        // funkce u které očekáváme reimplementaci u odvozených tříd
        public virtual int Krajeni()
        {
            return 10;
        }

        public bool JeTohoVic(Potravina p)
        {
            return Krajeni() > p.Krajeni();
        }
    }

    /// <summary>
    /// třída Ovoce odovzena (zděděné atributy a metody) z tridy Potravina
    /// </summary>
    class Ovoce : Potravina
    {
        private string strom;
        public Ovoce(string ch, string s) : base(ch)
        {
            Chut = "sladka";
            strom = s;
        }

        public string Strom { get { return strom; } }

        // reimplementovana trida z nadrazene tridy - stejny nazev, ale jine chování pro tuto třídu
        public override int Krajeni()
        {
            return 6;
        }
    }

    /// <summary>
    /// třída Zelenina odovzena (zděděné atributy a metody) z tridy Potravina
    /// </summary>
    class Zelenina : Potravina
    {
        private string typPudy;
        public Zelenina(string ch, string t) : base(ch)
        {
            Chut = "slana";
            typPudy = t;
        }

        public string TypPudy { get { return typPudy; } }

        public override int Krajeni()
        {
            return 20;
        }
    }
}
