namespace _01_Pozdrav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, World!");
            string slovo;
            Console.Write("Napiš slovo a zmáčkni Enter:");
            slovo = Console.ReadLine();
            // komentář, který je kompilátorem ignorován
            // $ = alt + 36
            // { = AltGr + B
            // } = AltGr + Nsla
            Console.WriteLine($"Načtené slovo: {slovo}");
            string cisloText = "27";
            int cislo = int.Parse(cisloText);
            Console.WriteLine($"Cislo je: {cislo}");*/
            Console.Write("Write your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}! How old are you?");
            Console.Write("Enter your age:");
            int age = int.Parse( Console.ReadLine() );
            Console.WriteLine($"Really {name}? It means that next year you are {age + 1}");

        }
    }
}