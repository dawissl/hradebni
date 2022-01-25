using System;
/// <summary>
/// author = David Sládeček
/// </summary>
namespace Greetings
{
    class Program
    {
        /// <summary>
        ///  hlavni funkce
        /// </summary>
        /// <param name="args"> ccccc </param>
        static void Main(string[] args)
        {

            string a = "ab cd efg h ij k l";

            string[] b = a.Split(" ");
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < (b.Length - i); j--)
                {
                    Console.Write(b[j] + " ");
                }
                Console.WriteLine();
            }










           /* string jmeno;
            int vek;
            Console.WriteLine("Napiš své jméno");
            jmeno = Console.ReadLine();
            Console.WriteLine("Napiš svůj věk");
            vek = int.Parse(Console.ReadLine());

            Console.WriteLine("Ahoj {0}, Tobě je už {1} roků?", jmeno, vek);
       */ }
    }
}
