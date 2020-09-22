using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozdraveniUzivatele
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string jmeno;
            int vek;
            
            Console.WriteLine("Zadejte svoje jméno");
            jmeno = Console.ReadLine();
                    
            Console.WriteLine("Ahoj " + jmeno + " kolik Ti je let?");

            vek = int.Parse(Console.ReadLine());

            Console.WriteLine("Cože? Tobě už je " + vek + " to jsem nečekalo.");
            */
            int[] pole = new int[5];

            for(int i = 0; i < 5; i++)
            {
                pole[i] = int.Parse(Console.ReadLine());
            }

            int max = pole[0];
            if (pole[1]>max)
            {
                max = pole[1];
            }
            if (pole[2] > max)
            {
                max = pole[2];
            }
            if (pole[3] > max)
            {
                max = pole[3];
            }
            if (pole[4] > max)
            {
                max = pole[4];
            }

            Console.WriteLine(max);
        }
    }
}

