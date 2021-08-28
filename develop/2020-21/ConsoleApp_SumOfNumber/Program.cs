using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_cv01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Zadávej čisla pro určení sumy zadaných čísel, pro ukončení vlož *.");
            Console.WriteLine("------------------------------------------------------------------");

            do
            {
                Suma();
                Console.Write("Ukončit program(ano/ne)? ");
            } while (Console.ReadLine().Equals("ne"));
           

        }

        private static void Suma()
        {
            int suma = 0;
            string input;
            bool end = false;
            do
            {
                Console.Write("vstup: ");
                input = Console.ReadLine();
                if (input.Equals("*"))
                {
                    end = true;
                    break;

                }
                else
                {
                    end = false;
                }
                suma += int.Parse(input);
            }
            while (!end);

            Console.WriteLine("Suma pro zadaná čísla je " + suma + ".");
        }
    }

    
}
