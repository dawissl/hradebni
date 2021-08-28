using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Výpis vstupních argumentů:");
            if (args.Length == 0)
            {
                Console.WriteLine("Nebyly zadány žádné vstupní paramtery");
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }

        }
    }
}
