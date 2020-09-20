using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program, který bude určovat, zda je načtené číslo sudé nebo liché");
            Console.Write("Pro ukončení programu vložte číslo 0\n>");
            int input;
            while ((input = int.Parse(Console.ReadLine())) != 0)
            {
                if ((input % 2) == 0)
                {
                    Console.Write("Číslo {0} je sudé\n>", input);
                }
                else
                {
                    Console.Write("Číslo {0} je liché\n>", input);
                }

            }


            Console.WriteLine("Program byl ukončen.");

        }
    }
}
