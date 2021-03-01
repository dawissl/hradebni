using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Vaším úkolem bude doimplementovat chybějící charakteristiky pro jednotlivé obrazce a tělesa
/// Ovladání je již vyřešené a není třeba jej dále řešit
/// Funkce pro charakteristiku čtverce a krychle jsou pro ukázku vyřešeny
/// Funkce dalších charakteristik jsou již předchystané a je třeba dokončit implementaci
/// Momentálně nedokončené funkce vrací pouze výjimku
/// Pro načítání a výpis hodnot využívejte již vytvořených funkcí
/// Funkce jsou opatřeny komentářem, pro pochopení funkcionality
/// Bonusové body v hodnocení lze získat za vyřešení implementací BEZ potřeby
/// deklarovat proměnné obsah, objem, obvod, povrch
/// (tak jak je použito ve funkcich Ctverec(), Krychle())
/// 
/// </summary>
namespace HW03
{

    class Program
    {
        /// <summary>
        /// Hlavni funkce řešíci ovladani aplikace
        /// </summary>
        /// <param name="args">not used</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulačka povrchů, objemů těles a povrchů, obvodů obrazců");
            Console.WriteLine("==========================================================");
            Menu();
            bool working = true;
            do
            {
                string prikaz = Console.ReadLine().ToUpper();
                switch (prikaz)
                {
                    case "TELESO":
                        CharakteristikaTelesa();
                        break;
                    case "OBRAZEC":
                        CharakteristikaObrazce();
                        break;
                    case "UKONCI":
                        working = false;
                        break;
                    default:
                        Console.WriteLine("\nNeznámá instrukce!\n");
                        Menu();
                        break;

                }
            } while (working);

        }
        /// <summary>
        /// Rozcestnik pro resetni charakteristik obrazců
        /// </summary>
        private static void CharakteristikaObrazce()
        {
            Console.Write("Zvolte obrazec:\n[C]tverec, [O]bdelnik, [T]rojuhelnik, [K]kruh\n:>");
            string obrazec = Console.ReadLine().ToUpper();
            switch (obrazec)
            {
                case "C":
                    Ctverec();
                    break;
                case "O":
                    Obdelnik();
                    break;
                case "T":
                    Trojuhelnik();
                    break;
                case "K":
                    Kruh();
                    break;
                default:
                    Console.WriteLine("\nNeznamy obrazec\n");
                    break;
            }
            Menu();
        }

        /// <summary>
        /// ukazka jiz hotove funkce resici charakteristiku ctverce.
        /// Hotova funkce ukazuje, které funkce máte použít pro načtení hodnot
        /// a zobrazeni vysledku
        /// </summary>
        private static void Ctverec()
        {
            double a = ZiskejHodnotu("strana ctverce");
            double obsah = a * a;
            double obvod = 4*a;
            VypisObrazec(Obrazec.CTVEREC, obsah,obvod);
        }

        private static void Obdelnik()
        {
            throw new NotImplementedException();
        }
        private static void Trojuhelnik()
        {
            throw new NotImplementedException();
        }
        private static void Kruh()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// rozcestinik pro reseni charakteristik teles
        /// </summary>
        private static void CharakteristikaTelesa()
        {
            Console.Write("Zvolte teleso:\n[K]rychle, Kva[D]r, [V]alec, Ku[Z]el, Kou[L]e\n:>");
            string teleso = Console.ReadLine().ToUpper();
            switch (teleso)
            {
                case "D":
                    Kvadr();
                    break;
                case "V":
                    Valec();
                    break;
                case "L":
                    Koule();
                    break;
                case "K":
                    Krychle();
                    break;
                case "Z":
                    Kuzel();
                    break;
                default:
                    Console.WriteLine("\nNezname teleso\n");
                    break;
            }
            Menu();
        }

        /// <summary>
        /// ukazka jiz hotove funkce resici charakteristiku krychle.
        /// Hotova funkce ukazuje, které funkce máte použít pro načtení hodnot
        /// a zobrazeni vysledku
        /// </summary>
        private static void Krychle()
        {
            double a = ZiskejHodnotu("hrana krychle");
            double povrch = 6 * a * a;
            double objem = a * a * a;
            VypisTeleso(Teleso.KRYCHLE, povrch, objem);
        }
        private static void Kvadr()
        {
            throw new NotImplementedException();
        }
        private static void Kuzel()
        {
            throw new NotImplementedException();
        }
        private static void Koule()
        {
           double r = ZiskejHodnotu("Poloměr");
            double objem= 4 / 3.0*Math.PI*r*r*r;
            double povrch = 4 * Math.PI * r * r;
            VypisTeleso(Teleso.KOULE, povrch, objem);
        }
        private static void Valec()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// ovladaci menu aplikace
        /// </summary>
        private static void Menu()
        {
            Console.WriteLine("Ovladani aplikace:");
            Console.WriteLine("TELESO - určení charakteristiky těles.");
            Console.WriteLine("OBRAZEC - určení charakteristiky obrazců.");
            Console.WriteLine("UKONCI - ukončení aplikace.");
            Console.Write("-----------------------------------------\n>");
        }
        /// <summary>
        /// Formatovaný výpis charakteristik obrazce
        /// </summary>
        /// <param name="obrazec">Nazev obrazce - pouzito enumerace</param>
        /// <param name="obsah">Hodnota obsahu obrazce</param>
        /// <param name="obvod">Hodnota obvodu obrazce</param>
        private static void VypisObrazec(Obrazec obrazec, double obsah, double obvod)
        {
            Console.WriteLine("\nCharakteristika obrazce\n[{0}]: S = {1}, o = {2}\n", obrazec,obsah,obvod);
        }
        /// <summary>
        /// Formatovaný výpis charakteristik telesa
        /// </summary>
        /// <param name="teleso">Nazev telesa - pouzito enumerace</param>
        /// <param name="povrch">Hodnota povrchu telesa</param>
        /// <param name="objem">Hodnota objemu telesa</param>
        private static void VypisTeleso(Teleso teleso, double povrch, double objem)
        {
            Console.WriteLine("\nCharakteristika telesa\n[{0}]: S = {1}, V = {2}\n", teleso, povrch, objem);
        }

        /// <summary>
        ///  Funkce pro ziskání hodnoty telesa nebo obrazce z kontrolou vstupu
        /// </summary>
        /// <param name="info">popis jakou hodnotu chceme nacist</param>
        /// <returns>nacteny parametr telesa nebo obrazce</returns>
        private static double ZiskejHodnotu(string info)
        {
            Console.Write("Vlozte hodnotu ({0}):", info);
            string input = Console.ReadLine();

            if (double.TryParse(input, out double result))
            {
                return double.Parse(input);
            }
            else
            {
                Console.WriteLine("Neplatný vstup");
                return ZiskejHodnotu(info);
            }
        }
    }
    /// <summary>
    /// Enumarace obrazcu
    /// </summary>
    enum Obrazec { CTVEREC, OBDELNIK, KRUH, TROJUHELNIK }
    /// <summary>
    /// Enumerace teles
    /// </summary>
    enum Teleso { KRYCHLE, KVADR, KUZEL, VALEC, KOULE }

}
