using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] cisla = new int[5];

            Console.WriteLine("Zadejte 5 čísel");

            for(int i = 0; i < 5; i++)
            {
                cisla[i] = int.Parse(Console.ReadLine());
            }

           // cisla[0] = int.Parse(Console.ReadLine());
           // cisla[1] = int.Parse(Console.ReadLine());
           // cisla[2] = int.Parse(Console.ReadLine());
           // cisla[3] = int.Parse(Console.ReadLine());
           // cisla[4] = int.Parse(Console.ReadLine());

            int max = cisla[0];
            int min = cisla[0];

            for (int i = 1; i < 5; i++)
            {
                if (max < cisla[i])
                {
                    max = cisla[i];
                }
                if (min > cisla[i])
                {
                    min = cisla[i];
                }
            }

           /* if (max < cisla[1])
            {
                max = cisla[1];
            }
            if(min > cisla[1])
            {
                min = cisla[1];
            }

            if (max < cisla[2])
            {
                max = cisla[2];
            }
            if (min > cisla[2])
            {
                min = cisla[2];
            }

            if (max < cisla[3])
            {
                max = cisla[3];
            }
            if (min > cisla[3])
            {
                min = cisla[3];
            }

            if (max < cisla[4])
            {
                max = cisla[4];
            }
            if (min > cisla[4])
            {
                min = cisla[4];
            }*/

            Console.WriteLine("Max hodnota: {0}", max);
            Console.WriteLine("Min hodnota: {0}", min);



        }
    }
}
