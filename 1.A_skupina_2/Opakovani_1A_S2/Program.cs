using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // demonstrace struktur
            Console.WriteLine("Nacti dve strany obdelniku");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Delky stran jsou: {0}, {1}", x, y);
            Obdelnik obdelnik = new Obdelnik(x, y);
            Console.WriteLine("Obdelnik: o = {0}, S = {1}", obdelnik.ObvodObdelniku(), obdelnik.ObsahObdelniku());

            // demonostrace enumerace
            Console.WriteLine("Vyber den v týdnu:");
            string d = Console.ReadLine();

            Console.WriteLine("{0} se řekne anglicky {1}", d, GetDay(d));
            Console.WriteLine("{0} je  {1}. den v týdnu", d, (int)GetDay(d));

            // demonstrace try-catch-finally

            int[] poleHodnot = { 1, 8, 177, -3 };

            try
            {
                poleHodnot[50]++;
                int b = 0;
                int a = 30 / b;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Chyba v poli indexů");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Děleni nulou");
            }
            finally
            {
                Console.WriteLine("Konec try-catch sekce");
            }


            // demenostrace switch-case pomoci Random
            Random rnd = new Random();
            int cislo = rnd.Next(1, 8);

            Console.WriteLine("-- {0} --", cislo);
            switch (cislo)
            {
                case 1:
                    Console.WriteLine("Vygenerovani cislo 1");
                    break;
                case 2:
                    Console.WriteLine("Vygenerovani cislo 2");
                    break;
                case 3:
                    Console.WriteLine("Vygenerovani cislo 3");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;

            }

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
