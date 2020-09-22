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
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int tmp = a;
            a = b;
            b = tmp;

            //výpis proměnných a,b na konzoli
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
