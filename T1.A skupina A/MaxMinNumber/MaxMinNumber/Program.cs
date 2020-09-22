using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] poleCisel = new int[5];

            Console.WriteLine("Zadejte 5 cisel");

            poleCisel[0] = int.Parse(Console.ReadLine());
            poleCisel[1] = int.Parse(Console.ReadLine());
            poleCisel[2] = int.Parse(Console.ReadLine());
            poleCisel[3] = int.Parse(Console.ReadLine());
            poleCisel[4] = int.Parse(Console.ReadLine());


            int max = poleCisel[0];
            int min = poleCisel[0];

            if(poleCisel[1] > max)
            {
                max = poleCisel[1];
            }
            if(poleCisel[1] < min)
            {
                min = poleCisel[1];
            }
            // -------------------------
            if (poleCisel[2] > max)
            {
                max = poleCisel[2];
            }
            if (poleCisel[2] < min)
            {
                min = poleCisel[2];
            }
            // -------------------------
            if (poleCisel[3] > max)
            {
                max = poleCisel[3];
            }
            if (poleCisel[3] < min)
            {
                min = poleCisel[3];
            }
            // -------------------------
            if (poleCisel[4] > max)
            {
                max = poleCisel[4];
            }
            if (poleCisel[4] < min)
            {
                min = poleCisel[4];
            }
            // -------------------------
            Console.WriteLine("Maximum je {0} a minumum je {1}", max, min);

        }
    }
}
