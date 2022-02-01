using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikace výtah");
            int vaha = 0;
            int pocetLidi = 0;

            while (vaha < 800 && pocetLidi < 8)
            {
                Console.Write("Vložte váhu dalšího člověka: ");
                int novaVaha = int.Parse(Console.ReadLine());
                if((vaha + novaVaha) > 800)
                {
                    Console.WriteLine("Nelze nastoupit, překročen váhový limit!");
                   continue;
                }
                vaha += novaVaha;
                pocetLidi++;
            }

            Console.WriteLine($"Do vytahu nastoupilo {pocetLidi} lidi a jejich váha je {vaha}kg");

        }
    }
}
