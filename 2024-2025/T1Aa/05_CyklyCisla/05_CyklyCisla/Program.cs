using System.Diagnostics.CodeAnalysis;

namespace _05_CyklyCisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vygenerovani nahodneho cisla od 1 do 10
            Random rnd = new Random();
            int number = rnd.Next(1, 11);
            while (number != 4)
            {
                Console.WriteLine(number);
                number = rnd.Next(1, 11);
            }
            Console.WriteLine("-----------------------");
            int cislo;
            do
            {
                cislo = rnd.Next(1, 11);
                if (cislo != 4)
                    Console.WriteLine(cislo);
            } while (cislo != 4);
            Console.WriteLine("##### 05_CislaCykly ######");
            int pocet = 0;
            int suma = 0;
            int cislaVetsiNez5 = 0;
            int x;
            do
            {
                Console.Write("Vlož číslo: ");
                x = int.Parse(Console.ReadLine());
                if (x != 0)
                {
                    pocet++;
                    suma += x;
                    if (x > 5) cislaVetsiNez5++;
                }
            } while (x != 0);
            Console.WriteLine($"uživatel zadal {pocet} čísel.");
            Console.WriteLine($"Suma vložených čísel je {suma}.");
            Console.WriteLine($"{cislaVetsiNez5} čísel je větších než 5.");

        }
    }
}