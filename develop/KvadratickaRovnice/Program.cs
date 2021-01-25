using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratickaRovnice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikace pro výpočet kořenů kvadratické rovnice");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Zadejte hodnoty A,B,C v rovnici Ax^2 + Bx + C = 0");
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            while (a == 0)
            {
                Console.WriteLine("Hodnota a nesmí být 0!");
                Console.Write("a: ");
                a = double.Parse(Console.ReadLine());
            }
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Hledání kořenů polynomu rovnice {0}x^2 + {1}x + {2} = 0", a, b, c);

            double d = Diskriminant(a, b, c);

            if (d < 0)
            {
                Console.WriteLine("Rovnice nemá řešení v oboru reálných hodnot");
            }
            else
            {
                double x1 = 0, x2 = 0;
                if (d == 0.0)
                {
                    // TODO - sem vložte kód, který řeší situaci, kdy je diskriminant roven 0
                    

                }
                else
                {
                    double tmp = Math.Sqrt(d);
                    // TODO - sem vložte kód, který řeší situaci, kdy je diskriminant větší než 0

                }

                Console.WriteLine("Kořeny kvadratické rovnice jsou {0} a {1}", x1, x2);
            }
        }

        private static double Diskriminant(double a, double b, double c)
        {
            double diskriminant = 0;
            // TODO - funkce která vypočte a vrátí hodnotu diskriminantu


            return diskriminant;


        }
    }
}
