using System;
/// <summary>
///  author = David Sládeček
/// </summary>
namespace Cycle
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Console.WriteLine("Zadejte číslo:");
            // double a = double.Parse(Console.ReadLine());

            // while

            /* 
             * while (a >= 0)
             {
                 a = a - 3.14;
                 Console.WriteLine(a);
             }*/


            // do-while
            /*
            do
            {
                a = a - 3.14;
                Console.WriteLine(a);
            } while (a >= 0);
            */

            int cislo;
            do
            {
                Console.Write("Zadejte číslo: ");
                cislo = int.Parse(Console.ReadLine());

                if (cislo >= 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");

                }
            } while (cislo != 0);
        }


    }
}
