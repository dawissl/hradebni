using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakovani_1A_S1
{
    class Program
    {
        static void Main(string[] args)
        {
            //demonstrace struktur
            Console.WriteLine("Nacti delky stran obdelniku");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Obdelnik obdelnik = new Obdelnik(x,y);
            Console.WriteLine("Obdelnik: o = {0}, S = {1}",obdelnik.ObvodObdelniku(),obdelnik.ObsahObdelniku());

            // demonstrace enumerace
            Console.WriteLine("Napiš den v týdnu");
            string day = Console.ReadLine();

            Console.WriteLine("{0} je {1}. den v týdnu", day, (int)GetDay(day));
            Console.WriteLine("{0} je anglicky {1}", day, GetDay(day));
            Console.WriteLine("-------------------------");

            // demonstrace try-catch- finally 
            int[] poleCisel = { 1, 2, 3, 4, 5 };

            try
            {
                Console.WriteLine(poleCisel[20]);
                int b = 0;
                int a = 80 / b;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Pozor, saháme mimo defiované pole!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Pozor, dělíme nulou!");
            }
            finally
            {
                Console.WriteLine("Konec try-catch sekce");
            }


            // demonstace switch-case bloku s využitím generatoru nahodných čísel Random()
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 8);
            Console.WriteLine("--- {0} ---", randomNumber);

            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("Vygenerovane cislo je jedna");
                    break;
                case 2:
                    Console.WriteLine("Vygenerovane cislo je dva");
                    break;
                case 3:
                    Console.WriteLine("Vygenerovane cislo je tri");
                    break;
                default:
                    throw new Exception("Invalid number");
            }

            //demonstrace cyklu s pevným počtem opakování
            string[] poleRetezcu = { "Ahoj", "svEte", "!", "jaK", "SE", "mas", "?" };

            for (int i = poleRetezcu.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(poleRetezcu[i].ToUpper());
            }
            Console.WriteLine("------------");
            foreach (string tmp in poleRetezcu)
            {
                Console.WriteLine(tmp.ToLower());
            }
            Console.WriteLine("------------");

            // demonstrace použití cyklu s neznámým počtem opakování while/do-while
            Console.WriteLine("Cykly s neznámým počtem opakování");
            int cislo = int.Parse(Console.ReadLine());
            while (cislo != 0)
            {
                Console.WriteLine("Nactene cislo {0}", cislo);
                cislo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Konec while cyklu\n");

            do
            {
                cislo = int.Parse(Console.ReadLine());
                Console.WriteLine("Nactene cislo {0}", cislo);
            } while (cislo != 0);
            Console.WriteLine("Konec do-while cyklu\n");

            Console.WriteLine("Nacti cislo:");
            // demonstrace užití vnořování funkcí
            Console.WriteLine("Je nactene cislo sude? {0}", Ano(JeSude(int.Parse(Console.ReadLine()))));


        }
        private static bool JeSude(int cislo)
        {
            return (cislo % 2) == 0;
        }

        private static string Ano(bool b)
        {
            if (b)
            {
                return "Ano";
            }
            else
            {
                return "Ne";
            }
        }

        // enumerace
        private enum Days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

        private static Days GetDay(string day)
        {
            switch (day.ToUpper())
            {
                case "PONDĚLÍ":
                    return Days.Monday;
                case "PÁTEK":
                    return Days.Friday;
                case "STŘEDA":
                    return Days.Wednesday;
                case "ÚTERÝ":
                    return Days.Tuesday;
                case "SOBOTA":
                    return Days.Saturday;
                case "NEDĚLE":
                    return Days.Sunday;
                case "ČTVRTEK":
                    return Days.Thursday;
                default:
                    throw new Exception("Invalid day");
            }

        }

        // struktura obdelniku
        public struct Obdelnik
        {

            // konstruktor struktury
            public Obdelnik(int a, int b)
            {
                A = a;
                B = b;
            }
            public int A { get; set; }
            public int B { get; set; }
            public int ObvodObdelniku()
            {
                return 2 * A + 2 * B;
            }
            public int ObsahObdelniku()
            {
                return A * B;
            }
        }
    }
}
