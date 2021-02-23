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
