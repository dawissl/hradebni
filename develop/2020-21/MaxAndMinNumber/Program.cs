using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxAndMinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikace, která určí nejmenší a nejvyšší číslo");
            Console.Write("Kolik čísel bude vloženo:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Zadejte {0} čísel.", size);
            for(int i = 0; i < size; i++)
            {
                Console.Write("{0}. číslo:", i+1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Čísla jsou načtena");
            int max = array[0];
            int min = array[0];

            for(int i = 1; i < size; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }

            // využitá vestavěných funkcí pro práci s polem
            // int max = array.Max();
            // int min = array.Min();
        
            Console.WriteLine("Nejvyšší číslo je {0} a nejmenší číslo je {1}", max, min) ;
        }
    }
}
