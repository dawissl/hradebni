using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1A_A_R
{
    class Program
    {

        static void Main(string[] args)
        {
            //pouziti struktury Obdelnik
            Console.WriteLine("Nacti strany obdelniku");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Obdelnik obdelnik = new Obdelnik(a, b);
            Console.WriteLine("Obdelnik: o = {0}, S = {1}", obdelnik.ObvodObdelniku(), obdelnik.ObsahObdelniku());
            Console.WriteLine("----------------");

            // pouziti enumerace Days
            Console.WriteLine("Napiš den v týdnu");
            string day = Console.ReadLine();
            Console.WriteLine("{0} je {1}. den v týdnu", day, (int)GetDay(day));

            //demonstrace switch-case s použitím generátoru náhodných čísel Random()
            Random rnd = new Random();
            int rndNum = rnd.Next(1, 8);
            Console.WriteLine("---- {0} ----", rndNum);
            switch (rndNum)
            {
                case 1:
                    Console.WriteLine("Bylo vygenerováno číslo jedna");
                    break;
                case 2:
                    Console.WriteLine("Bylo vygenerováno číslo dva");
                    break;
                case 3:
                    Console.WriteLine("Bylo vygenerováno číslo tři");
                    break;
                case 4:
                    Console.WriteLine("Bylo vygenerováno číslo čtyři");

                    break;
                case 5:
                    Console.WriteLine("Bylo vygenerováno číslo pět");
                    break;
                default:
                    Console.WriteLine("Bylo vygenerováno číslo mimo hlídaný rozsah");
                    break;
            }
            Console.WriteLine("-----------");
            // demonstrace cykly s pevným počtem opakování
            string[] poleStringu = { "Ahoj", "jak", "se", "mas", "kamo", "?", "mam", "se", "fajn" };

            Console.WriteLine(poleStringu.Length);
            for (int i = poleStringu.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(poleStringu[i].ToUpper());
            }
            Console.WriteLine("-------------------------------");
            foreach (string tmp in poleStringu)
            {
                Console.WriteLine(tmp.ToLower());
            }


            // demonstrace použití cyklů s nezmámým počtem opakování
            // vypisování načtených hodnot dokud není načtena 0

            int number;

            do
            {
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("Nactene cislo: {0}", number);

            } while (number != 0);
            Console.WriteLine("Konec do-while cyklu");

            number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                Console.WriteLine("Nactene cislo: {0}", number);
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Konec while cyklu");

            // demonstrace vytváření funkcí a zanořování volání funkcí
            Console.WriteLine("Nacti cislo:");
            Console.WriteLine("Je cislo sude? {0}", Ano(JeSude(int.Parse(Console.ReadLine()))));

        }

        // definice a implementace funkcí v příkladu zanořování funkcí
        private static bool JeSude(int c)
        {
            return (c % 2) == 0;
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

        private static Days GetDay(string d)
        {
            switch (d.ToUpper())
            {
                case "PONDĚLÍ":
                    return Days.Monday;
                case "ÚTERÝ":
                    return Days.Tuesday;

                default:
                    throw new Exception("Invalid day");
            }
        }

        // enumerace
        public enum Days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

        //struktura
        public struct Obdelnik
        {
            // konstruktor nutný pro vytvoření nové konkrétní struktury
            public Obdelnik(int a, int b)
            {
                A = a;
                B = b;
            }

            // parametry struktury (strany obdélníku)
            public int A { get; set; }
            public int B { get; set; }

            //funkce struktury
            public int ObsahObdelniku()
            {
                return A * B;
            }

            public int ObvodObdelniku()
            {
                return 2 * A + 2 * B;
            }
        }

    }
}
