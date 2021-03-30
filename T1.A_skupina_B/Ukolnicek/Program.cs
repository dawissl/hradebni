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

            bool work = true;
            // zakladni kostra ovladani aplikace UKOLNICEK
            while (work)
            {
                string instrukce = Console.ReadLine().ToUpper();
                switch (instrukce)
                {
                    case "ADD":
                        nasUkolnik.PridejUkol(new Ukol("uklidit pokoj"), 0);
                        break;
                    case "RESOLVE":
                        nasUkolnik.Ukoly[0].Splneno = true;
                        break;
                    case "DISPLAY":
                        nasUkolnik.Prehled(false);
                        nasUkolnik.Prehled(true);
                        break;
                    default:
                        Console.WriteLine("Neznamá isntrukce");
                        break;
                        
                }
            }

            //manualni ovladani aplikace
          /*  Ukol u1 = new Ukol("uklidit pokoj");
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
            nasUkolnik.Prehled(true);
            Console.WriteLine("------------------");
            nasUkolnik.Prehled(false);*/
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


        public Ukol[] Ukoly { get { return ukoly; } }
        // pridani úkolu na pozici v poli
        public void PridejUkol(Ukol u, int pozice)
        {
            ukoly[pozice] = u;
        }

        // vypsání všech splněných nebo nesplněných úkolů
        public void Prehled(bool spl) {
            string prehled = "";

            for (int i = 0; i < ukoly.Length; i++)
            {
                // hodnota null neni pristupna, musime kontrolovat
                // zda se v poli na dane pozici nevyskytuje
                if(ukoly[i] != null)
                {
                    if (ukoly[i].Splneno == spl)
                    {
                        prehled += ukoly[i].ToString() + "\n";
                    }
                }                
            }

            Console.Write(prehled);
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
            return text;
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

    
        public int PocetPolozek()
        {
            return seznam.Length;
        }

        // úprava funkce ToString() pokud bychom ji neupravili,
        // výpis by byl shodný jako ve třídě Ukol
        public override string ToString()
        {
            string vystup = Text + "\n";

            for (int i = 0; i < PocetPolozek(); i++)
            {
                // "\t" značí odsazení tabulátorem
                vystup += "\t" +"+ " + seznam[i] + "\n";
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
            return Text + " splnit do: " + datum;
        }
    }
}
