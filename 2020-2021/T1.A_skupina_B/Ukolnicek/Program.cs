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
                Console.WriteLine("OPERACE:");
                string instrukce = Console.ReadLine().ToUpper();
                switch (instrukce)
                {
                    case "ADD":
                        nasUkolnik.PridejUkol();
                        break;
                    case "RESOLVE":
                        nasUkolnik.Splneno();
                        break;
                    case "DISPLAY":
                        nasUkolnik.Prehled(false);
                        break;
                    case "EXIT":
                        work = false;
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


        /// <summary>
        /// Funkce řeší přidání úkolu
        /// </summary>
        public void PridejUkol()
        {
            // původní funkcionalita vybární pozice umístění úkolu
            /* Console.WriteLine("Na jakou pozici ukol vložíme?");
             int tmp = int.Parse(Console.ReadLine());
             if (tmp < 0 || tmp >= 10)
             {
                 Console.WriteLine("Index mimo pole!");
                 return;
             }*/

            // automatické vybrání pozice úkolu na první volnou pozici
            // případně nahrazení některého ze splněných úkolů
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

            // pokud se hodnota v tmp nezměnila, není žádný slot volný a úkoly nejsou splněné
            if (tmp == -1)
            {
                Console.WriteLine("Ukolnik je plny");
                return;
            }

            // samotné vytvoření úkolu obalené try-catch pro odychené výjimek
            // nachází se zde hodně neošetřených čtení z konzole
            try
            {
                Console.WriteLine("Jaky typ ukolu?");
                string opt = Console.ReadLine();
                Ukol novyUkol;
                // na zakladě typu se do promněnné novyUkol inicializuje příslušný nový úkol daného typu
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
                        Console.WriteLine("Neznámý typ úkolu");
                        return;
                }
                ukoly[tmp] = novyUkol;
            }
            catch (Exception e)
            {
                Console.WriteLine("Chyba při vkládání úkolu: {0}",e.Message);
                return;
            }
        }

        /// <summary>
        /// Označení úkolu za splněný
        /// </summary>
        public void Splneno()
        {
            Console.WriteLine("Jaký úkol je splněný?");
            try
            {
                int tmp = int.Parse(Console.ReadLine());

                if (tmp < 0 || tmp >= 10)
                {
                    Console.WriteLine("Index mimo pole!");
                    return;
                }


                // využití příkazů is a as pro zjištění datového typu a přetypování objektu pro práci
                if (ukoly[tmp] != null)
                {
                    // v pripadě, že se jedná o nákupní seznam odeber poslední položku z nákupu -> přejmenování na XXXXX
                    if (ukoly[tmp] is NakupniSeznam)
                    {
                        Console.WriteLine("Odebrani polozky z nakupu");
                        (ukoly[tmp] as NakupniSeznam).odeberPosledni();
                    }
                    else
                    {
                        //pokud se nejedná o nákupní seznam, označ za splněný
                        ukoly[tmp].Splneno = true;
                    }

                }
                else
                {
                    Console.WriteLine("Na dané pozici úkol neexistuje");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Chyba aplikace: {0}",e.Message);
                return;
            }

        }

        // vypsání všech splněných nebo nesplněných úkolů
        public void Prehled(bool spl)
        {
            string prehled = "";

            for (int i = 0; i < ukoly.Length; i++)
            {
                // hodnota null neni pristupna, musime kontrolovat
                // zda se v poli na dane pozici nevyskytuje
                if (ukoly[i] != null)
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

        public void odeberPosledni()
        {
            seznam[PocetPolozek() - 1] = "XXXXXXXXXXXXXXXX";
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
                vystup += "\t" + "+ " + seznam[i] + "\n";
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
