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

            // PerfektniCislo();

            // NovaCena();


        }

        private static void NovaCena()
        {
            // zmena ceny zbozi po procentualni uprave
            // nacteni puvodni ceny zbozi
            Console.Write("Původní cena [Kč]: ");
            double cena = double.Parse(Console.ReadLine());
            Console.Write("Změna ceny [%]: ");
            double zmena = double.Parse(Console.ReadLine());


            // zmena ceny - zaporná hodnota -> sleva
            //            - kladná hodnota -> zvyseni ceny
            if (zmena > 0)
            {
                // zvyseni ceny
                // 100 % ..... cena
                // 1% ......... cena/100
                // X .......... (cena/100) * (zmena+100)
                cena = (cena / 100) * (zmena + 100);
                Console.WriteLine("Cena po zvýšení o {0}% je {1}", zmena, cena);
            }
            else
            {
                // snizeni ceny
                cena = (cena / 100) * (zmena + 100);
                Console.WriteLine("Cena po snižení o {0}% je {1}", zmena * (-1), cena);

            }
        }

        private static void PerfektniCislo()
        {
            // dokonale cislo 6 = 1 + 2 +3
            Console.Write("Nacti cislo: ");
            // nacist cislo
            int number = int.Parse(Console.ReadLine());
            int suma = 0;
            // zjistit delitele cisla %
            for (int i = 1; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    //vsechny delitele secist
                    suma += i;
                }
            }
            // porovnat sumu delitelu s nactenym cislem
            if (suma == number)
            {
                Console.WriteLine("Cislo {0} je dokonalé.", number);
            }
            else
            {
                Console.WriteLine("Cislo {0} není dokonalé.", number);
            }
        }
    }
}
