using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukolnicek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ukolnik nasUkolnik = new Ukolnik();
            // proměnná sloužící k ukončení programu
            bool work = true;

            // jednoduché ovládání za použití while cyklu a switch-case konstrukce
            // ideálně jazykově sladit s dalšími instrukcemi
            // ADD -> PRIDAT, RESOLVE -> SPLNIT, DISPLAY -> ZBYVA, EXIT -> KONEC
            while (work)
            {
                string operace = Console.ReadLine().ToUpper();
                switch (operace)
                {
                    case "ADD":
                        nasUkolnik.PridejUkol();
                        break;
                    case "RESOLVE":
                        nasUkolnik.SplneniUkolu();
                        break;
                    case "DISPLAY":
                        nasUkolnik.Prehled(false);
                        break;
                    case "EXIT":
                        work = false;
                        break;
                    default:
                        Console.WriteLine("Neznama instrukce");
                        break;
                }
            }

            // manualni práce s třídami úkolník a úkol

           /* Ukol u1 = new Ukol("Uklidit pokoj");
            Ukol n1 = new NakupniSeznam("Nakup na vikend", 2);
            Ukol d1 = new DulezityUkol("Elektřina", "31.3.2021");

            nasUkolnik.PridejUkol(u1, 5);
            nasUkolnik.PridejUkol(n1, 0);
            nasUkolnik.PridejUkol(d1, 8);

            u1.Splneni = true;


            //Console.WriteLine(nasUkolnik.ToString());

            nasUkolnik.Prehled(false);*/
        }
    }

    /// <summary>
    /// Třída úkolník -10 úkolů s možností označit úkol za splněný
    /// </summary>
    class Ukolnik
    {
        private Ukol[] ukoly = new Ukol[10];
        // konstruktor třídy neuvádíme, nejsou žádné hodnoty, které
        // bychom potřebovali vložit při vytváření nové instance

        //zpřístupnění pole ukoly - není již potřeba
        public Ukol[] Ukoly { get { return ukoly; } }

        /// <summary>
        /// Přidání konkrétího úkolu na konkrétní pozici - funkce se již nepoužívá
        /// slouží k testování
        /// </summary>
        /// <param name="u"> úkol k vložení</param>
        /// <param name="index">pozice kam úkol vložit</param>
        public void PridejUkol(Ukol u, int index)
        {
            if (index >= 10 || index < 0)
            {
                throw new Exception("Invalid index");
            }
            ukoly[index] = u;
        }

        /// <summary>
        /// Přidání úkolu
        /// </summary>
        public void PridejUkol()
        {
            // puvodní volba pozice úkolu - úkol je nahrazen nehledě na splnění
            /* Console.WriteLine("Na kterou pozici?");
             int index = int.Parse(Console.ReadLine());
             if (index >= 10 || index < 0)
             {
                 throw new Exception("Invalid index");
             }*/

            // malá procedura na odhalení prázdné pozice v úkolníku
            // opět by šla oddělit do samostatné funkce
            int index = -1;
            for (int i = 0; i < 10; i++)
            {
                if (ukoly[i] == null)
                {
                    index = i;
                    break;
                }

                if(ukoly[i].Splneni == true)
                {
                    index = i;
                    break;
                }
            }
            // pokud je hodnota totožná s tou při deklaraci, index se nezměnil a není
            // zde volné místo - je zbytečné vytvářet úkol a vracíme ovládání zpět
            if(index == -1)
            {
                Console.WriteLine("Ukolnik je plný");
                return;
            }

            try
            {

                // vytvoreni samotného úkolu
                // -> humpolacka implementace lepší odladit pro uživatele
                Console.WriteLine("Jaky ukol vytorit?");
                string ukol = Console.ReadLine().ToUpper();
                Ukol novyUkol;
                // podle instrukce vytváříme novou instanci úkolu
                switch (ukol)
                {
                    case "ZAKLADNI":
                        novyUkol = new Ukol(Console.ReadLine());
                        break;
                    case "NAKUP":
                        novyUkol = new NakupniSeznam(Console.ReadLine(), int.Parse(Console.ReadLine()));
                        break;
                    case "DULEZITY":
                        novyUkol = new DulezityUkol(Console.ReadLine(), Console.ReadLine());
                        break;
                    default:
                        throw new Exception("Neznamy ukol");
                }

                // samotné přidání úkolu na danou pozici
                ukoly[index] = novyUkol;
            } catch(Exception e)
            {
                Console.WriteLine("Chyba při vytváření úkolu: {0}",e.Message);
            }
        }

        /// <summary>
        /// Vypsání úkolů které jsou splněné/nesplněné
        /// </summary>
        /// <param name="spl"> Parametr, který rozhoduje, kterou skupinu úkolů vypsat</param>
        public void Prehled(bool spl)
        {
            string vypis = "";
   
            for (int i = 0; i < 10; i++)
            {
                if(ukoly[i] != null)
                {
                    if (ukoly[i].Splneni == spl)
                    {
                        vypis += ukoly[i].ToString() + "\n";
                    }
                }
                
            }
            Console.WriteLine(vypis);
        }

        /// <summary>
        /// Funkce umoňující označit úkol za splněný
        /// </summary>
        public void SplneniUkolu()
        {
            Console.WriteLine("Který úkol byl splněn?");
            int tmp = int.Parse(Console.ReadLine());
            // máme pouze 10 úkolů a kontrolujeme index pole
            if(tmp>=10 || tmp < 0)
            {
                throw new Exception("Invalid index");
            }

            // počítáme s variantou, že chceme změnit úkol na pozici, kde úkol není
            // a je zde hodnota null - předcházíme Exception
            if(ukoly[tmp] != null)
            {
                ukoly[tmp].Splneni = true;
            }
            else
            {
                Console.WriteLine("Na zadané pozici není úkol");
            }            
        }

        // přepsání funkce ToString() bez přepásní této funkce nemáme představu o výpisu
        // funkce je děděná z obecné třídy Object
        public override string ToString()
        {
            string vystup = "";
            for (int i = 0; i < 10; i++)
            {
                vystup += ukoly[i] + "\n";
            }
            return vystup;
        }

    }

    /// <summary>
    /// Základní třída úkol
    /// </summary>
    class Ukol
    {
        private string zadani;
        private bool splneni;

        public Ukol(string z)
        {
            zadani = z;
            splneni = false;
        }

        // zpřístupnění atributů
        // všimněte si, že zadani lze zobrazit, ale nelze jej změnit (chybí funkce set)
        public string Zadani { get { return zadani; } }
        public bool Splneni { get { return splneni; } set { splneni = value; } }

        public override string ToString()
        {
            return zadani;
        }
    }

    /// <summary>
    /// Třída nákupní seznam rozšiřující třídu úkol
    /// </summary>
    class NakupniSeznam : Ukol
    {
        private string[] seznam;

        // konstruktor odvozené třídy - v sekci : base (x,y,z,...) uvádíme parametry s nadřazené třídy
        public NakupniSeznam(string z, int p) : base(z)
        {
            seznam = new string[p];
            // v rámci konstruktoru plníme nákupní seznam - lepší by bylo plnění 
            // přesunout do vlastní funkce pro přehlednost
            Console.WriteLine("Nakupni seznam({0}):", p);
            for (int i = 0; i < p; i++)
            {
                seznam[i] = Console.ReadLine();
            }
        }

        public int PocetPolozek()
        {
            return seznam.Length;
        }

        public override string ToString()
        {
            string nakup = Zadani + "\n";
            // pro odsazení textu využíváme netisknutelný znak \t - tabulátor
            for (int i = 0; i < PocetPolozek(); i++)
            {
                nakup += "\t" + "+ " + seznam[i] + "\n";
            }

            return nakup;
        }
    }
    /// <summary>
    /// Třída důležitý úkol rozšířující třídu úkol
    /// </summary>
    class DulezityUkol : Ukol
    {
        private string datum;

        public DulezityUkol(string z, string d) : base(z)
        {
            datum = d;
        }

        public override string ToString()
        {
            return Zadani + " splnit do: " + datum;
        }
    }
}
