using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[5];

            pole[0] = 4;
            pole[1] = 2;
            pole[2] = 12;
            pole[3] = -3;
            pole[4] = 15;

            int[] pole2;

            Console.Write("Zadejte velikost pole:");
            pole2 = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Načtěte hodnoty v poli.");
            for(int i = 0; i < pole2.Length; i++)
            {
                pole2[i] = int.Parse(Console.ReadLine());
            }


            pole[4] = pole[4] - 8;

            Console.WriteLine("Výpis pole a pole2:");

            int suma = 0;
            int max = pole2[0];

            // for(řidici proměnná; podmínka; změna proměnné)
            for(int i = 0; i < pole2.Length; i++)
            {
                Console.WriteLine(pole2[i]);
                suma = suma + pole2[i];

                if (pole2[i] > max)
                {
                    max = pole2[i];
                }

            }

            Console.WriteLine("suma hodnot: {0}", suma);
            Console.WriteLine("maximální hodnota: {0}", max);

            
        }
    }
}
