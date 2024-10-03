using System.ComponentModel;

namespace _01_Pozdrav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello, World!");
             Console.WriteLine("Napiš slovo");
             string slovo;
             slovo = Console.ReadLine();
             // komentář, který je kompilátorem ignorován
             // $ = alt + 36
             // { = AltGr + B
             // } = AltGr + N
             Console.WriteLine($"Načetl jsi slovo {slovo}");
             string cisloText = "1234";
             int cislo = int.Parse(cisloText);
             Console.WriteLine($"Prevedene cislo je: {cislo + 1}");
            */
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}! How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Really {name}? So, next year you will be {age + 1} years old.");
        }

    }
}