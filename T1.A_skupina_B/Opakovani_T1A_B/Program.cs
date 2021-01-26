using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1A_B_R
{
    class Program
    {

        static void Main(string[] args)
        {
            // demonstrace try-catch-finaly
            int[] poleCisel = { 1, 5, 9, 7 };

            try
            {
                Console.WriteLine(poleCisel[20]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Nedostupný index");
            }
            finally
            {
                Console.WriteLine("Konec try-catch sekce");
            }



            // demonstrace práce se strukrutou Obdelnik
            Console.WriteLine("Nacti strany obdelniku");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Obdelnik obdelnik = new Obdelnik(x, y);
            Console.WriteLine("Obdelnik: o = {0}, S = {1}", obdelnik.ObvodObdelniku(), obdelnik.ObsahObdelniku());
            Console.WriteLine("----------------------");

            // demonstrace enumerace
            Console.WriteLine("napište den v týdnu");
            string d = Console.ReadLine();
            Console.WriteLine("{0} je {1}. den v týdnu", d, (int)GetDay(d));
            Console.WriteLine("{0} se anglicky píše {1}", d, GetDay(d));
            Console.WriteLine("----------------");

            // demosntrace switch-case konstrukce s využitím generatoru nahodnych cisel Random()
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 8);
            Console.WriteLine("-- {0} --", rndNumber);
            switch (rndNumber)
            {
                case 1:
                    Console.WriteLine("Bylo vygenerovano cislo jedna");
                    break;
                case 2:
                    Console.WriteLine("Bylo vygenerovano cislo dva");
                    break;
                case 3:
                    Console.WriteLine("Bylo vygenerovano cislo tri");
                    break;
                default:
                    throw new Exception("Neznamy stav vygenerovaneho cisla");
            }

            Console.WriteLine("-------------");
            // demonstrace použití cyklů s pevným počtem opakování
            string[] pole1 = { "ahoj", "kamo", "jak", "se", "mas" };
            string[] pole2 = new string[5];

            for (int i = 0; i < pole2.Length; i++)
            {
                pole2[i] = Console.ReadLine();
            }

            foreach (string s in pole1) // cyklus vhodný na kolekce (pole,list, ...)
            {
                Console.Write(s);

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

        //enumerace reprezentující dny v týdnu
        public enum Days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        // funkce vracejici enumeraci
        private static Days GetDay(string day)
        {
            switch (day.ToLower())
            {
                case "pondělí":
                    return Days.Monday;
                case "úterý":
                    return Days.Tuesday;
                case "středa":
                    return Days.Wednesday;
                case "neděle":
                    return Days.Sunday;
                case "čtvrtek":
                    return Days.Thursday;
                case "pátek":
                    return Days.Friday;
                case "sobota":
                    return Days.Saturday;
                default:
                    throw new Exception("Invalid day");
            }
        }

        public struct Obdelnik
        {
            // konstruktor
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
