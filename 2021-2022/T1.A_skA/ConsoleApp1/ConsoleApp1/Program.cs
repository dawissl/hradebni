using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"zadejte hdnotu do proměnné {i+1}:");
                suma+= double.Parse(Console.ReadLine());
            }
           
            Console.WriteLine($"Suma hodnot je {suma}");
        }
    }
}
