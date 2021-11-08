using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[5];
            pole[0] = 5;
            pole[1] = 7;
            pole[2] = -6;
            pole[3] = 3;
            pole[4] = 2;

            int[] pole2;

            Console.WriteLine("Zadejete velikost pole:");

            pole2 = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Vložte hodnoty do pole:");

            for(int i = 0; i < pole2.Length; i++)
            {
                pole2[i] = int.Parse(Console.ReadLine());
            }
            //pole2[3] *= 2;
            int suma = 0;
            int max = pole2[0];

            Console.WriteLine("Výpis pole:");
            for(int i = 0; i < pole2.Length; i++)
            {
                Console.WriteLine(pole2[i]);
                suma = suma + pole2[i];
                if(pole2[i] > max)
                {
                    max = pole2[i];
                }
            }

            Console.WriteLine("suma hodnot: {0}", suma);
            Console.WriteLine("max hodnota: {0}", max);
        }
    }
}
