using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni230221
{
    class Program
    {
        static void Main(string[] args)
        {
            /*NovaCena();
            Console.WriteLine("------------------------------");
            DokonaleCislo();*/

            /* Point2D p1 = new Point2D(0, 0);
             Point2D p2 = new Point2D(0, -3);

             Point2D p3 = new Point2D(12, 0);

             Console.WriteLine(distance(p1,p2));

             Console.WriteLine(p1.distance(p2));

             Console.WriteLine(p2.distance(p3));*/

            // DecToHex();

            //  DecToBin();

            BinToDec();

        }

        private static void BinToDec()
        {
            // 101 = 1 *2^0 + 0 * 2^1 + 1*2^2 = 5
            Console.Write("Nacti cislo[2]: ");

            string cislo = Console.ReadLine();
            int noveCislo = 0;
            for(int i = 0; i < cislo.Length; i++)
            {
                int tmp = int.Parse(cislo.Substring(cislo.Length - 1 - i,1));
                if(tmp == 1)
                {
                    noveCislo += (int)Math.Pow(2,i);
                }
            }
            Console.WriteLine("{0}[2] = {1}[10]", cislo, noveCislo);

        }

        private static void DecToHex()
        {
            // nacteni cisla k prevedeni
            Console.Write("Nacti cislo[10]: ");
            int cislo = int.Parse(Console.ReadLine());
            int zbytek;
            string noveCislo = "";
            string[] hex = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            int tmp = cislo;
            while (tmp != 0)
            {
                // zbytek po deleni zakladu nove soustavy
                zbytek = tmp % 16;
                // podle zbytku urcime nove cislo v dane soustave
                noveCislo = hex[zbytek] + noveCislo;
                // cislo delime zakladem
                tmp = tmp / 16;
            }// tyto kroky opakujeme dokud cislo != 0

            Console.WriteLine("{0}[10] = {1}[16]", cislo, noveCislo);
        }

        private static void DecToBin()
        {
            // nacteni cisla k prevedeni
            Console.Write("Nacti cislo[10]: ");
            int cislo = int.Parse(Console.ReadLine());
            int zbytek;
            string noveCislo = "";
            string[] hex = { "0", "1" };
            int tmp = cislo;
            while (tmp != 0)
            {
                // zbytek po deleni zakladu nove soustavy
                zbytek = tmp % 2;
                // podle zbytku urcime nove cislo v dane soustave
                noveCislo = hex[zbytek] + noveCislo;
                // cislo delime zakladem
                tmp = tmp / 2;
            }// tyto kroky opakujeme dokud cislo != 0

            Console.WriteLine("{0}[10] = {1}[2]", cislo, noveCislo);
        }

        private static void DokonaleCislo()
        {
            // nacist cislo
            Console.Write("Nacti cislo pro zjištění dokonalosti: ");
            int number = int.Parse(Console.ReadLine());
            int suma = 0;
            // najit delitele cisla pomoci %
            for (int i = 1; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    //delitele secist
                    suma += i;
                }
            }
            // porovnat soucet vsech delitelu s cislem
            if (suma == number)
            {
                Console.WriteLine("Cislo {0} je dokonale", number);
            }
            else
            {
                Console.WriteLine("Cislo {0} není dokonale", number);
            }
        }

        private static void NovaCena()
        {
            // nacteni puvodni cenu
            Console.Write("Puvodní cena produtu [Kč]: ");
            double price = double.Parse(Console.ReadLine());
            // nacteni slevy
            Console.Write("Změna ceny [%]: ");

            double change = double.Parse(Console.ReadLine());
            // záporné cislo znamená slevu
            // kladné číslo znamená zvýšení ceny
            if (change > 0)
            {

                // 100% .............. price
                // 1% ................ price/100
                // 100 + change % ...... (price/100) * (100 + change);
                price = (price / 100) * (100 + change);
                Console.WriteLine("Cena produktu po zvýšení o {0}% je {1}", change, price);
            }
            else
            {
                price = (price / 100) * (100 + change);
                Console.WriteLine("Cena produktu po snižení o {0}% je {1}", change * (-1), price);
            }
        }

        struct Point2D
        {
            public Point2D(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }

            public double distance(Point2D B)
            {
                double dist = 0;
                dist = Math.Sqrt((B.X - X) * (B.X - X) + (B.Y - Y) * (B.Y - Y));
                return dist;
            }
        }

        private static double distance(Point2D A, Point2D B)
        {
            double dist = 0;
            dist = Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
            return dist;
        }
    }
}
