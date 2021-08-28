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
            bool work = true;
            Console.WriteLine("Aplikace úkolníček");
            while (work)
            {
                Console.Write("OPERACE: ");
                string operace = Console.ReadLine().ToUpper();
                switch (operace)
                {
                    case "PRIDEJ":
                        nasUkolnik.pridejUkol();
                        break;
                    case "SPLNENO":
                        nasUkolnik.oznacitSplneni();
                        break;
                    case "VYPIS":
                        nasUkolnik.Prehled(false);
                        break;
                    case "KONEC":
                        work = false;
                        break;
                    default:
                        Console.WriteLine("Neznámá operace");
                        break;
                }
            }


            // vytvoření několika úkolů
            /*  Ukol u1 = new Ukol("uklidit pokoj");
              NakupniSeznam n1 = new NakupniSeznam("nakup na zitra", 2);
              DulezityUkol d1 = new DulezityUkol("danove priznani", "1.5.2021");

              // využítím funkce pridejUkol vložíme na určité pozice vytvořené úkoly
              nasUkolnik.pridejUkol(u1,2);
              nasUkolnik.pridejUkol(n1,5);
              nasUkolnik.pridejUkol(d1,0);

              // využítím přistupové funkce atributu Spleno označíme jeden z úkolů jako hotový
              u1.Spleno = true;

              // vypsaní celého úkolníku
              Console.Write(nasUkolnik.ToString());
              Console.WriteLine("----------------");
              // vypsani pouze splněných úkolů
              nasUkolnik.Prehled(true);
              Console.WriteLine("----------------");
              nasUkolnik.Prehled(false);
            */

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
                if (ukoly[i] != null)
                {
                    vypis = vypis + ukoly[i] + "\n";
                }

            }
            return vypis;
        }

        // vypsani úkolů na základě splnění/nesplěn
        public void Prehled(bool hotovo)
        {
            string vypis = "";
            for (int i = 0; i < 10; i++)
            {
                // pokud na dané pozici úkol není, je zde hodnota null
                // nad hodnotou null nelze volat žádné funkce
                // pokud bychom nad ním funkce volali,
                // vyhodí se nám hláška s výjimkou
                if (ukoly[i] != null)
                {
                    if (ukoly[i].Spleno == hotovo)
                    {
                        vypis += ukoly[i].ToString() + "\n";
                    }
                }
            }

            Console.Write(vypis);
        }

        // zpřístupnění atributu Ukoly - seznamu úkolů
        public Ukol[] Ukoly { get { return ukoly; } }

        // přidání úkolu na danou pozici
        public void pridejUkol(Ukol u, int index)
        {
            ukoly[index] = u;
        }

        // přidání úkolu jako podprogram
        public void pridejUkol()
        {
            // původní ruční volba pozice úkolu
            /*Console.WriteLine("Na jakou pozici úkol přidáme?");
            int tmp = int.Parse(Console.ReadLine());
            if (tmp < 0 || tmp >= 10)
            {
                return;
            }*/

            //nově je úkol přidělen na první volnou pozici nebo nahrazuje již splněný úkol
            int tmp = -1;
            for(int i = 0; i < 10; i++)
            {
                if(ukoly[i] == null)
                {
                    tmp = i;
                    break;
                }
                if (ukoly[i] != null && ukoly[i].Spleno)
                {
                    tmp = i;
                    break;
                }
            }

            // v případě, že se hodnota v tmp nezměnila, žádný slot není volný
            // a žádný úkol není splněn
            if(tmp == -1)
            {
                Console.WriteLine("Ukolnik je plny");
                return;
            }

            //samotné vytvořené úkolu - ideálně obalit try-catch blokem pro odchycení výjimek
            Console.WriteLine("Jaky typ úkolu?");
            string opt = Console.ReadLine().ToLower();
            Ukol novyUkol;
            // na základě volby je do proměnné novyUkol inicializovan nový úkol dle typu úkolu
            switch (opt)
            {
                case "zakladni":
                    novyUkol = new Ukol(Console.ReadLine());
                    break;
                case "nakup":
                    novyUkol = new NakupniSeznam(Console.ReadLine(), int.Parse(Console.ReadLine()));
                    break;
                case "dulezity":
                    novyUkol = new DulezityUkol(Console.ReadLine(), Console.ReadLine());
                    break;
                default:
                    return;
            }
            ukoly[tmp] = novyUkol;
        }


        // označení úkolů jako splněný
        public void oznacitSplneni()
        {
            Console.WriteLine("Který úkol je splněný");
            int tmp = int.Parse(Console.ReadLine());
            if (tmp < 0 || tmp >= 10)
            {
                return;
            }
            // v případě, že na dané pozici úkol není nachází se zde hodnota
            // null o takové hodnotě nelze nic konkrétného říct
            // musíme tedy zkontrolovat, zda tam opravdu null není,
            // abychom mohli daný úkol změnit na splněný
            if(ukoly[tmp] != null)
            {
                ukoly[tmp].Spleno = true;
            }
            else
            {
                Console.WriteLine("Na této pozici úkol není");
            }
            
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
            Console.WriteLine("Nakupni seznam ({0}):", polozky);
            for (int i = 0; i < polozky; i++)
            {
                seznam[i] = Console.ReadLine();
            }

        }

        // vypsani počtu položek seznamu
        public int PocetPolozek()
        {
            return seznam.Length;
        }

        // override funkce ToString pro vypsání položek v nákupním seznamu
        public override string ToString()
        {
            string nakup = Zadani + ":\n";
            for (int i = 0; i < PocetPolozek(); i++)
            {
                nakup = nakup + "\t" + "+ " + seznam[i] + "\n";
            }
            return nakup;
        }

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
