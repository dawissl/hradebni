using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            string jmeno;
            int vek;
            Console.WriteLine("Napiš své jméno");
            jmeno = Console.ReadLine();
            Console.WriteLine("Napiš svůj věk");
            vek = int.Parse(Console.ReadLine());

            Console.WriteLine("Ahoj {0}, Tobě je už {1} roků?", jmeno, vek);
        }
    }
}
