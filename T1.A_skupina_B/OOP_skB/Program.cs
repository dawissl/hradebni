using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// @author = David Sládeček
/// </summary>
namespace OOP_skB
{
    class Program
    {
        static void Main(string[] args)
        {
            // vytvoření konkrétních instancí jednotlivých tříd
            Potravina syr = new Potravina("syrova");
            Potravina clovek = new Potravina("slaninova");
            // ovoce a zelenina mají konstruktor odlišný od třídy potravina
            Ovoce jablko = new Ovoce("jablkova","jablon");
            Zelenina mrkev = new Zelenina("mrkvova","černozem");

            // demonstrace polymyrofismu
            Potravina hruska = new Ovoce("hruskova","hruska");

            syr.JakChutnas();
            // zmena chuti člověka - volání fieldu Chut
            clovek.Chut = "ne moc dobra";
            clovek.JakChutnas();
            jablko.JakChutnas();
            mrkev.JakChutnas();
            hruska.JakChutnas();

            Console.WriteLine(syr.Chut);
            // přístup na atributy tříd ovoce a zeleniny
            Console.WriteLine("Jablko roste na {0}", jablko.Strom);
            Console.WriteLine("Mrkev roste dobře v {0}", mrkev.TypPudy);
            // nakrajeni vsech potravin a sečtení kousků
            int salat = syr.Krajeni() + jablko.Krajeni() + hruska.Krajeni() + mrkev.Krajeni();

            Console.WriteLine("V míse je {0} dilku potravin",salat);


        }
    }

    /// <summary>
    /// Obecná třída Potravina
    /// </summary>
    class Potravina
    {
        private string chut;

        public Potravina(string ch)
        {
            this.chut = ch;
        }

        public string Chut { get { return chut; } set { chut = value; } }
        // funkce, kterou dědí všechny odovzené třídy
        public void JakChutnas()
        {
            Console.WriteLine("Moje chut je {0}", chut);
        }
        // výchozi funkce Krajeni() pokud neni řečeno jinak získáváme 10 dílků

        public virtual int Krajeni()
        {
            return 10;
        }
    }
    /// <summary>
    /// Třída ovoce odvozená (dědí atributy a funkce) od třídy Potravina
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
        //reimplementace obecne funkce Krajeni() pro konkrétni třídu ovoce
        public override int Krajeni()
        {
            return 6;
        }
    }

    /// <summary>
    /// Třída zelenina odvozená (dědí atributy a funkce) od třídy Potravina
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
