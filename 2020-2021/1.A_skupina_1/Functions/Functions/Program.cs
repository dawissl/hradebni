using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Foo1(12.3, 5.14));
            Console.WriteLine(Foo2(12));
            Console.WriteLine(Foo2(11));
             Foo3("Kamil",88);
        }
        private static double Foo1(double a, double b)
        {
            return a+b;
        }
        private static bool Foo2(int a)
        {
            return (a % 6) == 0;
        }

        private static void Foo3(string jmeno, int vek) {
            Console.WriteLine(jmeno + "_" + vek);
        }
    }
}
