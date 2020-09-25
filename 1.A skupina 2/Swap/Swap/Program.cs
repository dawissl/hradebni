using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarování celočíselných proměnných a jejich inicializace ze vstupu po užití Parse()
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            // deklarace pomocné proměnné do které následně vložíme jednu z hodnot
            int tmp = a;
            a = b;
            b = tmp;

            //výpis proměnných a,b na konzoli
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
