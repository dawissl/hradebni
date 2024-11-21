using System.Runtime.Serialization.Formatters;

namespace _06_CyklyObrazce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Součet N čísel zadaných od uživatele.
             * Počet načtených hodnot, je rovněž zadán užívatelem
             */
            int suma = 0;
            Console.WriteLine("Kolik čísel budeme sčítat?");
            int pocet = int.Parse(Console.ReadLine());
            // deklarace řídící proměnné; podmínka s řídící proměnnou; editace řídící proměnné
            for (int i = 0; i < pocet; i++)
            {
                // $ = alt + 36
                Console.Write($"Zadejte {i + 1}. číslo z {pocet}:");
                // suma = suma + int.Parse(...);
                suma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Výsledná suma {pocet} čísel je {suma}");
            Console.WriteLine("------------06_CyklyObrazce---------------");
            Console.Write("Výška obrazce ");
            int vyska = int.Parse(Console.ReadLine());

            for (int i = 0; i < vyska; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" + ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");
            for (int i = vyska - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" + ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");
            // počet mezer před vypisóvaním hvězdiček
            int radek = vyska * 2 - 1;
            for (int i = 0; i < vyska; i++)
            {
                // cyklus pro odbavení mezer
                for (int j = 0; j < radek -vyska; j++)
                {
                    Console.Write(" ");
                }
                // vykreslovani hvězd
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
                radek--;
            }
        }
    }
}