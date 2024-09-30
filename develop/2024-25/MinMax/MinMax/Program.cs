using System.Diagnostics;

namespace MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Načtení třech hodnot");
            Console.Write("První číslo:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Druhé číslo:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Třetí číslo číslo:");
            int c = int.Parse(Console.ReadLine());

            int min = a;
            int max = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (c > max) max = c;
            if (c > max) max = c;
            Console.WriteLine($"Nejvyšší hodnota je {max} a nejmenší hodnota je {min}");
        }
    }
}