using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 třída Ukolnik - obsahuje pole 10 položek (úkolů)
              - má funkci string ToString() pro vypsání všech úkolů
              - má funkci string Prehled(bool splneni) - která vypíše všechny splněné/nesplněné úkoly
              
třída Ukol - atributy text a splněno
           - má funkci void Splneno(bool hotovo) - funkce označí úkol za splněný/nesplněný

třída NakupniSeznam - pole retezcu
                    - vypise počet polozek

třída DulezityUkol - datum připomenuti
 */

/// <summary>
/// @author = David Sladecek
/// </summary>
namespace Ukolnicek
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarace instance třídy Ukolnik
            Ukolnik nasUkolnik = new Ukolnik();

            // vytvoření několika úkolů
            Ukol u1 = new Ukol("uklidit pokoj");
            NakupniSeznam n1 = new NakupniSeznam("nakup na zitra", 2);
            DulezityUkol d1 = new DulezityUkol("danove priznani", "1.5.2021");
            
            // využítím funkce pridejUkol vložíme na určité pozice vytvořené úkoly
            nasUkolnik.pridejUkol(u1,2);
            nasUkolnik.pridejUkol(n1,5);
            nasUkolnik.pridejUkol(d1,0);

            // využítím přistupové funkce atributu Spleno označíme jeden z úkolů jako hotový
            u1.Spleno = true;

            // vypsaní celého úkolníku
            Console.WriteLine(nasUkolnik.ToString());


        }
    }

    /// <summary>
    /// Třída úkolník, která umí spravovat 10 úkolů
    /// </summary>
    class Ukolnik
    {
        // jediny atribut třídy - pole 10 úkolů
        private Ukol[] ukoly = new Ukol[10];

        //konstruktor není třeba psát, nepřijímáme žádné vstupní hodnoty

        // přepsání funkce ToString pro výpis všech úkolů v poli
        public override string ToString()
        {
            string vypis = "";
            for (int i = 0; i < 10; i++)
            {
                vypis = vypis + ukoly[i] + "\n";
            }
            return vypis;
        }

        // zpřístupnění atributu Ukoly - seznamu úkolů
        public Ukol[] Ukoly  { get{ return ukoly; } }

        // přidání úkolu na danou pozici
        public  void pridejUkol (Ukol u, int index)
        {
            ukoly[index] = u;
        }

    }

    /// <summary>
    /// Výchozí třída úkol
    /// </summary>
    class Ukol
    {
        // atributy třídy Ukol
        private string zadani;
        private bool splneno;

        // v konstruktoru přijámáme pouze zadání, předpokládáme, že nově vytořený
        // úkol není splněný
        public Ukol(string z)
        {
            zadani = z;
            splneno = false;
        }

        // zpřístupnění atributů třídy Ukol
        public string Zadani { get { return zadani; } }
        public bool Spleno { get { return splneno; } set { splneno = value; } }

        // Ve výpisu úkolu nám postačí pouze zadání
        public override string ToString()
        {
            return zadani;
        }


    }

    /// <summary>
    /// Třída odovzená z výchozího úkolu
    /// </summary>
    class NakupniSeznam : Ukol
    {
        // vlastní atribut, atribut zadni a splněno je zděděn
        private string[] seznam;

        // konstruktor třídy, zděděné atributy uvádíme v sekci : base (x,y,z,..)
        public NakupniSeznam(string s, int polozky) : base(s)
        {
            // v konstruktoru už můžeme definovat velikost pole a naplnit jej
            // elegantnější by bylo naplnění přesunout do vlastní funkce
            seznam = new string[polozky];
            for (int i = 0; i < polozky; i++)
            {
                seznam[i] = Console.ReadLine();
            }

        }

        // nepřepisujeme funkci ToStrin\g Výpis bude tedy stejný jako u třídy Ukol

    }

    /// <summary>
    /// Třída odvozená z třídy Ukol
    /// </summary>
    class DulezityUkol : Ukol
    {
        // vlastní atribut, atribut zadni a splněno je zděděn
        private string datum;
        public DulezityUkol(string s, string d) : base(s)
        {
            datum = d;
        }

        // přepsání funkce ToString(), tato třída se bude vypisovat jinak než třída Ukol
        public override string ToString()
        {
            return Zadani + " do: " + datum;
        }
    }
}
