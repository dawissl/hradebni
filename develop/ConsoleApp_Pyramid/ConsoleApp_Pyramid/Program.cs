using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {0,1,2,3,4,5,6,7,6,5,4,3,2,1,0};
            Console.WriteLine("Pyramida");
            int max = arr.Max();
            int actualMax = max;
            for (int i=0; i<max; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[j]>= actualMax)
                    {
                        Console.Write('*');
                        arr[j]--;
                    }
                    else
                    {
                        Console.Write(' ');
                    }       
                }
                actualMax--;
                Console.WriteLine();
            }
        }
    }
}
