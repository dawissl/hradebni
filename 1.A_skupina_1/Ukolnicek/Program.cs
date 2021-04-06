using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * třída Ukolnik - obsahuje pole 10 položek (úkolů)
              - má funkci string ToString() pro vypsání všech úkolů
              - má funkci string Prehled(bool splneni) - která vypíše všechny splněné/nesplněné úkoly
              
třída Ukol - atributy text a splněno
           - má funkci void Splneno(bool hotovo) - funkce označí úkol za splněný/nesplněný

třída NakupniSeznam - pole retezcu
                    - vypise počet polozek

třída DulezityUkol - datum připomenuti
 */
/// <summary>
/// @author = David Sládeček
/// </summary>
namespace Ukolnicek
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarace a inicializace třídy Ukolnik pro další práci
            Ukolnik nasUkolnik = new Ukolnik();
           
            bool work = true;
            Console.WriteLine("Aplikace úkolníček");
            // smyčka cyklu pro řízení aplikace s využitím proměnné jako podmínky cyklu
            while (work)
            {
                // rozhraní s možnými instrukcemi
                Console.Write("Načtení operace: ");
                string operace = Console.ReadLine().ToLower();
                switch (operace)
                {
                    case "pridat":
                        nasUkolnik.PridejUkol();
                        break;
                    case "hotovo":
                        nasUkolnik.PlneniUkolu();
                        break;
                    case "prehled":
                        nasUkolnik.Prehled(false);
                        break;
                    case "konec":
                        work = false;
                        break;
                    default:
                        Console.WriteLine("Neznámá instrukce");
                        break;
                }
            }

            // puvodni testovací příkazy pro zjištění funkcionality aplikace - nahrazeno ovládáním
            /*  Ukol u1 = new Ukol("Uklidit pokoj");
              Ukol n1 = new NakupniSeznam("Nakup na vikend", 2);
              Ukol d1 = new DulezityUkol("Elektřina", "31.3.2021");

              nasUkolnik.PridejUkol(u1, 5);
              nasUkolnik.PridejUkol(n1, 0);
              nasUkolnik.PridejUkol(d1, 8);

              u1.Splneno = true;

              Console.WriteLine(nasUkolnik.ToString());
              Console.WriteLine("-------------------");
              nasUkolnik.Prehled(false);
              Console.WriteLine("-------------------");
              nasUkolnik.Prehled(true);*/
        }
    }

    /// <summary>
    /// Třída Úkolník držící 10 úkolů v poli 
    /// </summary>
    class Ukolnik
    {
        Ukol[] ukoly = new Ukol[10];

        // zpřéstupnění úkolů, lze úkoly získat ale nelze je měnit
        public Ukol[] Ukoly { get { return ukoly; } }

        /// <summary>
        /// Přidání již hotového úkolu na konkrétní pozici.
        /// Nový úkol vždy přepíše původní na dané pozici
        /// </summary>
        /// <param name="u"> úkol k vložení</param>
        /// <param name="pozice"> pozice v poli úkolů</param>
        public void PridejUkol(Ukol u, int pozice)
        {
            ukoly[pozice] = u;
        }

        /// <summary>
        /// Pokročilejší metoda přidání úkolu - podprogram pro práci 
        /// </summary>
        public void PridejUkol()
        {
            // původní řešení, kdy jsme si sami vybírali pozici pro uložení
            /* Console.WriteLine("Na jakou pozici úkol vložit?");
             int tmp = int.Parse(Console.ReadLine());
             if(tmp<0 || tmp >= 10)
             {
                 Console.WriteLine("--- Chyba při vytváření úkolu ---");
                 return;
             }*/

            // vybrání pozice pro uložení
            // úkol je umístěn na první volné místo nebo nahradí
            // již splněný úkol
            int tmp = -1;
            for (int i = 0; i < 10; i++)
            {
                if (ukoly[i] == null)
                {
                    tmp = i;
                    break;
                }

                if (ukoly[i] != null && ukoly[i].Splneno)
                {
                    tmp = i;
                    break;
                }
            }

            // v případě, že není volný slot na úkol a žádný není hotový nelze přidat úkol
            if (tmp == -1)
            {
                Console.WriteLine("--- Úkolník je plný ---");
                return;
            }

            // samotné vytvoření úkolu obalené v try-catch bloku 
            // z důvodu častého neošetřeného načítání z konzole
            try
            {
                Console.WriteLine("Jaký typ úkolu?");
                string typUkolu = Console.ReadLine().ToLower();
                Ukol novyUkol;
                // na základě typu úkolu se proměnná novyUkol inicializuje na daný typ
                switch (typUkolu)
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
                        Console.WriteLine("--- Neznamý typ úkolu ---");
                        return;
                }
                ukoly[tmp] = novyUkol;
            }
            catch (Exception e) // odchytáváme obecně všechny výjimky
            {
                Console.WriteLine("Chyba při vytváření úkol: {0}", e.Message);
                return;
            }
        }

        /// <summary>
        /// Označení úkolu jako splněného
        /// </summary>
        public void PlneniUkolu()
        {
            Console.WriteLine("Který úkol je splněný?");
            // try-catch je zde využit pro parsování číselné hodnoty
            // šlo by nahradit voláním TryParse
            try
            {
                int tmp = int.Parse(Console.ReadLine());
                // nelze označit úkol mimo rozsah pole
                if (tmp < 0 || tmp >= 10)
                {
                    Console.WriteLine("--- Chyba při označení úkolu ---");
                    return;
                }

                // pokud by na dané pozici bylo místo volné - hodnota null nelze
                // o této hodnotě říct nic jiného
                if (ukoly[tmp] != null)
                {
                    ukoly[tmp].Splneno = true;
                }
                else
                {
                    // případ, kdy se na dané pozici úkol nevyskytuje
                    Console.WriteLine("--- Na dané pozici neexistuje úkol ---");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Chyba při plnění úkolu: {0}", e.Message);
                return;
            }


        }

        /// <summary>
        /// Vypsání všech splněných nebo nesplněných úkolů
        /// </summary>
        /// <param name="hotovo"> true pro splněné, false pro vypsání nesplněných</param>
        public void Prehled(bool hotovo)
        {
            string vystup = "";

            for (int i = 0; i < 10; i++)
            {
                if (ukoly[i] != null)
                {
                    if (ukoly[i].Splneno == hotovo)
                    {
                        vystup += ukoly[i] + "\n";
                    }
                }
            }
            vystup += "---- Konec výpisu ----";
            Console.WriteLine(vystup);
        }

        public override string ToString()
        {
            string vystup = "";

            for (int i = 0; i < 10; i++)
            {
                if (ukoly[i] != null)
                {
                    vystup += ukoly[i] + "\n";
                }
            }

            return vystup;
        }
    }

    /// <summary>
    /// Tříd Ukol je hlavní třídou pro ukládané úkoly
    /// </summary>
    class Ukol
    {
        private string text;
        private bool splneno;

        //  zpřístupněnění atributů, pouze Splněno lze měnit hodnotu
        public string Text { get { return text; } }
        public bool Splneno { get { return splneno; } set { splneno = value; } }

        public Ukol(string zadani)
        {
            text = zadani;
            splneno = false;
        }

        public override string ToString()
        {
            return text;
        }

    }

    /// <summary>
    /// Třída rozšiřující třídu Ukol
    /// </summary>
    class NakupniSeznam : Ukol
    {
        private string[] seznam;

        // konstruktor odvozené třídy, v sekce base se odkazujeme na vstupní parametry,
        // které řeší konstruktor nadřazené třídy
        public NakupniSeznam(string zadani, int pocetPolozek) : base(zadani)
        {
            seznam = new string[pocetPolozek];
            // v rámci vytváření instance z třídy NakupniSeznam
            // vkládáme i jednotlivé položky
            // nejedná se o vhodné řešení, lepší by bylo tuto část osamostatnit do vlastní funkce
            Console.WriteLine("Seznam polozek:");
            for (int i = 0; i < pocetPolozek; i++)
            {
                Console.Write("polozka {0}: ", i);
                seznam[i] = Console.ReadLine();
            }
        }

        public int PocetPolozek()
        {
            return seznam.Length;
        }

        public override string ToString()
        {
            string vystup = Text + ":\n";
            for (int i = 0; i < PocetPolozek(); i++)
            {
                vystup += "\t * " + seznam[i] + "\n";
            }

            return vystup;
        }
    }

    /// <summary>
    /// Obdobně jako třída NakupniSeznam rozšiřuje třídu Ukol
    /// </summary>
    class DulezityUkol : Ukol
    {
        private string datum;

        public DulezityUkol(string zadani, string datumPlneni) : base(zadani)
        {
            datum = datumPlneni;
        }

        public override string ToString()
        {
            return Text + " je nutné vyřešit do " + datum;
        }
    }
}
