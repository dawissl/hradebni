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
            int[] pole = new int[5];

            Console.WriteLine("Zadejte 5 čísel:");

            for (int i=0; i < 5; i++)
            {
                pole[i] = int.Parse(Console.ReadLine());
            }

           // pole[0] = int.Parse(Console.ReadLine());
           // pole[1] = int.Parse(Console.ReadLine());
           // pole[2] = int.Parse(Console.ReadLine());
           // pole[3] = int.Parse(Console.ReadLine());
           // pole[4] = int.Parse(Console.ReadLine());

            int max = pole[0];
            int min = pole[0];

            for(int i= 1 ;i<5;i++)
            {
                if (pole[i] > max)
                {
                    max = pole[i];
                }
                if (pole[i] < min)
                {
                    min = pole[i];
                }
            }

/*
            if (pole[1] > max)
            {
                max = pole[1];
            } 
            if (pole[1] < min)
            {
                min = pole[1];
            }
            //---------------------------
            if (pole[2] > max)
            {
                max = pole[2];
            }
            if (pole[2] < min)
            {
                min = pole[2];
            }
            //---------------------------
            if (pole[3] > max)
            {
                max = pole[3];
            }
            if (pole[3] < min)
            {
                min = pole[3];
            }
            //---------------------------
            if (pole[4] > max)
            {
                max = pole[4];
            }
            if (pole[4] < min)
            {
                min = pole[4];
            }
            //---------------------------
            */
            Console.WriteLine("Maximum = " + max + " a minimum = " + min);

            Console.WriteLine("Maximum = {0} a minimum = {1}", max, min);
        }
    }
}
