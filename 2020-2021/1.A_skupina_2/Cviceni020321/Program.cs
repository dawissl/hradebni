using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni020321
{
    class Program
    {
        static void Main(string[] args)
        {
            // PerfectNumber();

            // NewPrice();

            /*   Point2D p1 = new Point2D(0, 0);

               Point2D p2 = new Point2D(10, 0);
               Point2D p3 = new Point2D(0, -6);
               Point2D p4 = new Point2D(17, -6);

               Console.WriteLine(Distance(p1, p2));
               Console.WriteLine(p1.Distance(p2));
               Console.WriteLine(p2.Distance(p1));

               Console.WriteLine(Distance(p2, p4));
               Console.WriteLine(Distance(p4, p2));*/

            // DecToHex();

            // DecToBin();

            BinToDec();




        }

        private static void BinToDec()
        {
            // 1101 = 1*2^0 + 0* 2^1 + 1 *2^2 + 1*2^3 = 13
            Console.Write("Nacti cislo [2]: ");
            string cislo = Console.ReadLine();
            int noveCislo = 0;
            for (int i = 0; i < cislo.Length; i++)
            {
                string sub = cislo.Substring(cislo.Length - 1 - i, 1);
                int tmp = int.Parse(sub);
                if (tmp != 0)
                {
                    noveCislo += (int)Math.Pow(2, i);
                }
            }

            Console.WriteLine("{0}[2] = {1}[10]", cislo, noveCislo);
        }

        private static void DecToHex()
        {
            // nacteni cisla v desitkove soustave
            Console.Write("Nacti cislo [10]: ");
            int cislo = int.Parse(Console.ReadLine());
            int printCislo = cislo;
            string noveCislo = "";
            string[] hex = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            int zbytek;
            // dokud cislo neni 0 pak opakuj
            while (cislo != 0)
            {
                // zbytek po deleni 16 -> zjisteni hodnoty v 16 soustave
                zbytek = cislo % 16;
                // vytvoreni cisla z jednotlivych casti

                noveCislo = hex[zbytek] + noveCislo;
                // deleni cisla 16
                cislo = cislo / 16;
            }
            // vypsani prevedeneho cisla
            Console.WriteLine("{0}[10] = {1}[16]", printCislo, noveCislo);
        }
        private static void DecToBin()
        {
            // nacteni cisla v desitkove soustave
            Console.Write("Nacti cislo [10]: ");
            int cislo = int.Parse(Console.ReadLine());
            int printCislo = cislo;
            string noveCislo = "";
            string[] bin = { "0", "1" };
            int zbytek;
            // dokud cislo neni 0 pak opakuj
            while (cislo != 0)
            {
                // zbytek po deleni 2 -> zjisteni hodnoty v 16 soustave
                zbytek = cislo % 2;
                // vytvoreni cisla z jednotlivych casti

                noveCislo = bin[zbytek] + noveCislo;
                // deleni cisla 2
                cislo = cislo / 2;
            }
            // vypsani prevedeneho cisla
            Console.WriteLine("{0}[10] = {1}[2]", printCislo, noveCislo);
        }

        private static void NewPrice()
        {
            // nacteni puvodni ceny v Kč
            Console.Write("Původní cena [Kč]: ");
            double price = double.Parse(Console.ReadLine());
            // nacetni změny ceny v %
            Console.Write("Změna ceny [%]: ");
            double change = double.Parse(Console.ReadLine());
            // pokud je zmena kladna -> zvyseni ceny
            // pokud je zmena zaporna -> snizenic ceny
            if (change > 0)
            {
                // zvyseni ceny 
                // 1% ..... price/100
                // change% .... (price/100) * change
                // price ...... price + (price/100) * change

                price = price + (price / 100) * change;
                Console.WriteLine("Nova cena po zvyšení o {0}%  je {1} Kč", change, price);
            }
            else
            {
                // snizeni ceny
                price = price + (price / 100) * change;
                Console.WriteLine("Nova cena po snížení o {0}%  je {1} Kč", change * (-1), price);
            }


            // vypis puvodni a nove ceny
        }

        private static void PerfectNumber()
        {
            // dokonale cislo 1 * 2 * 3 = 6 = 1 + 2 + 3

            // nacist cislo
            Console.Write("Nacti cislo: ");
            int cislo = int.Parse(Console.ReadLine());
            int suma = 0;
            // najit vsechny delitele cisla - pouzijeme %
            for (int i = 1; i < cislo; i++)
            {
                // cislo % i
                if ((cislo % i) == 0)
                {
                    // suma delitelu
                    suma += i;
                }
            }

            // rozhodnutí zda cislo je nebo neni dokonale
            // suma = cislo -> dokonale cislo
            // suma != cislo -> neni dokonale cislo
            if (suma == cislo)
            {
                // dokonale
                Console.WriteLine("Cislo {0} je dokonale", cislo);
            }
            else
            {
                Console.WriteLine("Cislo {0} neni dokonale", cislo);
                // neni dokonalec
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

            public double Distance(Point2D B)
            {
                double dist = 0;
                dist = Math.Sqrt((B.X - X) * (B.X - X) + (B.Y - Y) * (B.Y - Y));
                return dist;
            }
        }

        private static double Distance(Point2D A, Point2D B)
        {
            double dist = 0;
            // X = SQRT( (B.X - A.X)^2 + (B.Y-A.Y)^2 ) 
            dist = Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
            return dist;
        }
    }

}
