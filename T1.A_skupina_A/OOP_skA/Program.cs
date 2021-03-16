using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// @author = David Sládeček
/// </summary>
namespace OOP_skA
{
    class Program
    {
        static void Main(string[] args)
        {
            // vytvoření konkrétních instancí jednotlivých tříd
            Potravina syr = new Potravina("syrova");
            Potravina slanina = new Potravina("cibule");
            // ovoce a zelenina mají konstruktor odlišný od třídy potravina
            Ovoce jablko = new Ovoce("jablon", "jablkova");
            Zelenina mrkev = new Zelenina("černozem", "mrkvova");

            syr.JakChutnas();
            // zmena chuti slaniny - volání fieldu Chut
            slanina.Chut = "moc dobra";
            slanina.JakChutnas();
            jablko.JakChutnas();
            mrkev.JakChutnas();

            // nakrajeni vsech potravin a sečtení kousků
            int suma = syr.Krajeni() + slanina.Krajeni() + jablko.Krajeni() + mrkev.Krajeni();

            Console.WriteLine("Celkove mame {0} dilku potravin", suma);

            // přístup na atributy tříd ovoce a zeleniny
            Console.WriteLine("Jablko roste na {0}", jablko.Strom);
            Console.WriteLine("Mrkev roste v {0}", mrkev.TypPudy);

        }
    }

    /// <summary>
    /// Obecná třít Potravina
    /// </summary>
    class Potravina
    {
        private string chut;
        public Potravina(string ch)
        {
            Chut = ch;
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
        public Ovoce(string s, string ch) : base(ch)
        {
            this.strom = s;
            Chut = "sladka";
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
        public Zelenina(string t, string ch) : base(ch)
        {
            this.typPudy = t;
            Chut = "slana";
        }
        public string TypPudy { get { return typPudy; } }
        //reimplementace obecne funkce Krajeni() pro konkrétni třídu zelenina
        public override int Krajeni()
        {
            return 20;
        }
    }


}
