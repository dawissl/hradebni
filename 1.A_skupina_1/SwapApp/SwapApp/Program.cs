using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zadejte dvě čísla");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
