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
/// @ authpr= DWS
/// </summary>
namespace Ukolnicek
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarace vlastnío Úkolníčku
            Ukolnik nasUkolnik = new Ukolnik();

            //deklarace několika úkolů
            Ukol u1 = new Ukol("uklidit pokoj");
            NakupniSeznam n1 = new NakupniSeznam("Nakup na zitra", 3);
            DulezityUkol d1 = new DulezityUkol("Danove priznani", "1.5.2021");

            // využítí funkce PridejUkol třídy Ukolnik pro vložení úkolů na pozici v poli
            nasUkolnik.PridejUkol(u1, 3);
            nasUkolnik.PridejUkol(n1, 0);
            nasUkolnik.PridejUkol(d1, 8);

            // oznaceni ukolu za splněný pomocí funkce Splněno zpřístupňující atribut třídy 
            n1.Splneno = true;

            // vypis pouze splněných úkolů - need fix
            Console.WriteLine("Náš úkolníček obsahuje:");
            Console.WriteLine(nasUkolnik.Vypis(true));
        }
    }

    /// <summary>
    /// Třída úkolník, která umí spravovat 10 úkolů
    /// </summary>
    class Ukolnik   
    {
        // atribut třídy - pole 10 úkolů
        private Ukol[] ukoly = new Ukol[10];

        // konstruktor neuvádíme není třeba přijímat atributy pro vytvoření Ukolniku

        // pridani úkolu na pozici v poli
        public void PridejUkol(Ukol u, int pozice)
        {
            ukoly[pozice] = u;
        }

        // vypsání všech splněných nebo nesplněných úkolů
        // TODO - need to handle null values
        public string Vypis(bool spl) {
            string vystup = "";

            for (int i = 0; i < ukoly.Length; i++)
            {
                if (spl)
                {
                    // null possible - need fix
                    if (ukoly[i].Splneno)
                    {
                        vystup += ukoly[i] + "\n";
                    }
                }
                else
                {
                    // null possible - need fix
                    if (!ukoly[i].Splneno)
                    {
                        vystup += ukoly[i] + "\n";
                    }
                }
            }

            return vystup;
        }

        // přepsání funkce ToString() pro přehlednější výpis třídy
        public override string ToString()
        {
            string vystup = "";

            for (int i = 0; i < ukoly.Length; i++)
            {
                vystup += ukoly[i] + "\n";
            }

            return vystup;
        }

    }

    /// <summary>
    /// Třída Ukol reprezentující obecný úkol v úkolníčku
    /// </summary>
    class Ukol
    {
        // atributy zadání úkolu a informace o splnění/nesplnění
        private string text;
        private bool splneno;

        // v konstruktoru přijámáme pouze zadání úkolu, předpokládáme, že vytvořený úkol není splněný
        public Ukol(string u)
        {
            text = u;
            splneno = false;
        }

        // zpřístupnění atributů
        // get nám umožňuje pomoci X.Splneno ziskat hodnotu v atributu
        // set nám umožňuje změnit hodnotu v atribut X.Splneno = nova hodnota
        public bool Splneno { get { return splneno; } set { splneno = value; } }
        public string Text { get { return text; } }

        // úprava funkce ToString() vypisujeme zadání a info o splnění
        public override string ToString()
        {
            return text + " - " + splneno;
        }
    }

    /// <summary>
    /// Třída rozšiřující třídu Ukol
    /// </summary>
    class NakupniSeznam : Ukol
    {
        // vlastni atribut, atributy text a splneno jsou děděny
        private string[] seznam;

        // konstruktor podradne tridy, v sekci : base( x,y,z,...) uvadime vstupni parametry
        // ktere jsou reseny v nadrazene tridy ze ktere je tato třída odovzena
        public NakupniSeznam(string u, int polozky) : base(u)
        {
            // známe počet položek, můžeme deklarovat velikost pole
            seznam = new string[polozky];
            // naplnění nakupniho seznamu 
            // elegantnější řešení by bylo vytvořit samostatnou funkci pro načtení hodnot
            for (int i = 0; i < polozky; i++)
            {
                Console.Write("polozka: ");
                seznam[i] = Console.ReadLine();
            }
        }

        // úprava funkce ToString() pokud bychom ji neupravili,
        // výpis by byl shodný jako ve třídě Ukol
        public override string ToString()
        {
            string vystup = Text + " " + Splneno + "\n";

            for (int i = 0; i < seznam.Length; i++)
            {
                // "\t" značí odsazení tabulátorem
                vystup += "\t" + seznam[i] + "\n";
            }

            return vystup;
        }
    }

    class DulezityUkol : Ukol
    {
        private string datum;

        public DulezityUkol(string u, string d) : base(u)
        {
            datum = d;
        }

        public override string ToString()
        {
            return Text + " splnit do: " + datum + " - " + Splneno;
        }
    }
}
