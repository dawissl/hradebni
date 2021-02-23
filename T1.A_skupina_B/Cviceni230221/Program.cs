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
            NovaCena();
            Console.WriteLine("------------------------------");
            DokonaleCislo();

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
    }
}
