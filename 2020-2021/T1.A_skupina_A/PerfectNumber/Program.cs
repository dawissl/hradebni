using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            PerfectNumber();

             Point2D bod1 = new Point2D(14, 0);
             Point2D bod2 = new Point2D(0, 0);
             Point2D bod3 = new Point2D(-1, 3);

             Vzdalenost(bod1, bod2);
             bod3.Vzdalenost(bod1);

            ChangeOfPrice();

            DecToHex();

            BinToDec();

            DecToBin();


        }

        private static void BinToDec()
        {
            string cislo = Console.ReadLine();
            int noveCislo = 0;
            

            for (int i = 0; i < cislo.Length; i++)
            {
                int num = int.Parse(cislo.Substring(cislo.Length - 1 - i, 1));
                if (num == 1)
                {
                    noveCislo += (int)Math.Pow(2, i);
                }
            }

            Console.WriteLine("{0}[2] = {1}[10]", cislo, noveCislo);

        }

        private static void DecToHex()
        {
            // nacteni cisla v desitkove soustave
            Console.Write("Cislo [10]:");
            int cislo = int.Parse(Console.ReadLine());
            // dokud zbytek po deleni neni 0
            int zbytek;
            string noveCislo = "";
            string[] hex = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            do
            {
                zbytek = cislo % 16;
                // a urci hodnotu v hexadecimalni soustave
                noveCislo = hex[zbytek] + noveCislo;

                cislo = cislo / 16;

            } while (cislo != 0);
            // pak podel cislo 16


            //vypsani cisla v hexadecimalni soustave
            Console.WriteLine("{0}[10] = {1}[16]",cislo,noveCislo);
        }

        private static void DecToBin()
        {
            // nacteni cisla v desitkove soustave
            int cislo = int.Parse(Console.ReadLine());
            // dokud zbytek po deleni neni 0
            int zbytek;
            string noveCislo = "";
            string[] bin = { "0", "1" };
            do
            {
                zbytek = cislo % 2;
                // a urci hodnotu v hexadecimalni soustave
                noveCislo = bin[zbytek] + noveCislo;

                cislo = cislo / 2;

            } while (cislo != 0);



            //vypsani cisla v binarni soustave
            Console.WriteLine("{0}[10] = {1}[2]", cislo, noveCislo);

        }

        private static void ChangeOfPrice()
        {
            // nacteni zakladni cena polozky
            Console.Write("Původní cena produktu [Kč]: ");
            double price = double.Parse(Console.ReadLine());
            // nacteni zmeny ceny v %
            Console.Write("Změna ceny[%]: ");
            double change = double.Parse(Console.ReadLine());
            // pokud je zmena kladna -> zvyseni ceny
            // pokud je cena zaporna -> sleva
            if (change > 0)
            {
                // zvyseni ceny
                // 1% .... price/100
                // X% .... (price/100)*change 
                // vysledna cena ..... price + (price/100)*change
                price = price + (price / 100) * change;
            }
            else
            {
                // snizeni ceny
                price = price + (price / 100) * change;
            }
            // vypsani nove ceny
            Console.WriteLine("Nová cena po změně {0}% je {1}", change, price);
        }

        private static void PerfectNumber()
        {
            Console.Write("Zjisteni, zda je cislo dokonale\nNacti cislo:");
            // nacist cislo
            int number = int.Parse(Console.ReadLine());
            int suma = 0;
            // zjistit delitele zadaneho cisla
            // priklad 6 -> 1, 2, 3, 6

            // pro zjisteni delitele pouzijeme %

            // ziskane delitele postupne scitat
            for (int i = 1; i <= number / 2; i++)
            {
                if ((number % i == 0))
                {
                    suma += i;
                }
            }

            // soucet delitelu == nactenemu cislu

            if (suma == number)
            {
                Console.WriteLine("\n{0} je dokonale", number);
            }
            else
            {
                Console.WriteLine("\n{0} neni dokonale", number);

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

            public void Vzdalenost(Point2D b)
            {
                double vzdalenost = Math.Sqrt((b.X - X) * (b.X - X) + (b.Y - Y) * (b.Y - Y));
                Console.WriteLine("|[{0},{1}],[{2},{3}]| = {4}", X, Y, b.X, b.Y, vzdalenost);
            }

        }

        private static void Vzdalenost(Point2D a, Point2D b)
        {
            // sqrt( (x2-x1)^2 + (y2-y1)^2 )
            double vzdalenost = Math.Sqrt((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y));
            Console.WriteLine("|[{0},{1}],[{2},{3}]| = {4}", a.X, a.Y, b.X, b.Y, vzdalenost);

        }
    }
}
