using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzultace
{
    class Program
    {
        static void Main(string[] args)
        {
            // procviceni II priklad E
             int a, b, c;

             Console.WriteLine("Insert three numbers:");
             a = int.Parse(Console.ReadLine());
             b = int.Parse(Console.ReadLine());
             c = int.Parse(Console.ReadLine());


             //////////////////////////
             ///
             int sum = a + b + c;

             Console.WriteLine("Suma je {0}", sum);
            Console.WriteLine(sum);
            Console.WriteLine("Suma je " + sum);
        

            // procivceni III priklad A
            double suma = 0;
            int pocet = 0;
            double hodnota;

            Console.WriteLine("Nacti hodnotu:");
            hodnota = double.Parse(Console.ReadLine());

            while(hodnota != 0)
            {
                suma = suma + hodnota;
                pocet = pocet + 1;
                Console.WriteLine("Nacti hodnotu:");
                hodnota = double.Parse(Console.ReadLine());
            }

            Console.Write("Výsledný aritmetický průměr je: ");
            if(pocet == 0)
            {
                Console.WriteLine(suma);
            }
            else
            {
                double prumer = suma / pocet;

  
                Console.WriteLine(prumer);
            }










            }
    }
}
